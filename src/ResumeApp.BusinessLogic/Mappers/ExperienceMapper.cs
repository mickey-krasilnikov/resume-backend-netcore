using ResumeApp.DataAccess.Abstractions.Entities;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class ExperienceMapper
	{
		internal static Experience ToExperienceDto(this IExperienceEntity entity)
		{
			if (entity == null) return null;
			return new Experience
			{
				Title = entity.Title,
				Company = entity.Company,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				//Projects = entity.Projects.Select(s => s.ToProjectDto())
			};
		}

		internal static TEntity ToExperienceEntity<TEntity>(this Experience dto) where TEntity : class, IExperienceEntity, new()
		{
			if (dto == null) return null;
			return new TEntity
			{
				Title = dto.Title,
				Company = dto.Company,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				//Projects = dto.Projects.Select(s => s.ToProjectEntity())
			};
		}
	}
}
