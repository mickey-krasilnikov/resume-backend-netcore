using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.ApiClient;
using ResumeApp.DataAccess.Sql.Context;
using ResumeApp.DataAccess.Sql.Entities;

namespace ResumeApp.ContractTests.Controllers
{
    public class EducationTests : IClassFixture<TestFixture>
    {
        private readonly IResumeApiClient _apiClient;
        private readonly ISqlDbContext _sqlDbContext;

        public EducationTests(TestFixture testFixture)
        {
            _apiClient = new ResumeApiClient(testFixture.CreateClient());
            _sqlDbContext = testFixture.Services.CreateScope().ServiceProvider.GetService<ISqlDbContext>();
        }

        #region HappyPath

        [Fact]
        public async Task GetAllEducation_HappyPath()
        {
            // Arrange
            ICollection<EducationDto> education = null;
            var expectedEducation = new EducationSqlEntity()
            {
                Id = Guid.NewGuid(),
                Name = "testEduication",
                Degree = "testDegree",
                FieldOfStudy = "testFieldOfStudy",
                Url = new Uri("https://testUrl.com"),
                StartDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-6)),
                EndDate = DateOnly.FromDateTime(DateTime.UtcNow)
            };

            // Act
            try
            {
                await InitializeWithEntityAsync(expectedEducation);
                education = await _apiClient.EducationAllAsync();
            }
            finally { await CleanUpAsync(); }

            // Assert
            Assert.NotEmpty(education);
            Assert.Single(education);
            Assert.Equal(expectedEducation.Id, education.Single().Id);
            Assert.Equal(expectedEducation.Name, education.Single().Name);
            Assert.Equal(expectedEducation.Degree, education.Single().Degree);
            Assert.Equal(expectedEducation.FieldOfStudy, education.Single().FieldOfStudy);
            Assert.Equal(expectedEducation.Url, education.Single().Url);
            Assert.Equal(expectedEducation.StartDate, DateOnly.FromDateTime(education.Single().StartDate.DateTime));
            Assert.Equal(expectedEducation.EndDate, DateOnly.FromDateTime(education.Single().EndDate.Value.DateTime));

        }

        [Fact]
        public async Task GetEducationById_HappyPath()
        {
            // Arrange
            EducationDto education = null;
            var educationId = Guid.NewGuid();
            var expectedEducation = new EducationSqlEntity()
            {
                Id = educationId,
                Name = "testEduication",
                Degree = "testDegree",
                FieldOfStudy = "testFieldOfStudy",
                Url = new Uri("https://testUrl.com"),
                StartDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-6)),
                EndDate = DateOnly.FromDateTime(DateTime.UtcNow)
            };

            try
            {
                await InitializeWithEntityAsync(expectedEducation);
                education = await _apiClient.EducationGETAsync(educationId.ToString());
            }
            finally { await CleanUpAsync(); }

            // Assert
            Assert.NotNull(education);
            Assert.Equal(expectedEducation.Id, education.Id);
            Assert.Equal(expectedEducation.Name, education.Name);
            Assert.Equal(expectedEducation.Degree, education.Degree);
            Assert.Equal(expectedEducation.FieldOfStudy, education.FieldOfStudy);
            Assert.Equal(expectedEducation.Url, education.Url);
            Assert.Equal(expectedEducation.StartDate, DateOnly.FromDateTime(education.StartDate.DateTime));
            Assert.Equal(expectedEducation.EndDate, DateOnly.FromDateTime(education.EndDate.Value.DateTime));
        }

        [Fact]
        public async Task PostEducation_HappyPath()
        {
            // Arrange
            EducationSqlEntity educationBefore = null;
            EducationSqlEntity educationAfter = null;
            var educationToPost = new EducationDto()
            {
                Name = "testEduication",
                Degree = "testDegree",
                FieldOfStudy = "testFieldOfStudy",
                Url = new Uri("https://testUrl.com"),
                StartDate = DateTimeOffset.UtcNow.AddYears(-6),
                EndDate = DateTimeOffset.UtcNow
            };

            // Act
            try
            {
                educationBefore = _sqlDbContext.Educations.AsNoTracking().SingleOrDefault();
                await _apiClient.EducationPOSTAsync(educationToPost);
                educationAfter = _sqlDbContext.Educations.AsNoTracking().Single();
            }
            finally { await CleanUpAsync(); }

            // Assert
            Assert.Null(educationBefore);
            Assert.NotNull(educationAfter);
            Assert.Equal(Guid.Empty, educationToPost.Id);
            Assert.NotEqual(Guid.Empty, educationAfter.Id);

            Assert.Equal(educationToPost.Name, educationAfter.Name);
            Assert.Equal(educationToPost.Degree, educationAfter.Degree);
            Assert.Equal(educationToPost.FieldOfStudy, educationAfter.FieldOfStudy);
            Assert.Equal(educationToPost.Url, educationAfter.Url);
            Assert.Equal(DateOnly.FromDateTime(educationToPost.StartDate.DateTime), educationAfter.StartDate);
            Assert.Equal(DateOnly.FromDateTime(educationToPost.EndDate.Value.DateTime), educationAfter.EndDate.Value);
        }

        [Fact]
        public async Task PutEducation_HappyPath()
        {
            // Arrange
            EducationSqlEntity educationBefore = null;
            EducationSqlEntity educationAfter = null;
            var educationId = Guid.NewGuid();
            var initialEducation = new EducationSqlEntity()
            {
                Id = educationId,
                Name = "testEduication1",
                Degree = "testDegree1",
                FieldOfStudy = "testFieldOfStudy1",
                Url = new Uri("https://testUrl1.com"),
                StartDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-6)),
                EndDate = DateOnly.FromDateTime(DateTime.UtcNow)
            };
            var educationToPut = new EducationDto()
            {
                Id = educationId,
                Name = "testEduication2",
                Degree = "testDegree2",
                FieldOfStudy = "testFieldOfStudy2",
                Url = new Uri("https://testUrl2.com"),
                StartDate = DateTimeOffset.UtcNow.AddYears(-12),
                EndDate = DateTimeOffset.UtcNow.AddYears(-6)
            };

            // Act
            try
            {
                await InitializeWithEntityAsync(initialEducation);
                educationBefore = _sqlDbContext.Educations.AsNoTracking().Single();
                await _apiClient.EducationPUTAsync(educationId.ToString(), educationToPut);
                educationAfter = _sqlDbContext.Educations.AsNoTracking().Single();
            }
            finally { await CleanUpAsync(); }

            // Assert
            Assert.NotNull(educationBefore);
            Assert.NotNull(educationAfter);
            Assert.Equal(educationBefore.Id, educationAfter.Id);

            Assert.NotEqual(educationBefore.Name, educationAfter.Name);
            Assert.NotEqual(educationBefore.Degree, educationAfter.Degree);
            Assert.NotEqual(educationBefore.FieldOfStudy, educationAfter.FieldOfStudy);
            Assert.NotEqual(educationBefore.Url, educationAfter.Url);
            Assert.NotEqual(educationBefore.StartDate, educationAfter.StartDate);
            Assert.NotEqual(educationBefore.EndDate.Value, educationAfter.EndDate);

            Assert.Equal(educationToPut.Name, educationAfter.Name);
            Assert.Equal(educationToPut.Degree, educationAfter.Degree);
            Assert.Equal(educationToPut.FieldOfStudy, educationAfter.FieldOfStudy);
            Assert.Equal(educationToPut.Url, educationAfter.Url);
            Assert.Equal(DateOnly.FromDateTime(educationToPut.StartDate.DateTime), educationAfter.StartDate);
            Assert.Equal(DateOnly.FromDateTime(educationToPut.EndDate.Value.DateTime), educationAfter.EndDate);
        }

        [Fact]
        public async Task DeleteEducation_HappyPath()
        {
            // Arrange
            var educationId = Guid.NewGuid();
            var educationToDelete = new EducationSqlEntity()
            {
                Id = educationId,
                Name = "testEduication",
                Degree = "testDegree",
                FieldOfStudy = "testFieldOfStudy",
                Url = new Uri("https://testUrl.com"),
                StartDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-6)),
                EndDate = DateOnly.FromDateTime(DateTime.UtcNow)
            };

            // Act
            await InitializeWithEntityAsync(educationToDelete);
            var educationBefore = _sqlDbContext.Educations.AsNoTracking().Single();
            await _apiClient.EducationDELETEAsync(educationId.ToString());
            var educationAfter = _sqlDbContext.Educations.AsNoTracking().SingleOrDefault();

            // Assert
            Assert.NotNull(educationBefore);
            Assert.Null(educationAfter);
        }

        #endregion HappyPath

        private async Task InitializeWithEntityAsync(EducationSqlEntity entity)
        {
            _sqlDbContext.Educations.Add(entity);
            await _sqlDbContext.SaveChangesAsync();
        }

        private async Task CleanUpAsync()
        {
            _sqlDbContext.Educations.RemoveRange(_sqlDbContext.Educations.ToList());
            await _sqlDbContext.SaveChangesAsync();
        }
    }
}