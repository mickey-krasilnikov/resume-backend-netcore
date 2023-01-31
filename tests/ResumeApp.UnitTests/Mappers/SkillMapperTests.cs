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
			new object[] { Guid.Empty, null, null, null },
			new object[] { Guid.Empty, string.Empty, string.Empty, string.Empty },
			new object[] { Guid.NewGuid(), "TestSkill", "TestInfo", "TestSkillGroup" }
		};

		[Theory]
		[MemberData(nameof(TestData))]
		public void MongoEntityToSkillDto(Guid id, string name, string additionalInfo, string skillGroup)
		{
			//Arrange
			var entity = new SkillMongoEntity
			{
				Id = id,
				Name = name,
				AdditionalInfo = additionalInfo,
				SkillGroup = skillGroup
			};

			//Act
			var result = entity.ToDto();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(name, result.Name);
			Assert.Equal(additionalInfo, result.AdditionalInfo);
			Assert.Equal(skillGroup, result.SkillGroup);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void SqlEntityToSkillDto(Guid id, string name, string additionalInfo, string skillGroup)
		{
			//Arrange
			var entity = new SkillSqlEntity
			{
				Id = id,
				Name = name,
				AdditionalInfo = additionalInfo,
				SkillGroup = skillGroup
			};

			//Act
			var result = entity.ToDto();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(name, result.Name);
			Assert.Equal(additionalInfo, result.AdditionalInfo);
			Assert.Equal(skillGroup, result.SkillGroup);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void SkillDtoToMongoEntity(Guid id, string name, string additionalInfo, string skillGroup)
		{
			//Arrange
			var dto = new SkillDto
			{
				Id = id,
				Name = name,
				AdditionalInfo = additionalInfo,
				SkillGroup = skillGroup
			};

			//Act
			var result = dto.ToMongoEntity();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(name, result.Name);
			Assert.Equal(additionalInfo, result.AdditionalInfo);
			Assert.Equal(skillGroup, result.SkillGroup);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void SkillDtoToSqlEntity(Guid id, string name, string additionalInfo, string skillGroup)
		{
			//Arrange
			var dto = new SkillDto
			{
				Id = id,
				Name = name,
				AdditionalInfo = additionalInfo,
				SkillGroup = skillGroup
			};

			//Act
			var result = dto.ToSqlEntity();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(name, result.Name);
			Assert.Equal(additionalInfo, result.AdditionalInfo);
			Assert.Equal(skillGroup, result.SkillGroup);
		}
	}
}
