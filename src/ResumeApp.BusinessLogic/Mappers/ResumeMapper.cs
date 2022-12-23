using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ResumeApp.UnitTests")]
namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class ResumeMapper
	{
		internal static ShortResume ToShortResumeDto<TResumeEntity>(this TResumeEntity entity)
		{
			if (typeof(TResumeEntity) == typeof(ResumeMongoEntity)) return (entity as ResumeMongoEntity).ToShortResumeDto();
			else if (typeof(TResumeEntity) == typeof(ResumeSqlEntity)) return (entity as ResumeSqlEntity).ToShortResumeDto();
			else throw new NotSupportedException($"Type '{typeof(TResumeEntity)}' is not supported by resume mapper");
		}

		internal static ShortResume ToShortResumeDto(this ResumeMongoEntity entity)
		{
			if (entity == null) return null;

			var yearsOfExperience = entity.Experience
				.Select(e => (e.IsCurrentCompany && e.EndDate.HasValue 
					? DateOnly.FromDateTime(DateTime.Now) 
					: e.EndDate.Value).DayNumber - e.StartDate.DayNumber)
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

		internal static ShortResume ToShortResumeDto(this ResumeSqlEntity entity)
		{
			if (entity == null) return null;

			var yearsOfExperience = entity.Experience.Any()
				? entity.Experience
					.Select(e => (e.IsCurrentCompany && e.EndDate.HasValue 
						? DateOnly.FromDateTime(DateTime.Now) 
						: e.EndDate.Value).DayNumber - e.StartDate.DayNumber)
					.Aggregate((t1, t2) => t1 + t2) / 365.0
				: 0;

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

		internal static FullResume ToFullResumeDto<TResumeEntity>(this TResumeEntity entity)
		{
			if (typeof(TResumeEntity) == typeof(ResumeMongoEntity)) return (entity as ResumeMongoEntity).ToFullResumeDto();
			else if (typeof(TResumeEntity) == typeof(ResumeSqlEntity)) return (entity as ResumeSqlEntity).ToFullResumeDto();
			else throw new NotSupportedException($"Type '{typeof(TResumeEntity)}' is not supported by resume mapper");
		}

		internal static FullResume ToFullResumeDto(this ResumeMongoEntity entity)
		{
			if (entity == null) return null;

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

		internal static FullResume ToFullResumeDto(this ResumeSqlEntity entity)
		{
			if (entity == null) return null;

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

		internal static TResumeEntity ToResumeEntity<TResumeEntity>(this FullResume dto)
		{
			if (typeof(TResumeEntity) == typeof(ResumeMongoEntity)) return (TResumeEntity)Convert.ChangeType(dto.ToResumeMongoEntity(), typeof(TResumeEntity));
			else if (typeof(TResumeEntity) == typeof(ResumeSqlEntity)) return (TResumeEntity)Convert.ChangeType(dto.ToResumeSqlEntity(), typeof(TResumeEntity));
			else throw new NotSupportedException($"Type '{typeof(TResumeEntity)}' is not supported by resume mapper");
		}

		internal static ResumeMongoEntity ToResumeMongoEntity(this FullResume dto)
		{
			return new ResumeMongoEntity
			{
				Id = dto.Id,
				FirstName = dto.FirstName,
				LastName = dto.LastName,
				Title = dto.Title,
				Summary = dto.Summary,
				Contacts = dto.Contacts.Select(i => new ContactMongoEntity { Key = i.Key, Value = i.Value }),
				Skills = dto.Skills.Select(g => g.ToSkillMongoEntity()),
				Experience = dto.Experience.Select(e => e.ToExperienceMongoEntity()),
				Certifications = dto.Certifications.Select(c => c.ToCertificationMongoEntity()),
				Education = dto.Education.Select(e => e.ToEducationMongoEntity())
			};
		}

		internal static ResumeSqlEntity ToResumeSqlEntity(this FullResume dto)
		{
			return new ResumeSqlEntity
			{
				Id = dto.Id,
				FirstName = dto.FirstName,
				LastName = dto.LastName,
				Title = dto.Title,
				Summary = dto.Summary,
				Contacts = dto.Contacts.Select(i => new ContactSqlEntity { Key = i.Key, Value = i.Value }),
				Skills = dto.Skills.Select(g => g.ToSkillSqlEntity()),
				Experience = dto.Experience.Select(e => e.ToExperienceSqlEntity()),
				Certifications = dto.Certifications.Select(c => c.ToCertificationSqlEntity()),
				Education = dto.Education.Select(e => e.ToEducationSqlEntity())
			};
		}
	}
}
