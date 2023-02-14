using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Models;

namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class GenericMapper
	{
		internal static TModel ToDto<TModel, TEntity>(this TEntity entity) where TModel : class
		{
			// certification
			if (typeof(TModel) == typeof(CertificationDto))
			{
				if (typeof(TEntity) == typeof(CertificationSqlEntity))
					return (entity as CertificationSqlEntity).ToDto() as TModel;
				else if (typeof(TEntity) == typeof(CertificationMongoEntity))
					return (entity as CertificationMongoEntity).ToDto() as TModel;
			}

			// education
			if (typeof(TModel) == typeof(EducationDto))
			{
				if (typeof(TEntity) == typeof(EducationSqlEntity))
					return (entity as EducationSqlEntity).ToDto() as TModel;
				else if (typeof(TEntity) == typeof(EducationMongoEntity))
					return (entity as EducationMongoEntity).ToDto() as TModel;
			}

			// experience
			if (typeof(TModel) == typeof(ExperienceDto))
			{
				if (typeof(TEntity) == typeof(ExperienceSqlEntity))
					return (entity as ExperienceSqlEntity).ToDto() as TModel;
				else if (typeof(TEntity) == typeof(ExperienceMongoEntity))
					return (entity as ExperienceMongoEntity).ToDto() as TModel;
			}

			// skill
			if (typeof(TModel) == typeof(SkillDto))
			{
				if (typeof(TEntity) == typeof(SkillSqlEntity))
					return (entity as SkillSqlEntity).ToDto() as TModel;
				else if (typeof(TEntity) == typeof(SkillMongoEntity))
					return (entity as SkillMongoEntity).ToDto() as TModel;
			}

			throw new NotSupportedException($"The entity type '{typeof(TEntity)}' can not be mapped to the DTO type '{typeof(TModel)}'");
		}

		internal static TEntity ToEntity<TModel, TEntity>(this TModel dto) where TEntity : class
		{
			// certification
			if (typeof(TModel) == typeof(CertificationDto))
			{
				if (typeof(TEntity) == typeof(CertificationSqlEntity))
					return (dto as CertificationDto).ToSqlEntity() as TEntity;
				else if (typeof(TEntity) == typeof(CertificationMongoEntity))
					return (dto as CertificationDto).ToMongoEntity() as TEntity;
			}

			// education
			if (typeof(TModel) == typeof(EducationDto))
			{
				if (typeof(TEntity) == typeof(EducationSqlEntity))
					return (dto as EducationDto).ToSqlEntity() as TEntity;
				else if (typeof(TEntity) == typeof(EducationMongoEntity))
					return (dto as EducationDto).ToMongoEntity() as TEntity;
			}

			// experience
			if (typeof(TModel) == typeof(ExperienceDto))
			{
				if (typeof(TEntity) == typeof(ExperienceSqlEntity))
					return (dto as ExperienceDto).ToSqlEntity() as TEntity;
				else if (typeof(TEntity) == typeof(ExperienceMongoEntity))
					return (dto as ExperienceDto).ToMongoEntity() as TEntity;
			}

			// skill
			if (typeof(TModel) == typeof(SkillDto))
			{
				if (typeof(TEntity) == typeof(SkillSqlEntity))
					return (dto as SkillDto).ToSqlEntity() as TEntity;
				else if (typeof(TEntity) == typeof(SkillMongoEntity))
					return (dto as SkillDto).ToMongoEntity() as TEntity;
			}

			throw new NotSupportedException($"The DTO type '{typeof(TModel)}' can not be mapped to the entity type '{typeof(TEntity)}'");
		}
	}
}
