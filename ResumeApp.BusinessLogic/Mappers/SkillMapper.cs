using ResumeApp.DataAccess.MongoDb.Entities;
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
				Name = entity.Name,
				Children = entity.Children?.ConvertAll(g => g.ToSkillDto()),
				AdditionalInfo = entity.AdditionalInfo
			};
		}

		internal static SkillMongoEntity ToSkillEntity(this Skill dto)
		{
			if (dto == null) return null!;

			return new SkillMongoEntity
			{
				Name = dto.Name,
				AdditionalInfo = dto.AdditionalInfo
			};
		}
	}
}
