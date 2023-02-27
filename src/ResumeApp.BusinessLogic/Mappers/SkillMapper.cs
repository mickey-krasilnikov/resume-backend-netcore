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
				SkillGroup = entity.SkillGroup,
				ExperienceIds = entity.ExperienceIds
			};
		}

		internal static SkillDto ToDto(this SkillSqlEntity entity)
		{
			if (entity == null) return null;

			return new SkillDto
			{
				Id = entity.Id,
				Name = entity.Name,
				SkillGroup = entity.SkillGroup,
				ExperienceIds = entity.SkillExperienceMapping?.Select(m => m.ExperienceId).ToList()
            };
		}

		internal static SkillMongoEntity ToMongoEntity(this SkillDto dto)
		{
			if (dto == null) return null;
			return new SkillMongoEntity
			{
				Id = dto.Id,
				Name = dto.Name,
				SkillGroup = dto.SkillGroup,
				ExperienceIds = dto.ExperienceIds?.ToArray()
			};
		}

		internal static SkillSqlEntity ToSqlEntity(this SkillDto dto)
		{
			if (dto == null) return null;
            var skillExperienceMappings = dto.ExperienceIds?.Select(i => new SkillExperienceMappingSqlEntity
            {
                SkillId = dto.Id,
                ExperienceId = i
            }).ToList();
            return new SkillSqlEntity
			{
				Id = dto.Id,
				Name = dto.Name,
				SkillGroup = dto.SkillGroup,
				SkillExperienceMapping = skillExperienceMappings
            };
		}
	}
}
