using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.ApiClient;
using ResumeApp.DataAccess.Sql.Context;
using ResumeApp.DataAccess.Sql.Entities;

namespace ResumeApp.ContractTests.Controllers
{
    public class CertificationsTests : IClassFixture<TestFixture>
    {
        private readonly IResumeApiClient _apiClient;
        private readonly ISqlDbContext _sqlDbContext;

        public CertificationsTests(TestFixture testFixture)
        {
            _apiClient = new ResumeApiClient(testFixture.CreateClient());
            _sqlDbContext = testFixture.Services.CreateScope().ServiceProvider.GetService<ISqlDbContext>();
        }

        [Fact]
        public async Task GetAllCertificates_HappyPath()
        {
            // Arrange
            var expectedCertificate = new CertificationSqlEntity()
            {
                Id = Guid.NewGuid(),
                Name = "Test certificate",
                Issuer = "Test issuer",
                VerificationUrl = new Uri("https://testcertificate.com"),
                IssueDate = DateOnly.FromDateTime(DateTime.UtcNow)
            };

            // Act
            _sqlDbContext.Certifications.Add(expectedCertificate);
            await _sqlDbContext.SaveChangesAsync();

            var certificates = await _apiClient.CertificationAllAsync();

            _sqlDbContext.Certifications.Remove(expectedCertificate);
            await _sqlDbContext.SaveChangesAsync();

            // Assert
            Assert.NotEmpty(certificates);
            Assert.Single(certificates);
            Assert.Equal(expectedCertificate.Id, certificates.Single().Id);
            Assert.Equal(expectedCertificate.Name, certificates.Single().Name);
            Assert.Equal(expectedCertificate.Issuer, certificates.Single().Issuer);
            Assert.Equal(expectedCertificate.VerificationUrl, certificates.Single().VerificationUrl);
            Assert.Equal(expectedCertificate.IssueDate, DateOnly.FromDateTime(certificates.Single().IssueDate.DateTime));

        }

        [Fact]
        public async Task GetCertificateById_HappyPath()
        {
            // Arrange
            var certificateId = Guid.NewGuid();
            var expectedCertificate = new CertificationSqlEntity()
            {
                Id = certificateId,
                Name = "Test certificate",
                Issuer = "Test issuer",
                VerificationUrl = new Uri("https://testcertificate.com"),
                IssueDate = DateOnly.FromDateTime(DateTime.UtcNow)
            };

            // Act
            _sqlDbContext.Certifications.Add(expectedCertificate);
            await _sqlDbContext.SaveChangesAsync();

            var certificate = await _apiClient.CertificationGETAsync(certificateId.ToString());

            _sqlDbContext.Certifications.Remove(expectedCertificate);
            await _sqlDbContext.SaveChangesAsync();

            // Assert
            Assert.NotNull(certificate);
            Assert.Equal(expectedCertificate.Id, certificate.Id);
            Assert.Equal(expectedCertificate.Name, certificate.Name);
            Assert.Equal(expectedCertificate.Issuer, certificate.Issuer);
            Assert.Equal(expectedCertificate.VerificationUrl, certificate.VerificationUrl);
            Assert.Equal(expectedCertificate.IssueDate, DateOnly.FromDateTime(certificate.IssueDate.DateTime));
        }

        [Fact]
        public async Task PostCertificate_HappyPath()
        {
            // Arrange
            var certificateId = Guid.NewGuid();
            var certificateToPost = new CertificationDto()
            {
                //Id = certificateId,
                Name = "Test certificate",
                Issuer = "Test issuer",
                VerificationUrl = new Uri("https://testcertificate.com"),
                IssueDate = DateTimeOffset.Now
            };

            // Act
            var certificatesBefore = _sqlDbContext.Certifications.AsNoTracking().SingleOrDefault();
            var certificate = await _apiClient.CertificationPOSTAsync(certificateToPost);
            var certificatesAfter = _sqlDbContext.Certifications.AsNoTracking().Single();

            _sqlDbContext.Certifications.RemoveRange(_sqlDbContext.Certifications.ToList());
            await _sqlDbContext.SaveChangesAsync();

            // Assert
            Assert.Null(certificatesBefore);
            Assert.NotNull(certificatesAfter);
            Assert.Equal(Guid.Empty, certificateToPost.Id);
            Assert.NotEqual(Guid.Empty, certificatesAfter.Id);
            Assert.Equal(certificateToPost.Name, certificatesAfter.Name);
            Assert.Equal(certificateToPost.Issuer, certificatesAfter.Issuer);
            Assert.Equal(certificateToPost.VerificationUrl, certificatesAfter.VerificationUrl);
            Assert.Equal(DateOnly.FromDateTime(certificateToPost.IssueDate.DateTime), certificatesAfter.IssueDate);
        }

        [Fact]
        public async Task PutCertificate_HappyPath()
        {
            // Arrange
            var certificateId = Guid.NewGuid();
            var initialCertificate = new CertificationSqlEntity()
            {
                Id = certificateId,
                Name = "Test certificate 1",
                Issuer = "Test issuer 1",
                VerificationUrl = new Uri("https://testcertificate1.com"),
                IssueDate = DateOnly.FromDateTime(DateTime.UtcNow).AddDays(-1)
            };
            var certificateToPut = new CertificationDto()
            {
                Id = certificateId,
                Name = "Test certificate 2",
                Issuer = "Test issuer 2",
                VerificationUrl = new Uri("https://testcertificate2.com"),
                IssueDate = DateTimeOffset.Now
            };

            // Act
            _sqlDbContext.Certifications.Add(initialCertificate);
            await _sqlDbContext.SaveChangesAsync();
            var certificatesBefore = _sqlDbContext.Certifications.AsNoTracking().Single();

            await _apiClient.CertificationPUTAsync(certificateId.ToString(), certificateToPut);

            var certificatesAfter = _sqlDbContext.Certifications.AsNoTracking().Single();
            _sqlDbContext.Certifications.RemoveRange(_sqlDbContext.Certifications.ToList());
            await _sqlDbContext.SaveChangesAsync();

            // Assert
            Assert.NotNull(certificatesBefore);
            Assert.NotNull(certificatesAfter);
            Assert.Equal(certificatesBefore.Id, certificatesAfter.Id);
            Assert.NotEqual(certificatesBefore.Name, certificatesAfter.Name);
            Assert.NotEqual(certificatesBefore.Issuer, certificatesAfter.Issuer);
            Assert.NotEqual(certificatesBefore.VerificationUrl, certificatesAfter.VerificationUrl);
            Assert.NotEqual(certificatesBefore.IssueDate, certificatesAfter.IssueDate);

            Assert.Equal(certificateToPut.Name, certificatesAfter.Name);
            Assert.Equal(certificateToPut.Issuer, certificatesAfter.Issuer);
            Assert.Equal(certificateToPut.VerificationUrl, certificatesAfter.VerificationUrl);
            Assert.Equal(DateOnly.FromDateTime(certificateToPut.IssueDate.DateTime), certificatesAfter.IssueDate);
        }


        [Fact]
        public async Task DeleteCertificate_HappyPath()
        {
            // Arrange
            var certificateId = Guid.NewGuid();
            var certificateToDelete = new CertificationSqlEntity()
            {
                Id = certificateId,
                Name = "Test certificate",
                Issuer = "Test issuer",
                VerificationUrl = new Uri("https://testcertificate.com"),
                IssueDate = DateOnly.FromDateTime(DateTime.UtcNow).AddDays(-1)
            };

            // Act
            _sqlDbContext.Certifications.Add(certificateToDelete);
            await _sqlDbContext.SaveChangesAsync();
            var certificatesBefore = _sqlDbContext.Certifications.AsNoTracking().Single();
            await _apiClient.CertificationDELETEAsync(certificateId.ToString());
            var certificatesAfter = _sqlDbContext.Certifications.AsNoTracking().SingleOrDefault();

            // Assert
            Assert.NotNull(certificatesBefore);
            Assert.Null(certificatesAfter);
        }
        #endregion HappyPath
    }
}