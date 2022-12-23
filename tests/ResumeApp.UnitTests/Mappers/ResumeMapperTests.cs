using Moq;
using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;

namespace ResumeApp.UnitTests.Mappers
{
	public class ResumeMapperTests
	{
		public static IEnumerable<object[]> TestData => new List<object[]>
		{
			new object[] { Guid.Empty, null, null, null, null },
			new object[] { Guid.Empty, string.Empty, string.Empty, string.Empty, string.Empty },
			new object[] { Guid.NewGuid(), "TestTitle", "TestFirstName", "TestLastName", "TestSummary" }
		};

		[Theory]
		[MemberData(nameof(TestData))]
		public void MongoEntityToShortResumeDto(Guid id, string title, string firstName, string lastName, string summary)
		{
			//Arrange
			var contactMock = new ContactMongoEntity { Key = "TestPhone", Value = "+1(123)456-7890" };
			var skillMock = new Mock<SkillMongoEntity>();
			var certification = new Mock<CertificationMongoEntity>();
			var education = new Mock<EducationMongoEntity>();
			var experience = new ExperienceMongoEntity
			{
				StartDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-10)),
				EndDate = DateOnly.FromDateTime(DateTime.UtcNow)
			};

			var entity = new ResumeMongoEntity
			{
				Id = id,
				Title = title,
				FirstName = firstName,
				LastName = lastName,
				Summary = summary,
				Contacts = new List<ContactMongoEntity> { contactMock },
				Skills = new List<SkillMongoEntity> { skillMock.Object },
				Experience = new List<ExperienceMongoEntity> { experience },
				Certifications = new List<CertificationMongoEntity> { certification.Object },
				Education = new List<EducationMongoEntity> { education.Object }
			};

			//Act
			var result = entity.ToShortResumeDto();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(title, result.Title);
			Assert.Equal(firstName, result.FirstName);
			Assert.Equal(lastName, result.LastName);
			Assert.Single(result.Contacts);
			Assert.Equal(10, result.YearsOfExperience);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void MongoEntityToFullResumeDto(Guid id, string title, string firstName, string lastName, string summary)
		{
			//Arrange
			var contactMock = new ContactMongoEntity { Key = "TestPhone", Value = "+1(123)456-7890" };
			var skillMock = new Mock<SkillMongoEntity>();
			var certification = new Mock<CertificationMongoEntity>();
			var education = new Mock<EducationMongoEntity>();
			var experience = new ExperienceMongoEntity
			{
				StartDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-10)),
				EndDate = DateOnly.FromDateTime(DateTime.UtcNow)
			};

			var entity = new ResumeMongoEntity
			{
				Id = id,
				Title = title,
				FirstName = firstName,
				LastName = lastName,
				Summary = summary,
				Contacts = new List<ContactMongoEntity> { contactMock },
				Skills = new List<SkillMongoEntity> { skillMock.Object },
				Experience = new List<ExperienceMongoEntity> { experience },
				Certifications = new List<CertificationMongoEntity> { certification.Object },
				Education = new List<EducationMongoEntity> { education.Object }
			};

			//Act
			var result = entity.ToFullResumeDto();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(title, result.Title);
			Assert.Equal(firstName, result.FirstName);
			Assert.Equal(lastName, result.LastName);
			Assert.Equal(summary, result.Summary);
			Assert.Single(result.Contacts);
			Assert.Single(result.Skills);
			Assert.Single(result.Experience);
			Assert.Single(result.Certifications);
			Assert.Single(result.Education);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void SqlEntityToShortResumeDto(Guid id, string title, string firstName, string lastName, string summary)
		{
			//Arrange
			var contactMock = new ContactSqlEntity { Key = "TestPhone", Value = "+1(123)456-7890" };
			var skillMock = new Mock<SkillSqlEntity>();
			var certification = new Mock<CertificationSqlEntity>();
			var education = new Mock<EducationSqlEntity>();
			var experience = new ExperienceSqlEntity
			{
				StartDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-10)),
				EndDate = DateOnly.FromDateTime(DateTime.UtcNow)
			};

			var entity = new ResumeSqlEntity
			{
				Id = id,
				Title = title,
				FirstName = firstName,
				LastName = lastName,
				Summary = summary,
				Contacts = new List<ContactSqlEntity> { contactMock },
				Skills = new List<SkillSqlEntity> { skillMock.Object },
				Experience = new List<ExperienceSqlEntity> { experience },
				Certifications = new List<CertificationSqlEntity> { certification.Object },
				Education = new List<EducationSqlEntity> { education.Object }
			};

			//Act
			var result = entity.ToShortResumeDto();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(title, result.Title);
			Assert.Equal(firstName, result.FirstName);
			Assert.Equal(lastName, result.LastName);
			Assert.Single(result.Contacts);
			Assert.Equal(10, result.YearsOfExperience);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void SqlEntityToFullResumeDto(Guid id, string title, string firstName, string lastName, string summary)
		{
			//Arrange
			var contactMock = new ContactSqlEntity { Key = "TestPhone", Value = "+1(123)456-7890" };
			var skillMock = new Mock<SkillSqlEntity>();
			var certification = new Mock<CertificationSqlEntity>();
			var education = new Mock<EducationSqlEntity>();
			var experience = new ExperienceSqlEntity
			{
				StartDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-10)),
				EndDate = DateOnly.FromDateTime(DateTime.UtcNow)
			};

			var entity = new ResumeSqlEntity
			{
				Id = id,
				Title = title,
				FirstName = firstName,
				LastName = lastName,
				Summary = summary,
				Contacts = new List<ContactSqlEntity> { contactMock },
				Skills = new List<SkillSqlEntity> { skillMock.Object },
				Experience = new List<ExperienceSqlEntity> { experience },
				Certifications = new List<CertificationSqlEntity> { certification.Object },
				Education = new List<EducationSqlEntity> { education.Object }
			};

			//Act
			var result = entity.ToFullResumeDto();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(title, result.Title);
			Assert.Equal(firstName, result.FirstName);
			Assert.Equal(lastName, result.LastName);
			Assert.Equal(summary, result.Summary);
			Assert.Single(result.Contacts);
			Assert.Single(result.Skills);
			Assert.Single(result.Experience);
			Assert.Single(result.Certifications);
			Assert.Single(result.Education);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void FullResumeDtoToMongoEntity(Guid id, string title, string firstName, string lastName, string summary)
		{
			//Arrange
			var contacts = new Dictionary<string, string> { { "TestPhone", "+1(123)456-7890" } };
			var skillMock = new Mock<Skill>();
			var certification = new Mock<Certification>();
			var education = new Mock<Education>();
			var experience = new Experience
			{
				StartDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-10)),
				EndDate = DateOnly.FromDateTime(DateTime.UtcNow)
			};

			var dto = new FullResume
			{
				Id = id,
				Title = title,
				FirstName = firstName,
				LastName = lastName,
				Summary = summary,
				Contacts = contacts,
				Skills = new List<Skill> { skillMock.Object },
				Experience = new List<Experience> { experience },
				Certifications = new List<Certification> { certification.Object },
				Education = new List<Education> { education.Object }
			};

			//Act
			var result = dto.ToResumeMongoEntity();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(title, result.Title);
			Assert.Equal(firstName, result.FirstName);
			Assert.Equal(lastName, result.LastName);
			Assert.Equal(summary, result.Summary);
			Assert.Single(result.Contacts);
			Assert.Single(result.Skills);
			Assert.Single(result.Experience);
			Assert.Single(result.Certifications);
			Assert.Single(result.Education);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void FullResumeDtoToSqlEntity(Guid id, string title, string firstName, string lastName, string summary)
		{
			//Arrange
			var contacts = new Dictionary<string, string> { { "TestPhone", "+1(123)456-7890" } };
			var skillMock = new Mock<Skill>();
			var certification = new Mock<Certification>();
			var education = new Mock<Education>();
			var experience = new Experience
			{
				StartDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-10)),
				EndDate = DateOnly.FromDateTime(DateTime.UtcNow)
			};

			var dto = new FullResume
			{
				Id = id,
				Title = title,
				FirstName = firstName,
				LastName = lastName,
				Summary = summary,
				Contacts = contacts,
				Skills = new List<Skill> { skillMock.Object },
				Experience = new List<Experience> { experience },
				Certifications = new List<Certification> { certification.Object },
				Education = new List<Education> { education.Object }
			};

			//Act
			var result = dto.ToResumeSqlEntity();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(title, result.Title);
			Assert.Equal(firstName, result.FirstName);
			Assert.Equal(lastName, result.LastName);
			Assert.Equal(summary, result.Summary);
			Assert.Single(result.Contacts);
			Assert.Single(result.Skills);
			Assert.Single(result.Experience);
			Assert.Single(result.Certifications);
			Assert.Single(result.Education);
		}
	}
}
