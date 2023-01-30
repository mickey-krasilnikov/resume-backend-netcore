using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("EducationApp.UnitTests")]
namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class EducationMapper
	{
        internal static Education ToDto<TEducationEntity>(this TEducationEntity entity)
        {
            if (typeof(TEducationEntity) == typeof(EducationMongoEntity)) return (entity as EducationMongoEntity).ToEducationDto();
            else if (typeof(TEducationEntity) == typeof(EducationSqlEntity)) return (entity as EducationSqlEntity).ToEducationDto();
            else throw new NotSupportedException($"Type '{typeof(TEducationEntity)}' is not supported by Education mapper");
        }

        internal static TEducationEntity ToEntity<TEducationEntity>(this Education dto)
        {
            if (typeof(TEducationEntity) == typeof(EducationMongoEntity)) return (TEducationEntity)Convert.ChangeType(dto.ToEducationMongoEntity(), typeof(TEducationEntity));
            else if (typeof(TEducationEntity) == typeof(EducationSqlEntity)) return (TEducationEntity)Convert.ChangeType(dto.ToEducationSqlEntity(), typeof(TEducationEntity));
            else throw new NotSupportedException($"Type '{typeof(TEducationEntity)}' is not supported by Education mapper");
        }


        internal static Education ToDto(this EducationSqlEntity entity)
		{
			if (entity == null) return null;

			return new Education
			{
				Id = entity.Id,
				Name = entity.Name,
				Degree = entity.Degree,
				FieldOfStudy = entity.FieldOfStudy,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				Url = entity.Url
			};
		}

		internal static Education ToDto(this EducationMongoEntity entity)
		{
			if (entity == null) return null;

			return new Education
            {
                Id = entity.Id,
                Name = entity.Name,
				Degree = entity.Degree,
				FieldOfStudy = entity.FieldOfStudy,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				Url = entity.Url
			};
		}


		internal static EducationMongoEntity ToMongoEntity(this Education dto)
		{
			if (dto == null) return null;
			return new EducationMongoEntity
			{
				Id = dto.Id,
				Name = dto.Name,
				Degree = dto.Degree,
				FieldOfStudy = dto.FieldOfStudy,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				Url = dto.Url
			};
		}

		internal static EducationSqlEntity ToSqlEntity(this Education dto)
		{
			if (dto == null) return null;
			return new EducationSqlEntity
            {
                Id = dto.Id,
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
