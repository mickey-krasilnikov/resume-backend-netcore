using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;

namespace ResumeApp.UnitTests.Mappers
{
	public class ProjectMapperTests
	{
		public static IEnumerable<object[]> TestData => new List<object[]>
		{
			new object[] { Guid.Empty, null, null, null, null, new DateOnly(), null },
			new object[] { Guid.Empty, string.Empty, string.Empty, string.Empty, string.Empty, new DateOnly(), new DateOnly() },
			new object[] { Guid.NewGuid(), "TestClient", "TestProjectRoles", "TestEnvironment", "TestTaskPerformed", DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-6)), DateOnly.FromDateTime(DateTime.UtcNow) }
		};

		[Theory]
		[MemberData(nameof(TestData))]
		public void MongoEntityToProjectDto(Guid id, string client, string projectRoles, string environment, string taskPerformed, DateOnly startDate, DateOnly? endDate)
		{
			//Arrange
			var entity = new ProjectMongoEntity
			{
				Id = id,
				Client = client,
				StartDate = startDate,
				EndDate = endDate,
				ProjectRoles = projectRoles,
				Environment = environment,
				TaskPerformed = taskPerformed
			};

			//Act
			var result = entity.ToProjectDto();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(client, result.Client);
			Assert.Equal(startDate, result.StartDate);
			Assert.Equal(endDate, result.EndDate);
			Assert.Equal(projectRoles, result.ProjectRoles);
			Assert.Equal(environment, result.Environment);
			Assert.Equal(taskPerformed, result.TaskPerformed);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void SqlEntityToProjectDto(Guid id, string client, string projectRoles, string environment, string taskPerformed, DateOnly startDate, DateOnly? endDate)
		{
			//Arrange
			var entity = new ProjectSqlEntity
			{
				Id = id,
				Client = client,
				StartDate = startDate,
				EndDate = endDate,
				ProjectRoles = projectRoles,
				Environment = environment,
				TaskPerformed = taskPerformed
			};

			//Act
			var result = entity.ToProjectDto();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(client, result.Client);
			Assert.Equal(startDate, result.StartDate);
			Assert.Equal(endDate, result.EndDate);
			Assert.Equal(projectRoles, result.ProjectRoles);
			Assert.Equal(environment, result.Environment);
			Assert.Equal(taskPerformed, result.TaskPerformed);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void ProjectDtoToMongoEntity(Guid id, string client, string projectRoles, string environment, string taskPerformed, DateOnly startDate, DateOnly? endDate)
		{
			//Arrange
			var dto = new Project
			{
				Id = id,
				Client = client,
				StartDate = startDate,
				EndDate = endDate,
				ProjectRoles = projectRoles,
				Environment = environment,
				TaskPerformed = taskPerformed
			};

			//Act
			var result = dto.ToProjectMongoEntity();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(client, result.Client);
			Assert.Equal(startDate, result.StartDate);
			Assert.Equal(endDate, result.EndDate);
			Assert.Equal(projectRoles, result.ProjectRoles);
			Assert.Equal(environment, result.Environment);
			Assert.Equal(taskPerformed, result.TaskPerformed);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void ProjectDtoToSqlEntity(Guid id, string client, string projectRoles, string environment, string taskPerformed, DateOnly startDate, DateOnly? endDate)
		{
			//Arrange
			var dto = new Project
			{
				Id = id,
				Client = client,
				StartDate = startDate,
				EndDate = endDate,
				ProjectRoles = projectRoles,
				Environment = environment,
				TaskPerformed = taskPerformed
			};

			//Act
			var result = dto.ToProjectSqlEntity();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(client, result.Client);
			Assert.Equal(startDate, result.StartDate);
			Assert.Equal(endDate, result.EndDate);
			Assert.Equal(projectRoles, result.ProjectRoles);
			Assert.Equal(environment, result.Environment);
			Assert.Equal(taskPerformed, result.TaskPerformed);
		}
	}
}
