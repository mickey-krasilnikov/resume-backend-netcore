using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Models;

namespace ResumeApp.UnitTests.Mappers
{
	public class SkillMapperTests
	{
		public static IEnumerable<object[]> TestData => new List<object[]>
		{
			new object[] { Guid.Empty, null, null, true, 1 },
			new object[] { Guid.Empty, string.Empty, string.Empty, true, 2 },
			new object[] { Guid.NewGuid(), "TestSkill", "TestSkillGroup", true, 3 }
		};

		[Theory]
		[MemberData(nameof(TestData))]
		public void MongoEntityToSkillDto(Guid id, string name, string skillGroup, bool isHighlighted, int priority)
		{
			//Arrange
			var entity = new SkillMongoEntity
			{
				Id = id,
				Name = name,
				SkillGroup = skillGroup,
				IsHighlighted = isHighlighted,
				Priority = priority,
				ExperienceIds = new[] { Guid.NewGuid() }

			};

			//Act
			var result = entity.ToDto();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(name, result.Name);
			Assert.Equal(skillGroup, result.SkillGroup);
            Assert.Equal(isHighlighted, result.IsHighlighted);
            Assert.Equal(priority, result.Priority);
            Assert.NotEmpty(result.ExperienceIds);
        }

		[Theory]
		[MemberData(nameof(TestData))]
		public void SqlEntityToSkillDto(Guid id, string name, string skillGroup, bool isHighlighted, int priority)
		{
			//Arrange
			var entity = new SkillSqlEntity
			{
				Id = id,
				Name = name,
				SkillGroup = skillGroup,
                IsHighlighted = isHighlighted,
                Priority = priority,
                SkillExperienceMapping = new[] { new SkillExperienceMappingSqlEntity { SkillId = id, ExperienceId = Guid.NewGuid() } }
            };

			//Act
			var result = entity.ToDto();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(name, result.Name);
			Assert.Equal(skillGroup, result.SkillGroup);
            Assert.Equal(isHighlighted, result.IsHighlighted);
            Assert.Equal(priority, result.Priority);
            Assert.NotEmpty(result.ExperienceIds);
        }

		[Theory]
		[MemberData(nameof(TestData))]
		public void SkillDtoToMongoEntity(Guid id, string name, string skillGroup, bool isHighlighted, int priority)
		{
			//Arrange
			var dto = new SkillDto
			{
				Id = id,
				Name = name,
				SkillGroup = skillGroup,
                IsHighlighted = isHighlighted,
                Priority = priority,
                ExperienceIds = new[] { Guid.NewGuid() }
            };

			//Act
			var result = dto.ToMongoEntity();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(name, result.Name);
			Assert.Equal(skillGroup, result.SkillGroup);
            Assert.Equal(isHighlighted, result.IsHighlighted);
            Assert.Equal(priority, result.Priority);
            Assert.NotEmpty(result.ExperienceIds);
        }

		[Theory]
		[MemberData(nameof(TestData))]
		public void SkillDtoToSqlEntity(Guid id, string name, string skillGroup, bool isHighlighted, int priority)
		{
			//Arrange
			var dto = new SkillDto
			{
				Id = id,
				Name = name,
				SkillGroup = skillGroup,
                IsHighlighted = isHighlighted,
                Priority = priority,
                ExperienceIds = new[] { Guid.NewGuid() }
            };

			//Act
			var result = dto.ToSqlEntity();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(name, result.Name);
			Assert.Equal(skillGroup, result.SkillGroup);
            Assert.Equal(isHighlighted, result.IsHighlighted);
            Assert.Equal(priority, result.Priority);
            Assert.NotEmpty(result.SkillExperienceMapping);
        }
	}
}
