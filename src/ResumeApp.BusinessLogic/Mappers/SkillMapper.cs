using ResumeApp.DataAccess.Abstractions.Entities;
using ResumeApp.DataAccess.Abstractions.Enums;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class SkillMapper
	{
		internal static Skill ToSkillDto(this ISkillEntity entity)
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

		internal static ISkillEntity ToSkillEntity(this Skill dto, SupportedDbType dbType)
		{
			return dbType switch
			{
				SupportedDbType.Mongo => dto.ToSkillMongoEntity(),
				SupportedDbType.MsSql => dto.ToSkillSqlEntity(),
				_ => throw new NotSupportedException($"{dbType} DB type is not supported"),
			};
		}

		private static ISkillEntity ToSkillMongoEntity(this Skill dto)
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

		private static ISkillEntity ToSkillSqlEntity(this Skill dto)
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
