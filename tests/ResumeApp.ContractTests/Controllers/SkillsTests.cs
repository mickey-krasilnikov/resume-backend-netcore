using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.ApiClient;
using ResumeApp.DataAccess.Sql.Context;
using ResumeApp.DataAccess.Sql.Entities;

namespace ResumeApp.ContractTests.Controllers
{
    public class SkillsTests : IClassFixture<TestFixture>
    {
        private readonly IResumeApiClient _apiClient;
        private readonly ISqlDbContext _sqlDbContext;

        public SkillsTests(TestFixture testFixture)
        {
            _apiClient = new ResumeApiClient(testFixture.CreateClient());
            _sqlDbContext = testFixture.Services.CreateScope().ServiceProvider.GetService<ISqlDbContext>();
        }

        #region HappyPath

        [Fact]
        public async Task GetAllSkills_HappyPath()
        {
            // Arrange
            ICollection<SkillDto> skills = null;
            var expectedSkill = new SkillSqlEntity()
            {
                Id = Guid.NewGuid(),
                Name = "testName",
                SkillGroup = "testSkillGroup"
            };

            // Act
            try
            {
                await InitializeWithEntityAsync(expectedSkill);
                skills = await _apiClient.SkillsAllAsync();
            }
            finally { await CleanUpAsync(); }

            // Assert
            Assert.NotEmpty(skills);
            Assert.Single(skills);
            Assert.Equal(expectedSkill.Id, skills.Single().Id);
            Assert.Equal(expectedSkill.Name, skills.Single().Name);
            Assert.Equal(expectedSkill.SkillGroup, skills.Single().SkillGroup);
        }

        [Fact]
        public async Task GetSkillById_HappyPath()
        {
            // Arrange
            SkillDto skill = null;
            var skillId = Guid.NewGuid();
            var expectedSkill = new SkillSqlEntity()
            {
                Id = skillId,
                Name = "testName",
                SkillGroup = "testSkillGroup"
            };

            // Act
            try
            {
                await InitializeWithEntityAsync(expectedSkill);
                skill = await _apiClient.SkillsGETAsync(skillId.ToString());
            }
            finally { await CleanUpAsync(); }

            // Assert
            Assert.NotNull(skill);
            Assert.Equal(expectedSkill.Id, skill.Id);
            Assert.Equal(expectedSkill.Name, skill.Name);
            Assert.Equal(expectedSkill.SkillGroup, skill.SkillGroup);
        }

        [Fact]
        public async Task PostSkill_HappyPath()
        {
            // Arrange
            SkillSqlEntity skillBefore = null;
            SkillSqlEntity skillAfter = null;
            var skillToPost = new SkillDto()
            {
                Name = "testName",
                SkillGroup = "testSkillGroup"
            };

            // Act
            try
            {
                skillBefore = _sqlDbContext.Skills.AsNoTracking().SingleOrDefault();
                await _apiClient.SkillsPOSTAsync(skillToPost);
                skillAfter = _sqlDbContext.Skills.AsNoTracking().Single();
            }
            finally { await CleanUpAsync(); }

            // Assert
            Assert.Null(skillBefore);
            Assert.NotNull(skillAfter);
            Assert.Equal(Guid.Empty, skillToPost.Id);
            Assert.NotEqual(Guid.Empty, skillAfter.Id);
            Assert.Equal(skillToPost.Name, skillAfter.Name);
            Assert.Equal(skillToPost.SkillGroup, skillAfter.SkillGroup);
        }

        [Fact]
        public async Task PutSkill_HappyPath()
        {
            // Arrange
            SkillSqlEntity skillBefore = null;
            SkillSqlEntity skillAfter = null;
            var skillId = Guid.NewGuid();
            var initialSkill = new SkillSqlEntity()
            {
                Id = skillId,
                Name = "testName1",
                SkillGroup = "testSkillGroup1"
            };
            var skillToPut = new SkillDto()
            {
                Id = skillId,
                Name = "testName2",
                SkillGroup = "testSkillGroup2"
            };

            // Act

            try
            {
                await InitializeWithEntityAsync(initialSkill);
                skillBefore = _sqlDbContext.Skills.AsNoTracking().Single();
                await _apiClient.SkillsPUTAsync(skillId.ToString(), skillToPut);
                skillAfter = _sqlDbContext.Skills.AsNoTracking().Single();
            }
            finally { await CleanUpAsync(); }

            // Assert
            Assert.NotNull(skillBefore);
            Assert.NotNull(skillAfter);
            Assert.Equal(skillBefore.Id, skillAfter.Id);
            Assert.NotEqual(skillBefore.Name, skillAfter.Name);
            Assert.NotEqual(skillBefore.SkillGroup, skillAfter.SkillGroup);

            Assert.Equal(skillToPut.Name, skillAfter.Name);
            Assert.Equal(skillToPut.SkillGroup, skillAfter.SkillGroup);
        }

        [Fact]
        public async Task DeleteSkill_HappyPath()
        {
            // Arrange
            var skillId = Guid.NewGuid();
            var skillToDelete = new SkillSqlEntity()
            {
                Id = skillId,
                Name = "testName",
                SkillGroup = "testSkillGroup"
            };

            // Act
            await InitializeWithEntityAsync(skillToDelete);
            var skillBefore = _sqlDbContext.Skills.AsNoTracking().Single();
            await _apiClient.SkillsDELETEAsync(skillId.ToString());
            var skillAfter = _sqlDbContext.Skills.AsNoTracking().SingleOrDefault();

            // Assert
            Assert.NotNull(skillBefore);
            Assert.Null(skillAfter);
        }
        #endregion HappyPath

        private async Task InitializeWithEntityAsync(SkillSqlEntity entity)
        {
            _sqlDbContext.Skills.Add(entity);
            await _sqlDbContext.SaveChangesAsync();
        }

        private async Task CleanUpAsync()
        {
            _sqlDbContext.Skills.RemoveRange(_sqlDbContext.Skills.ToList());
            await _sqlDbContext.SaveChangesAsync();
        }
    }
}