using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ResumeApp.UnitTests")]
namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class ExperienceMapper
	{
		internal static Experience ToExperienceDto(this ExperienceSqlEntity entity)
		{
			if (entity == null) return null;
			return new Experience
			{
				Id = entity.Id,
				Title = entity.Title,
				Company = entity.Company,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				IsCurrentCompany = entity.IsCurrentCompany,
				Projects = entity.Projects.Select(e => e.ToProjectDto())
			};
		}

		internal static Experience ToExperienceDto(this ExperienceMongoEntity entity)
		{
			if (entity == null) return null;
			return new Experience
			{
				Id = entity.Id,
				Title = entity.Title,
				Company = entity.Company,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				IsCurrentCompany = entity.IsCurrentCompany,
				Projects = entity.Projects.Select(e => e.ToProjectDto())
			};
		}

		internal static ExperienceMongoEntity ToExperienceMongoEntity(this Experience dto)
		{
			if (dto == null) return null;
			return new ExperienceMongoEntity
			{
				Id = dto.Id,
				Title = dto.Title,
				Company = dto.Company,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				IsCurrentCompany = dto.IsCurrentCompany,
				Projects = dto.Projects?.Select(d => d.ToProjectMongoEntity())
			};
		}

		internal static ExperienceSqlEntity ToExperienceSqlEntity(this Experience dto)
		{
			if (dto == null) return null;
			return new ExperienceSqlEntity
			{
				Id = dto.Id,
				Title = dto.Title,
				Company = dto.Company,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				IsCurrentCompany = dto.IsCurrentCompany,
				Projects = dto.Projects.Select(d => d.ToProjectSqlEntity())
			};
		}
	}
}
