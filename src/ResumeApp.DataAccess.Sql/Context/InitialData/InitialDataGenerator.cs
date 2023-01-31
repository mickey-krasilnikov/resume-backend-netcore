using ResumeApp.DataAccess.Sql.Entities;

namespace ResumeApp.DataAccess.Sql.Context.InitialData
{
	public static class InitialDataGenerator
	{
		public static DataToSeed GetDataToSeed()
		{
			var certificates = new[]
			{
				new CertificationSqlEntity
				{
					Id = Guid.NewGuid(),
					Name = "Azure Solutions Architect Expert",
					Issuer =  "Microsoft",
					IssueDate = new DateOnly(),
					ExpirationDate = new DateOnly(),
					VerificationUrl = new Uri("https://www.credly.com/badges/42f9be70-0b40-4bb0-8256-bd9d573e36af/public_url"),
					
				},
				new CertificationSqlEntity
				{
					Id =Guid.NewGuid(),
					Name = "Professional Cloud Architect",
					Issuer =  "Google",
					IssueDate = new DateOnly(),
					ExpirationDate = new DateOnly(),
					VerificationUrl = new Uri("https://www.credential.net/786961ad-0225-4bb0-883a-3c2feceb5174"),
					
				},
				new CertificationSqlEntity
				{
					Id = Guid.NewGuid(),
					Name = "AWS Certified Solutions Architect Associate",
					Issuer =  "Amazon",
					IssueDate = new DateOnly(),
					ExpirationDate = new DateOnly(),
					VerificationUrl = new Uri("https://www.credly.com/badges/dc95ff2a-12d8-4816-91b2-a9292ae5df85/public_url"),
					
				},
				new CertificationSqlEntity
				{
					Id = Guid.NewGuid(),
					Name = "DevOps Engineer Expert",
					Issuer =  "Microsoft",
					IssueDate = new DateOnly(),
					ExpirationDate = new DateOnly(),
					VerificationUrl = new Uri("https://www.credly.com/badges/2d29613e-7c7e-481d-aba3-842b409fecd7/public_url"),
					
				}
			};

			var contacts = new[]
			{
				new ContactSqlEntity { Key = "Location", Value = "Sunnyvale, CA, 94085" },
				new ContactSqlEntity { Key = "Phone", Value = "+1(408)480-3600" },
				new ContactSqlEntity { Key = "Email", Value =  "mickey.krasilnikov@gmail.com"},
				new ContactSqlEntity { Key = "Accredible", Value = "https://www.credential.net/profile/mikhailkrasilnikov328966/wallet"},
				new ContactSqlEntity { Key = "Credly", Value =  "https://www.credly.com/users/mickey-krasilnikov/badges"},
				new ContactSqlEntity { Key = "LinkedIn", Value =  "https://www.linkedin.com/in/mickeykrasilnikov/"}
			};

			var education = new[]
			{
				new EducationSqlEntity
				{
					Id = Guid.NewGuid(),
					Name = "Penza State University",
					Degree = "Bachelor's degree",
					FieldOfStudy = "Design and technology of radio electronic devices",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					Url = new Uri("https://international.pnzgu.ru/")
				}
			};

			var experience = new[]
			{
				new ExperienceSqlEntity
				{
					Id = Guid.NewGuid(),
					Title = "Lead Software Engineer",
					Company = "EPAM Systems",
					StartDate = new DateOnly(),
					EndDate = new DateOnly()					
				},
				new ExperienceSqlEntity
				{
					Id = Guid.NewGuid(),
					Title = "Front Office Risk System Developer (AVP) (Senior Software Engineer)",
					Company = "Credit Suisse",
					StartDate = new DateOnly(),
					EndDate = new DateOnly()					
				},
				new ExperienceSqlEntity
				{
					Id = Guid.NewGuid(),
					Title = "Senior Software Engineer",
					Company = "SINTEGRO SOFT",
					StartDate = new DateOnly(),
					EndDate = new DateOnly()					
				},
				new ExperienceSqlEntity
				{
					Id = Guid.NewGuid(),
					Title = "Software Engineer",
					Company = "Gollard",
					StartDate = new DateOnly(),
					EndDate = new DateOnly()					
				},
				new ExperienceSqlEntity
				{
					Id = Guid.NewGuid(),
					Title = "Software Engineer",
					Company = "SGC",
					StartDate = new DateOnly(),
					EndDate = new DateOnly()					
				},
				new ExperienceSqlEntity
				{
					Id = Guid.NewGuid(),
					Title = "Software Engineer",
					Company = "Research and Production Center 'Start'",
					StartDate = new DateOnly(),
					EndDate = new DateOnly()					
				}
			};
		
			var skills = new[]
			{
				new SkillSqlEntity
				{
					SkillGroup = "Programming Languages/Backend",
					Id = Guid.NewGuid(),
					Name ="C#",
					AdditionalInfo = ".Net Core, .Net"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Programming Languages/Backend",
					Id = Guid.NewGuid(),
					Name ="GoLang",
					AdditionalInfo = "Gin"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Programming Languages/Backend",
					Id = Guid.NewGuid(),
					Name ="Javascript",
					AdditionalInfo = "Node.js"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Programming Languages/Backend",
					Id = Guid.NewGuid(),
					Name ="Python",
					AdditionalInfo = "FastAPI"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Programming Languages/Frontend",
					Id = Guid.NewGuid(),
					Name = "Angular",
				},
				new SkillSqlEntity
				{
					SkillGroup = "Programming Languages/Frontend",
					Id = Guid.NewGuid(),
					Name ="Vue.js"
				},
				new SkillSqlEntity
				{

					SkillGroup = "Programming Languages/Frontend",
					Id = Guid.NewGuid(),
					Name = "JavaScript",
				},
				new SkillSqlEntity
				{
					SkillGroup = "Programming Languages/Frontend",
					Id = Guid.NewGuid(),
					Name = "TypeScript",
				},
				new SkillSqlEntity
				{
					SkillGroup = "Programming Languages/Frontend",
					Id = Guid.NewGuid(),
					Name ="HTML"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Programming Languages/Frontend",
					Id = Guid.NewGuid(),
					Name ="CSS"
				},
				new SkillSqlEntity
				{

					SkillGroup = "Programming Languages/Database/SQL",
					Id = Guid.NewGuid(),
					Name = "T-SQL",
					AdditionalInfo = "MS SQL"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Programming Languages/Database/SQL",
					Id = Guid.NewGuid(),
					Name ="SQL/PSM",
					AdditionalInfo = "MySQL"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Programming Languages/Database/SQL",
					Id = Guid.NewGuid(),
					Name ="PL-SQL",
					AdditionalInfo = "PostgreSQL, Oracle"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Programming Languages/Database/NoSQL",
					Id = Guid.NewGuid(),
					Name = "MongoDB"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Programming Languages/Database/NoSQL",
					Id = Guid.NewGuid(),
					Name ="Redis"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Programming Languages/Database/NoSQL",
					Id = Guid.NewGuid(),
					Name ="CosmosDB"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Programming Languages/Database/NoSQL",
					Id = Guid.NewGuid(),
					Name ="DynamoDB"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Programming Languages/Database/NoSQL",
					Id = Guid.NewGuid(),
					Name ="BigTable"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Container Services",
					Id = Guid.NewGuid(),
					Name = "Docker"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Container Services",
					Id = Guid.NewGuid(),
					Name ="Docker Swarm"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Container Services",
					Id = Guid.NewGuid(),
					Name ="Kubernetes"
				},
				new SkillSqlEntity
				{
					SkillGroup = "CI/CD",
					Id = Guid.NewGuid(),
					Name = "Azure DevOps"
				},
				new SkillSqlEntity
				{
					SkillGroup = "CI/CD",
					Id = Guid.NewGuid(),
					Name = "GitHub Actions"
				},
				new SkillSqlEntity
				{
					SkillGroup = "CI/CD",
					Id = Guid.NewGuid(),
					Name = "AWS CodePipeline"
				},
				new SkillSqlEntity
				{
					SkillGroup = "CI/CD",
					Id = Guid.NewGuid(),
					Name = "Octopus"
				},
				new SkillSqlEntity
				{
					SkillGroup = "CI/CD",
					Id = Guid.NewGuid(),
					Name = "Jenkins"
				},
				new SkillSqlEntity
				{
					SkillGroup = "CI/CD",
					Id = Guid.NewGuid(),
					Name = "TeamCity"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Bug Tracking",
					Id = Guid.NewGuid(),
					Name = "JIRA"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Bug Tracking",
					Id = Guid.NewGuid(),
					Name = "Azure DevOps"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Source Control",
					Id = Guid.NewGuid(),
					Name = "GIT"
				},
				new SkillSqlEntity
				{
					SkillGroup = "Source Control",
					Id = Guid.NewGuid(),
					Name = "SVN"
				},
				new SkillSqlEntity
				{
					Id = Guid.NewGuid(),
					SkillGroup = "OS",
					Name = "Windows"
				},
				new SkillSqlEntity
				{
					Id = Guid.NewGuid(),
					SkillGroup = "OS",
					Name = "MacOS"
				},
				new SkillSqlEntity
				{
					Id = Guid.NewGuid(),
					SkillGroup = "OS",
					Name = "Ubuntu"
				},
				new SkillSqlEntity
				{
					Id = Guid.NewGuid(),
					SkillGroup = "Cloud",
					Name = "Azure"
				},
				new SkillSqlEntity
				{
					Id = Guid.NewGuid(),
					SkillGroup = "Cloud",
					Name = "AWS"
				},
				new SkillSqlEntity
				{
					Id = Guid.NewGuid(),
					SkillGroup = "Cloud",
					Name = "GCP"
				}
			};

			return new DataToSeed
			{
				Certification = certificates,
				Contacts = contacts,
				Eduction = education,
				Experience = experience,
				Skills = skills
			};
		}
	}

	public class DataToSeed
	{
		public CertificationSqlEntity[] Certification { get; internal set; }
		public ContactSqlEntity[] Contacts { get; internal set; }
		public EducationSqlEntity[] Eduction { get; internal set; }
		public ExperienceSqlEntity[] Experience { get; internal set; }
		public SkillSqlEntity[] Skills { get; internal set; }
	}
}
