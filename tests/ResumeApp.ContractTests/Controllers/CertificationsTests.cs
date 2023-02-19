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
        private readonly ISqlDbContext _context;

        public CertificationsTests(TestFixture testFixture)
        {
            _apiClient = new ResumeApiClient(testFixture.CreateClient());
            _sqlDbContext = testFixture.Services.CreateScope().ServiceProvider.GetService<ISqlDbContext>();
        }

        #region HappyPath

        [Fact]
        public async Task GetAllCertificates_HappyPath()
        {
            // Arrange
            var certificate = new CertificationSqlEntity()
            {
                Id = Guid.NewGuid(),
                Name = "Test certificate",
                Issuer = "Test issuer",
                VerificationUrl = new Uri("https://test@certificate.com"),
                IssueDate = DateOnly.FromDateTime(DateTime.UtcNow)
            };
            _sqlDbContext.Certifications.Add(certificate);
            await _sqlDbContext.SaveChangesAsync();

            // Act
            var certificates = await _apiClient.CertificationAllGETAsync();

            // Assert
            Assert.NotEmpty(certificates);

            _sqlDbContext.Certifications.Remove(certificate);
            await _sqlDbContext.SaveChangesAsync();
        }

        #endregion HappyPath
    }
}