using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;
using SharpCompress.Common;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ResumeApp.UnitTests")]
namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class ProjectMapper
	{
		internal static Project ToProjectDto(this ProjectMongoEntity entity)
		{
			if (entity == null) return null;

			return new Project
			{
				Id = entity.Id,
				Client = entity.Client,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				Environment = entity.Environment,
				ProjectRoles = entity.ProjectRoles,
				TaskPerformed = entity.TaskPerformed
			};
		}

		internal static Project ToProjectDto(this ProjectSqlEntity entity)
		{
			if (entity == null) return null;

			return new Project
			{
				Id = entity.Id,
				Client = entity.Client,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				Environment = entity.Environment,
				ProjectRoles = entity.ProjectRoles,
				TaskPerformed = entity.TaskPerformed
			};
		}

		internal static ProjectMongoEntity ToProjectMongoEntity(this Project dto)
		{
			if (dto == null) return null;
			return new ProjectMongoEntity
			{
				Id = dto.Id,
				Client = dto.Client,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				Environment = dto.Environment,
				ProjectRoles = dto.ProjectRoles,
				TaskPerformed = dto.TaskPerformed
			};
		}

		internal static ProjectSqlEntity ToProjectSqlEntity(this Project dto)
		{
			if (dto == null) return null;
			return new ProjectSqlEntity
			{
				Id = dto.Id,
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
