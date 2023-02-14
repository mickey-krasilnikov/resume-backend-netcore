using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Models;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ResumeApp.UnitTests")]
namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class ExperienceMapper
	{
        internal static ExperienceDto ToDto(this ExperienceSqlEntity entity)
		{
			if (entity == null) return null;
			return new ExperienceDto
			{
				Id = entity.Id,
				Title = entity.Title,
				Company = entity.Company,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate
			};
		}

		internal static ExperienceDto ToDto(this ExperienceMongoEntity entity)
		{
			if (entity == null) return null;
			return new ExperienceDto
			{
				Id = entity.Id,
				Title = entity.Title,
				Company = entity.Company,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate
			};
		}

		internal static ExperienceMongoEntity ToMongoEntity(this ExperienceDto dto)
		{
			if (dto == null) return null;
			return new ExperienceMongoEntity
			{
				Id = dto.Id,
				Title = dto.Title,
				Company = dto.Company,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate
			};
		}

		internal static ExperienceSqlEntity ToSqlEntity(this ExperienceDto dto)
		{
			if (dto == null) return null;
			return new ExperienceSqlEntity
			{
				Id = dto.Id,
				Title = dto.Title,
				Company = dto.Company,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate
			};
		}
	}
}
