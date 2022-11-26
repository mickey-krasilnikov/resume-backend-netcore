using ResumeApp.DataAccess.Abstractions.Entities;
using ResumeApp.DataAccess.Abstractions.Enums;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class EducationMapper
	{
		internal static Education ToEducationDto(this IEducationEntity entity)
		{
			if (entity == null) return null;

			return new Education
			{
				Name = entity.Name,
				Degree = entity.Degree,
				FieldOfStudy = entity.FieldOfStudy,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				Url = entity.Url
			};
		}

		internal static IEducationEntity ToEducationEntity(this Education dto, SupportedDbType dbType)
		{
			return dbType switch
			{
				SupportedDbType.Mongo => dto.ToEducationMongoEntity(),
				SupportedDbType.MsSql => dto.ToEducationSqlEntity(),
				_ => throw new NotSupportedException($"{dbType} DB type is not supported"),
			};
		}

		private static IEducationEntity ToEducationMongoEntity(this Education dto)
		{
			if (dto == null) return null;
			return new EducationMongoEntity
			{
				Name = dto.Name,
				Degree = dto.Degree,
				FieldOfStudy = dto.FieldOfStudy,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				Url = dto.Url
			};
		}

		private static IEducationEntity ToEducationSqlEntity(this Education dto)
		{
			if (dto == null) return null;
			return new EducationSqlEntity
			{
				Name = dto.Name,
				Degree = dto.Degree,
				FieldOfStudy = dto.FieldOfStudy,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				Url = dto.Url
			};
		}
	}
}
