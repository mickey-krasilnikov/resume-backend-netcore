using ResumeApp.DataAccess.Abstractions.Entities;
using ResumeApp.DataAccess.Abstractions.Enums;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
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
				EndDate = entity.EndDate
			};
		}

		internal static IExperienceEntity ToExperienceEntity(this Experience dto, SupportedDbType dbType)
		{
			return dbType switch
			{
				SupportedDbType.Mongo => dto.ToExperienceMongoEntity(dbType),
				SupportedDbType.MsSql => dto.ToExperienceSqlEntity(dbType),
				_ => throw new NotSupportedException($"{dbType} DB type is not supported"),
			};
		}

		private static IExperienceEntity ToExperienceMongoEntity(this Experience dto, SupportedDbType dbType)
		{
			if (dto == null) return null;
			return new ExperienceMongoEntity
			{
				Title = dto.Title,
				Company = dto.Company,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				Projects = dto.Projects.Select(d => d.ToProjectEntity(dbType))
			};
		}

		private static IExperienceEntity ToExperienceSqlEntity(this Experience dto, SupportedDbType dbType)
		{
			if (dto == null) return null;
			return new ExperienceSqlEntity
			{
				Title = dto.Title,
				Company = dto.Company,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				Projects = dto.Projects.Select(d => d.ToProjectEntity(dbType))
			};
		}
	}
}
