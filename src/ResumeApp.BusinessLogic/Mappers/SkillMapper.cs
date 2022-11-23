using ResumeApp.DataAccess.Abstractions.Entities;
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

		internal static TEntity ToSkillEntity<TEntity>(this Skill dto) where TEntity : class, ISkillEntity, new()
		{
			if (dto == null) return null!;

			return new TEntity
			{
				Id =dto.Id ,
				Name = dto.Name,
				AdditionalInfo = dto.AdditionalInfo,
				SkillGroup = dto.SkillGroup
			};
		}
	}
}
