using ResumeApp.DataAccess.Abstractions.Entities;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class ResumeMapper
	{
		internal static ShortResume ToShortResumeDto(this IResumeEntity entity)
		{
			if (entity == null) return null!;

			var yearsOfExperience = entity.Experience
				.Select(e => (e.IsCurrentCompany ? DateOnly.FromDateTime(DateTime.Now) : e.EndDate.Value).DayNumber - e.StartDate.DayNumber)
				.Aggregate((t1, t2) => t1 + t2) / 365.0;

			return new ShortResume
			{
				Id = entity.Id,
				FirstName = entity.FirstName,
				LastName = entity.LastName,
				Title = entity.Title,
				Contacts = entity.Contacts.ToDictionary(i => i.Key, i => i.Value),
				YearsOfExperience = Math.Round(yearsOfExperience, 0, MidpointRounding.AwayFromZero)
			};
		}

		internal static FullResume ToFullResumeDto(this IResumeEntity entity)
		{
			if (entity == null) return null!;

			return new FullResume
			{
				Id = entity.Id,
				FirstName = entity.FirstName,
				LastName = entity.LastName,
				Title = entity.Title,
				Contacts = entity.Contacts.ToDictionary(i => i.Key, i => i.Value),
				Summary = entity.Summary,
				Skills = entity.Skills.Select(g => g.ToSkillDto()).ToList(),
				Experience = entity.Experience.Select(e => e.ToExperienceDto()).ToList(),
				Certifications = entity.Certifications.Select(c => c.ToCertificationDto()).ToList(),
				Education = entity.Education.Select(e => e.ToEducationDto()).ToList()
			};
		}

		//internal static TEntity ToResumeEntity<TEntity>(this FullResume dto) where TEntity : class, IResumeEntity, new()
		//{
		//	if (dto == null) return null;

		//	return new TEntity
		//	{
		//		Id = dto.Id,
		//		FirstName = dto.FirstName,
		//		LastName = dto.LastName,
		//		Title = dto.Title,
		//		Contacts = dto.Contacts,
		//		Summary = dto.Summary,
		//		Skills = dto.Skills.Select(g => g.ToSkillEntity()),
		//		Experience = dto.Experience.Select(e => e.ToExperienceEntity()),
		//		Certifications = dto.Certifications.Select(c => c.ToCertificationEntity()),
		//		Education = dto.Education.Select(e => e.ToEducationEntity())
		//	};
		//}
	}
}
