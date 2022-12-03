using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class SkillMapper
	{
		internal static Skill ToSkillDto(this SkillMongoEntity entity)
		{
			if (entity == null) return null!;

			return new Skill
			{
				Id = entity.Id,
				Name = entity.Name,
				AdditionalInfo = entity.AdditionalInfo,
				SkillGroup = entity.SkillGroup,
			};
		}

		internal static Skill ToSkillDto(this SkillSqlEntity entity)
		{
			if (entity == null) return null!;

			return new Skill
			{
				Id = entity.Id,
				Name = entity.Name,
				AdditionalInfo = entity.AdditionalInfo,
				SkillGroup = entity.SkillGroup,
			};
		}

		internal static SkillMongoEntity ToSkillMongoEntity(this Skill dto)
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

		internal static SkillSqlEntity ToSkillSqlEntity(this Skill dto)
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
