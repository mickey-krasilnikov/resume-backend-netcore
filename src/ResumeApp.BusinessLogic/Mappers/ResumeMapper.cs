using ResumeApp.DataAccess.Abstractions.Entities;
using ResumeApp.DataAccess.Abstractions.Enums;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
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

		internal static IResumeEntity ToResumeEntity(this FullResume dto, SupportedDbType dbType)
		{
			return dbType switch
			{
				SupportedDbType.Mongo => dto.ToResumeMongoEntity(dbType),
				SupportedDbType.MsSql => dto.ToResumeSqlEntity(dbType),
				_ => throw new NotSupportedException($"{dbType} DB type is not supported"),
			};
		}

		private static IResumeEntity ToResumeMongoEntity(this FullResume dto, SupportedDbType dbType)
		{
			return new ResumeMongoEntity
			{
				Id = dto.Id,
				FirstName = dto.FirstName,
				LastName = dto.LastName,
				Title = dto.Title,
				Summary = dto.Summary,
				Contacts = dto.Contacts.Select(i => new ContactMongoEntity { Key = i.Key, Value = i.Value }),
				Skills = dto.Skills.Select(g => g.ToSkillEntity(dbType)),
				Experience = dto.Experience.Select(e => e.ToExperienceEntity(dbType)),
				Certifications = dto.Certifications.Select(c => c.ToCertificationEntity(dbType)),
				Education = dto.Education.Select(e => e.ToEducationEntity(dbType))
			};
		}

		internal static IResumeEntity ToResumeSqlEntity(this FullResume dto, SupportedDbType dbType)
		{
			return new ResumeSqlEntity
			{
				Id = dto.Id,
				FirstName = dto.FirstName,
				LastName = dto.LastName,
				Title = dto.Title,
				Summary = dto.Summary,
				Contacts = dto.Contacts.Select(i => new ContactSqlEntity { Key = i.Key, Value = i.Value }),
				Skills = dto.Skills.Select(g => g.ToSkillEntity(dbType)),
				Experience = dto.Experience.Select(e => e.ToExperienceEntity(dbType)),
				Certifications = dto.Certifications.Select(c => c.ToCertificationEntity(dbType)),
				Education = dto.Education.Select(e => e.ToEducationEntity(dbType))
			};
		}
	}
}
