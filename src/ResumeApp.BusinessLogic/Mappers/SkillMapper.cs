using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ResumeApp.UnitTests")]
namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class SkillMapper
	{
        internal static Skill ToDto<TSkillEntity>(this TSkillEntity entity)
        {
            if (typeof(TSkillEntity) == typeof(SkillMongoEntity)) return (entity as SkillMongoEntity).ToSkillDto();
            else if (typeof(TSkillEntity) == typeof(SkillSqlEntity)) return (entity as SkillSqlEntity).ToSkillDto();
            else throw new NotSupportedException($"Type '{typeof(TSkillEntity)}' is not supported by Skill mapper");
        }

        internal static TSkillEntity ToEntity<TSkillEntity>(this Skill dto)
        {
            if (typeof(TSkillEntity) == typeof(SkillMongoEntity)) return (TSkillEntity)Convert.ChangeType(dto.ToSkillMongoEntity(), typeof(TSkillEntity));
            else if (typeof(TSkillEntity) == typeof(SkillSqlEntity)) return (TSkillEntity)Convert.ChangeType(dto.ToSkillSqlEntity(), typeof(TSkillEntity));
            else throw new NotSupportedException($"Type '{typeof(TSkillEntity)}' is not supported by Skill mapper");
        }


        internal static Skill ToDto(this SkillMongoEntity entity)
		{
			if (entity == null) return null;

			return new Skill
			{
				Id = entity.Id,
				Name = entity.Name,
				AdditionalInfo = entity.AdditionalInfo,
				SkillGroup = entity.SkillGroup,
			};
		}

		internal static Skill ToDto(this SkillSqlEntity entity)
		{
			if (entity == null) return null;

			return new Skill
			{
				Id = entity.Id,
				Name = entity.Name,
				AdditionalInfo = entity.AdditionalInfo,
				SkillGroup = entity.SkillGroup,
			};
		}


		internal static SkillMongoEntity ToMongoEntity(this Skill dto)
		{
			if (dto == null) return null;
			return new SkillMongoEntity
			{
				Id = dto.Id,
				Name = dto.Name,
				AdditionalInfo = dto.AdditionalInfo,
				SkillGroup = dto.SkillGroup
			};
		}

		internal static SkillSqlEntity ToSqlEntity(this Skill dto)
		{
			if (dto == null) return null;
			return new SkillSqlEntity
			{
				Id = dto.Id,
				Name = dto.Name,
				AdditionalInfo = dto.AdditionalInfo,
				SkillGroup = dto.SkillGroup
			};
		}
	}
}
