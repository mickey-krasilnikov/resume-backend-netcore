using MongoDB.Bson;
using ResumeApp.DataAccess.MongoDb.Entities;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class ResumeMapper
	{
		internal static ConciseResume ToConsiseResumeDto(this ResumeMongoEntity entity)
		{
			if (entity == null) return null!;

			var langSkillGroups = entity.Skills.Find(s => s.Name == "Programming Languages");
			var langSkills = langSkillGroups == null
				? new List<string>()
				: langSkillGroups.Children.SelectMany(g => g.Children.Select(s => s.Name));

			var yearsOfExperience = entity.Experience
				.Select(e => (e.EndDate == default ? DateTime.Now : e.EndDate) - e.StartDate)
				.Aggregate((t1, t2) => t1 + t2)
				.TotalDays / 365;

			return new ConciseResume
			{
				ID = entity.Id.ToString(),
				FirstName = entity.FirstName,
				LastName = entity.LastName,
				Title = entity.Title,
				Contacts = entity.Contacts,
				MainSkills = langSkills.ToList(),
				YearsOfExperience = Math.Round(yearsOfExperience, 0, MidpointRounding.AwayFromZero)
			};
		}

		internal static FullResume ToFullResumeDto(this ResumeMongoEntity entity)
		{
			if (entity == null) return null!;

			return new FullResume
			{
				ID = entity.Id.ToString(),
				FirstName = entity.FirstName,
				LastName = entity.LastName,
				Title = entity.Title,
				Contacts = entity.Contacts,
				Summary = entity.Summary,
				Skills = entity.Skills.ConvertAll(g => g.ToSkillDto()),
				Experience = entity.Experience.ConvertAll(e => e.ToExperienceDto()),
				Certifications = entity.Certifications.ConvertAll(c => c.ToCertificationDto()),
				Education = entity.Education.ConvertAll(e => e.ToEducationDto())
			};
		}

		internal static ResumeMongoEntity ToResumeEntity(this FullResume dto)
		{
			if (dto == null) return null!;
			var isParsed = ObjectId.TryParse(dto.ID, out var objectId);
			if (!isParsed) return null!;

			return new ResumeMongoEntity
			{
				Id = objectId,
				FirstName = dto.FirstName,
				LastName = dto.LastName,
				Title = dto.Title,
				Contacts = dto.Contacts,
				Summary = dto.Summary,
				Skills = dto.Skills.ConvertAll(g => g.ToSkillEntity()),
				Experience = dto.Experience.ConvertAll(e => e.ToExperienceEntity()),
				Certifications = dto.Certifications.ConvertAll(c => c.ToCertificationEntity()),
				Education = dto.Education.ConvertAll(e => e.ToEducationEntity())
			};
		}
	}
}
