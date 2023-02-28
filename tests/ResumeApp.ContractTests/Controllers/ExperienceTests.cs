using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.ApiClient;
using ResumeApp.BusinessLogic.Constants;
using ResumeApp.DataAccess.Sql.Context;
using ResumeApp.DataAccess.Sql.Entities;

namespace ResumeApp.ContractTests.Controllers
{
    public class ExperienceTests : IClassFixture<TestFixture>
    {
        private readonly IResumeApiClient _apiClient;
        private readonly ISqlDbContext _sqlDbContext;

        public ExperienceTests(TestFixture testFixture)
        {
            _apiClient = new ResumeApiClient(testFixture.CreateClient());
            _sqlDbContext = testFixture.Services.CreateScope().ServiceProvider.GetService<ISqlDbContext>();
        }

        #region HappyPath

        [Fact]
        public async Task GetAllExperiences_HappyPath()
        {
            // Arrange
            ICollection<ExperienceDto> experiences = null;
            var expectedExperience = new ExperienceSqlEntity()
            {
                Id = Guid.NewGuid(),
                Title = "testExperience",
                Company = "testCompany",
                Location = "testLocation",
                TaskPerformed = "testTaskPerformed1\ntestTaskPerformed2",
                StartDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-1)),
                EndDate = DateOnly.FromDateTime(DateTime.UtcNow),
            };

            // Act
            try
            {
                await InitializeWithEntityAsync(expectedExperience);
                experiences = await _apiClient.ExperienceAllAsync();
            }
            finally { await CleanUpAsync(); }

            // Assert
            Assert.NotEmpty(experiences);
            Assert.Single(experiences);
            Assert.Equal(expectedExperience.Id, experiences.Single().Id);
            Assert.Equal(expectedExperience.Title, experiences.Single().Title);
            Assert.Equal(expectedExperience.Company, experiences.Single().Company);
            Assert.Equal(expectedExperience.Location, experiences.Single().Location);
            Assert.Equal(expectedExperience.TaskPerformed, string.Join('\n', experiences.Single().TaskPerformed));
            Assert.Equal(expectedExperience.StartDate.ToString(DateFormats.DateOnlyFormat), experiences.Single().StartDate);
            Assert.Equal(expectedExperience.EndDate.Value.ToString(DateFormats.DateOnlyFormat), experiences.Single().EndDate);
        }

        [Fact]
        public async Task GetExperienceById_HappyPath()
        {
            // Arrange
            ExperienceDto experience = null;
            var experienceId = Guid.NewGuid();
            var expectedExperience = new ExperienceSqlEntity()
            {
                Id = experienceId,
                Title = "testExperience",
                Company = "testCompany",
                Location = "testLocation",
                TaskPerformed = "testTaskPerformed1\ntestTaskPerformed2",
                StartDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-1)),
                EndDate = DateOnly.FromDateTime(DateTime.UtcNow),
            };

            // Act
            try
            {
                await InitializeWithEntityAsync(expectedExperience);
                experience = await _apiClient.ExperienceGETAsync(experienceId.ToString());
            }
            finally { await CleanUpAsync(); }

            // Assert
            Assert.NotNull(experience);
            Assert.Equal(expectedExperience.Id, experience.Id);
            Assert.Equal(expectedExperience.Title, experience.Title);
            Assert.Equal(expectedExperience.Company, experience.Company);
            Assert.Equal(expectedExperience.Location, experience.Location);
            Assert.Equal(expectedExperience.TaskPerformed, string.Join('\n', experience.TaskPerformed));
            Assert.Equal(expectedExperience.StartDate.ToString(DateFormats.DateOnlyFormat), experience.StartDate);
            Assert.Equal(expectedExperience.EndDate.Value.ToString(DateFormats.DateOnlyFormat), experience.EndDate);
        }

        [Fact]
        public async Task PostExperience_HappyPath()
        {
            // Arrange
            ExperienceSqlEntity experienceBefore = null;
            ExperienceSqlEntity experienceAfter = null;
            var experienceToPost = new ExperienceDto()
            {
                Title = "testExperience",
                Company = "testCompany",
                Location = "testLocation",
                TaskPerformed = new List<string> { "testTaskPerformed1", "testTaskPerformed2" },
                StartDate = DateTimeOffset.UtcNow.AddYears(-1).ToString(DateFormats.DateOnlyFormat),
                EndDate = DateTimeOffset.UtcNow.ToString(DateFormats.DateOnlyFormat),
            };

            // Act
            try
            {
                experienceBefore = _sqlDbContext.Experiences.AsNoTracking().SingleOrDefault();
                await _apiClient.ExperiencePOSTAsync(experienceToPost);
                experienceAfter = _sqlDbContext.Experiences.AsNoTracking().Single();
            }
            finally { await CleanUpAsync(); }

            // Assert
            Assert.Null(experienceBefore);
            Assert.NotNull(experienceAfter);
            Assert.Equal(Guid.Empty, experienceToPost.Id);
            Assert.NotEqual(Guid.Empty, experienceAfter.Id);

            Assert.Equal(experienceToPost.Title, experienceAfter.Title);
            Assert.Equal(experienceToPost.Company, experienceAfter.Company);
            Assert.Equal(experienceToPost.Location, experienceAfter.Location);
            Assert.Equal(string.Join('\n', experienceToPost.TaskPerformed), experienceAfter.TaskPerformed);
            Assert.Equal(experienceToPost.StartDate, experienceAfter.StartDate.ToString(DateFormats.DateOnlyFormat));
            Assert.Equal(experienceToPost.EndDate, experienceAfter.EndDate.Value.ToString(DateFormats.DateOnlyFormat));
        }

        [Fact]
        public async Task PutExperience_HappyPath()
        {
            // Arrange
            ExperienceSqlEntity experienceBefore = null;
            ExperienceSqlEntity experienceAfter = null;
            var experienceId = Guid.NewGuid();
            var initialExperience = new ExperienceSqlEntity()
            {
                Id = experienceId,
                Title = "testExperience1",
                Company = "testCompany1",
                Location = "testLocation1",
                TaskPerformed = "testTaskPerformed1\ntestTaskPerformed2",
                StartDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-1)),
                EndDate = DateOnly.FromDateTime(DateTime.UtcNow),
            };
            var experienceToPut = new ExperienceDto()
            {
                Id = experienceId,
                Title = "testExperience2",
                Company = "testCompany2",
                Location = "testLocation2",
                TaskPerformed = new List<string> { "testTaskPerformed3", "testTaskPerformed4" },
                StartDate = DateTimeOffset.UtcNow.AddYears(-1).ToString(DateFormats.DateOnlyFormat),
                EndDate = DateTimeOffset.UtcNow.ToString(DateFormats.DateOnlyFormat),
            };

            // Act
            try
            {
                await InitializeWithEntityAsync(initialExperience);
                experienceBefore = _sqlDbContext.Experiences.AsNoTracking().Single();
                await _apiClient.ExperiencePUTAsync(experienceId.ToString(), experienceToPut);
                experienceAfter = _sqlDbContext.Experiences.AsNoTracking().Single();
            }
            finally { await CleanUpAsync(); }

            // Assert
            Assert.NotNull(experienceBefore);
            Assert.NotNull(experienceAfter);
            Assert.Equal(experienceBefore.Id, experienceAfter.Id);

            Assert.NotEqual(experienceBefore.Title, experienceAfter.Title);
            Assert.NotEqual(experienceBefore.Company, experienceAfter.Company);
            Assert.NotEqual(experienceBefore.Location, experienceAfter.Location);
            Assert.NotEqual(string.Join('\n', experienceBefore.TaskPerformed), experienceAfter.TaskPerformed);
            Assert.Equal(experienceBefore.StartDate, experienceAfter.StartDate);
            Assert.Equal(experienceBefore.EndDate.Value, experienceAfter.EndDate.Value);

            Assert.Equal(experienceToPut.Title, experienceAfter.Title);
            Assert.Equal(experienceToPut.Company, experienceAfter.Company);
            Assert.Equal(experienceToPut.Location, experienceAfter.Location);
            Assert.Equal(string.Join('\n', experienceToPut.TaskPerformed), experienceAfter.TaskPerformed);
            Assert.Equal(experienceToPut.StartDate, experienceAfter.StartDate.ToString(DateFormats.DateOnlyFormat));
            Assert.Equal(experienceToPut.EndDate, experienceAfter.EndDate.Value.ToString(DateFormats.DateOnlyFormat));
        }

        [Fact]
        public async Task DeleteExperience_HappyPath()
        {
            // Arrange
            var experienceId = Guid.NewGuid();
            var experienceToDelete = new ExperienceSqlEntity()
            {
                Id = experienceId,
                Title = "testExperience",
                Company = "testCompany",
                Location = "testLocation",
                TaskPerformed = "testTaskPerformed1\ntestTaskPerformed2",
                StartDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-1)),
                EndDate = DateOnly.FromDateTime(DateTime.UtcNow),
            };

            // Act
            await InitializeWithEntityAsync(experienceToDelete);
            var experienceBefore = _sqlDbContext.Experiences.AsNoTracking().Single();
            await _apiClient.ExperienceDELETEAsync(experienceId.ToString());
            var experienceAfter = _sqlDbContext.Experiences.AsNoTracking().SingleOrDefault();

            // Assert
            Assert.NotNull(experienceBefore);
            Assert.Null(experienceAfter);
        }

        #endregion HappyPath

        private async Task InitializeWithEntityAsync(ExperienceSqlEntity entity)
        {
            _sqlDbContext.Experiences.Add(entity);
            await _sqlDbContext.SaveChangesAsync();
        }

        private async Task CleanUpAsync()
        {
            _sqlDbContext.Experiences.RemoveRange(_sqlDbContext.Experiences.ToList());
            await _sqlDbContext.SaveChangesAsync();
        }
    }
}