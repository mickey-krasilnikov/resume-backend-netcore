using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ResumeApp.UnitTests")]
namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class ExperienceMapper
	{
        internal static Experience ToDto<TExperienceEntity>(this TExperienceEntity entity)
        {
            if (typeof(TExperienceEntity) == typeof(ExperienceMongoEntity)) return (entity as ExperienceMongoEntity).ToExperienceDto();
            else if (typeof(TExperienceEntity) == typeof(ExperienceSqlEntity)) return (entity as ExperienceSqlEntity).ToExperienceDto();
            else throw new NotSupportedException($"Type '{typeof(TExperienceEntity)}' is not supported by Experience mapper");
        }

        internal static TExperienceEntity ToEntity<TExperienceEntity>(this Experience dto)
        {
            if (typeof(TExperienceEntity) == typeof(ExperienceMongoEntity)) return (TExperienceEntity)Convert.ChangeType(dto.ToExperienceMongoEntity(), typeof(TExperienceEntity));
            else if (typeof(TExperienceEntity) == typeof(ExperienceSqlEntity)) return (TExperienceEntity)Convert.ChangeType(dto.ToExperienceSqlEntity(), typeof(TExperienceEntity));
            else throw new NotSupportedException($"Type '{typeof(TExperienceEntity)}' is not supported by Experience mapper");
        }


        internal static Experience ToDto(this ExperienceSqlEntity entity)
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
				Projects = entity.Projects?.Select(e => e.ToProjectDto())
			};
		}

		internal static Experience ToDto(this ExperienceMongoEntity entity)
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
				Projects = entity.Projects?.Select(e => e.ToProjectDto())
			};
		}


		internal static ExperienceMongoEntity ToMongoEntity(this Experience dto)
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

		internal static ExperienceSqlEntity ToSqlEntity(this Experience dto)
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
				Projects = dto.Projects?.Select(d => d.ToProjectSqlEntity())
			};
		}
	}
}
