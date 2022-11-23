using ResumeApp.DataAccess.Abstractions.Entities;
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

		internal static TEntity ToProjectEntity<TEntity>(this Project dto) where TEntity : class, IProjectEntity, new()
		{
			if (dto == null) return null;

			return new TEntity
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
