using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class ExperienceMapper
	{
		internal static Experience ToExperienceDto(this ExperienceSqlEntity entity)
		{
			if (entity == null) return null;
			return new Experience
			{
				Title = entity.Title,
				Company = entity.Company,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate
			};
		}

		internal static Experience ToExperienceDto(this ExperienceMongoEntity entity)
		{
			if (entity == null) return null;
			return new Experience
			{
				Title = entity.Title,
				Company = entity.Company,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate
			};
		}

		internal static ExperienceMongoEntity ToExperienceMongoEntity(this Experience dto)
		{
			if (dto == null) return null;
			return new ExperienceMongoEntity
			{
				Title = dto.Title,
				Company = dto.Company,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				Projects = dto.Projects.Select(d => d.ToProjectMongoEntity())
			};
		}

		internal static ExperienceSqlEntity ToExperienceSqlEntity(this Experience dto)
		{
			if (dto == null) return null;
			return new ExperienceSqlEntity
			{
				Title = dto.Title,
				Company = dto.Company,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				Projects = dto.Projects.Select(d => d.ToProjectSqlEntity())
			};
		}
	}
}
