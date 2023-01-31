using Moq;
using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Models;

namespace ResumeApp.UnitTests.Mappers
{
	public class ExperienceMapperTests
	{
		public static IEnumerable<object[]> TestData => new List<object[]>
		{
			new object[] { Guid.Empty, null, null, new DateOnly(), null, false },
			new object[] { Guid.Empty, string.Empty, string.Empty, new DateOnly(), new DateOnly(), false },
			new object[] { Guid.NewGuid(), "TestTitle", "TestCompany", DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-2)), DateOnly.FromDateTime(DateTime.UtcNow), false }
		};

		[Theory]
		[MemberData(nameof(TestData))]
		public void MongoEntityToExperienceDto(Guid id, string title, string company, DateOnly startDate, DateOnly? endDate, bool isCurrentCompany)
		{
			//Arrange
			var projectsMock = new Mock<ProjectMongoEntity>();
			var entity = new ExperienceMongoEntity
			{
				Id = id,
				Title = title,
				Company = company,
				StartDate = startDate,
				EndDate = endDate,
				IsCurrentCompany = isCurrentCompany,
				Projects = new List<ProjectMongoEntity> { projectsMock.Object }
			};

			//Act
			var result = entity.ToDto();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(title, result.Title);
			Assert.Equal(company, result.Company);
			Assert.Equal(startDate, result.StartDate);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void SqlEntityToExperienceDto(Guid id, string title, string company, DateOnly startDate, DateOnly? endDate, bool isCurrentCompany)
		{
			//Arrange
			var entity = new ExperienceSqlEntity
			{
				Id = id,
				Title = title,
				Company = company,
				StartDate = startDate,
				EndDate = endDate
			};

			//Act
			var result = entity.ToDto();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(title, result.Title);
			Assert.Equal(company, result.Company);
			Assert.Equal(startDate, result.StartDate);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void ExperienceDtoToMongoEntity(Guid id, string title, string company, DateOnly startDate, DateOnly? endDate, bool isCurrentCompany)
		{
			//Arrange
			var dto = new ExperienceDto
			{
				Id = id,
				Title = title,
				Company = company,
				StartDate = startDate,
				EndDate = endDate,
			};

			//Act
			var result = dto.ToMongoEntity();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(title, result.Title);
			Assert.Equal(company, result.Company);
			Assert.Equal(startDate, result.StartDate);
			Assert.Equal(isCurrentCompany, result.IsCurrentCompany);
			Assert.Single(result.Projects);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void ExperienceDtoToSqlEntity(Guid id, string title, string company, DateOnly startDate, DateOnly? endDate, bool isCurrentCompany)
		{
			//Arrange
			var dto = new ExperienceDto
			{
				Id = id,
				Title = title,
				Company = company,
				StartDate = startDate,
				EndDate = endDate,
			};

			//Act
			var result = dto.ToSqlEntity();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(title, result.Title);
			Assert.Equal(company, result.Company);
			Assert.Equal(startDate, result.StartDate);
		}
	}
}
