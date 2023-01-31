using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Models;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ResumeApp.UnitTests")]
namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class SkillMapper
	{
        internal static SkillDto ToDto(this SkillMongoEntity entity)
		{
			if (entity == null) return null;

			return new SkillDto
			{
				Id = entity.Id,
				Name = entity.Name,
				AdditionalInfo = entity.AdditionalInfo,
				SkillGroup = entity.SkillGroup,
			};
		}

		internal static SkillDto ToDto(this SkillSqlEntity entity)
		{
			if (entity == null) return null;

			return new SkillDto
			{
				Id = entity.Id,
				Name = entity.Name,
				AdditionalInfo = entity.AdditionalInfo,
				SkillGroup = entity.SkillGroup,
			};
		}

		internal static SkillMongoEntity ToMongoEntity(this SkillDto dto)
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

		internal static SkillSqlEntity ToSqlEntity(this SkillDto dto)
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
