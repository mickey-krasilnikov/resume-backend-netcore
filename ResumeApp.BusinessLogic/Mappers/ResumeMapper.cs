using MongoDB.Bson;
using ResumeApp.DataAccess.MongoDb.Entities;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class ResumeMapper
	{
		internal static ConciseResume ToConsiseResumeDto(this ResumeEntity entity)
		{
			if (entity == null) return null!;

			var langSkillGroups = entity.Skills.Find(s => s.Name == "Programming Languages");
			var langSkills = langSkillGroups == null
				? new List<string>()
				: langSkillGroups.SubGroups.SelectMany(g => g.Skills.Select(s => s.Name));

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

		internal static FullResume ToFullResumeDto(this ResumeEntity entity)
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
				Skills = entity.Skills.ConvertAll(g => g.ToSkillGroupDto()),
				Experience = entity.Experience.ConvertAll(e => e.ToExperienceDto()),
				Certifications = entity.Certifications.ConvertAll(c => c.ToCertificationDto()),
				Education = entity.Education.ConvertAll(e => e.ToEducationDto())
			};
		}

		internal static ResumeEntity ToResumeEntity(this FullResume dto)
		{
			if (dto == null) return null!;
			var isParsed = ObjectId.TryParse(dto.ID, out var objectId);
			if (!isParsed) return null!;

			return new ResumeEntity
			{
				Id = objectId,
				FirstName = dto.FirstName,
				LastName = dto.LastName,
				Title = dto.Title,
				Contacts = dto.Contacts,
				Summary = dto.Summary,
				Skills = dto.Skills.ConvertAll(g => g.ToSkillGroupEntity()),
				Experience = dto.Experience.ConvertAll(e => e.ToExperienceEntity()),
				Certifications = dto.Certifications.ConvertAll(c => c.ToCertificationEntity()),
				Education = dto.Education.ConvertAll(e => e.ToEducationEntity())
			};
		}

		private static SkillGroup ToSkillGroupDto(this SkillGroupEntity entity)
		{
			if (entity == null) return null!;

			return new SkillGroup
			{
				Name = entity.Name,
				Skills = entity.Skills?.ConvertAll(s => s.ToSkillDto()),
				SubGroups = entity.SubGroups?.ConvertAll(g => g.ToSkillGroupDto())
			};
		}

		private static SkillGroupEntity ToSkillGroupEntity(this SkillGroup dto)
		{
			if (dto == null) return null!;

			return new SkillGroupEntity
			{
				Name = dto.Name,
				Skills = dto.Skills?.ConvertAll(s => s.ToSkillEntity()),
				SubGroups = dto.SubGroups?.ConvertAll(g => g.ToSkillGroupEntity())
			};
		}

		private static Skill ToSkillDto(this SkillEntity entity)
		{
			if (entity == null) return null!;

			return new Skill
			{
				Name = entity.Name,
				AdditionalInfo = entity.AdditionalInfo
			};
		}

		private static SkillEntity ToSkillEntity(this Skill dto)
		{
			if (dto == null) return null!;

			return new SkillEntity
			{
				Name = dto.Name,
				AdditionalInfo = dto.AdditionalInfo
			};
		}

		private static Experience ToExperienceDto(this ExperienceEntity entity)
		{
			return new Experience
			{
				Title = entity.Title,
				Company = entity.Company,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				Projects = entity.Projects.ConvertAll(s => s.ToProjectDto())
			};
		}

		private static ExperienceEntity ToExperienceEntity(this Experience dto)
		{
			return new ExperienceEntity
			{
				Title = dto.Title,
				Company = dto.Company,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				Projects = dto.Projects.ConvertAll(s => s.ToProjectEntity())
			};
		}

		private static Project ToProjectDto(this ProjectEntity entity)
		{
			if (entity == null) return null!;

			return new Project
			{
				Client = entity.Client,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				Envirnment = entity.Envirnment,
				ProjectRole = entity.ProjectRole,
				TaskPerformed = entity.TaskPerformed
			};
		}

		private static ProjectEntity ToProjectEntity(this Project dto)
		{
			if (dto == null) return null!;

			return new ProjectEntity
			{
				Client = dto.Client,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				Envirnment = dto.Envirnment,
				ProjectRole = dto.ProjectRole,
				TaskPerformed = dto.TaskPerformed
			};
		}

		private static Certification ToCertificationDto(this CertificationEntity entity)
		{
			if (entity == null) return null!;

			return new Certification
			{
				Name = entity.Name,
				Issuer = entity.Issuer,
				IssueDate = entity.IssueDate,
				ExpirationDate = entity.ExpirationDate,
				VerificationURL = entity.VerificationURL
			};
		}

		private static CertificationEntity ToCertificationEntity(this Certification dto)
		{
			if (dto == null) return null!;

			return new CertificationEntity
			{
				Name = dto.Name,
				Issuer = dto.Issuer,
				IssueDate = dto.IssueDate,
				ExpirationDate = dto.ExpirationDate,
				VerificationURL = dto.VerificationURL
			};
		}

		private static Education ToEducationDto(this EducationEntity entity)
		{
			if (entity == null) return null!;

			return new Education
			{
				Name = entity.Name,
				Degree = entity.Degree,
				FieldOfStudy = entity.FieldOfStudy,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				Url = entity.Url
			};
		}

		private static EducationEntity ToEducationEntity(this Education dto)
		{
			if (dto == null) return null!;

			return new EducationEntity
			{
				Name = dto.Name,
				Degree = dto.Degree,
				FieldOfStudy = dto.FieldOfStudy,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				Url = dto.Url
			};
		}
	}
}
