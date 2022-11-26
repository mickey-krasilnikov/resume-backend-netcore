using ResumeApp.DataAccess.Abstractions.Entities;
using ResumeApp.DataAccess.Abstractions.Enums;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class ProjectMapper
	{
		internal static Project ToProjectDto(this IProjectEntity entity)
		{
			if (entity == null) return null;

			return new Project
			{
				Client = entity.Client,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				Environment = entity.Environment,
				ProjectRoles = entity.ProjectRoles,
				TaskPerformed = entity.TaskPerformed
			};
		}

		internal static IProjectEntity ToProjectEntity(this Project dto, SupportedDbType dbType)
		{
			return dbType switch
			{
				SupportedDbType.Mongo => dto.ToProjectMongoEntity(),
				SupportedDbType.MsSql => dto.ToProjectSqlEntity(),
				_ => throw new NotSupportedException($"{dbType} DB type is not supported"),
			};
		}

		private static IProjectEntity ToProjectMongoEntity(this Project dto)
		{
			if (dto == null) return null;
			return new ProjectMongoEntity
			{
				Client = dto.Client,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				Environment = dto.Environment,
				ProjectRoles = dto.ProjectRoles,
				TaskPerformed = dto.TaskPerformed
			};
		}

		private static IProjectEntity ToProjectSqlEntity(this Project dto)
		{
			if (dto == null) return null;
			return new ProjectSqlEntity
			{
				Client = dto.Client,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				Environment = dto.Environment,
				ProjectRoles = dto.ProjectRoles,
				TaskPerformed = dto.TaskPerformed
			};
		}
	}
}
