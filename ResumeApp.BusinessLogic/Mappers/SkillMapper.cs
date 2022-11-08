//using ResumeApp.DataAccess.Abstractions.Entities;
//using ResumeApp.Poco;

//namespace ResumeApp.BusinessLogic.Mappers
//{
//	internal static class SkillMapper
//	{
//		internal static Skill ToSkillDto(this ISkillEntity entity)
//		{
//			if (entity == null) return null!;

//			return new Skill
//			{
//				Name = entity.Name,
//				Children = entity.Children?.Select(g => g.ToSkillDto()).ToList(),
//				AdditionalInfo = entity.AdditionalInfo
//			};
//		}

//		internal static ISkillEntity ToSkillEntity(this Skill dto)
//		{
//			if (dto == null) return null!;

//			return new ISkillEntity
//			{
//				Name = dto.Name,
//				AdditionalInfo = dto.AdditionalInfo
//			};
//		}
//	}
//}
