using ResumeApp.DataAccess.Sql.Entities;

namespace ResumeApp.DataAccess.Sql.Context.InitialData
{
	public static class InitialDataGenerator
	{
		public static DataToSeed GetDataToSeed()
		{
			var resume = new ResumeSqlEntity()
			{
				Id = Guid.NewGuid(),
				FirstName = "Mikhail",
				LastName = "Krasilnikov",
				Title = "Lead Software Engineer",
				Summary = "12+ years of professional programming experience with consistently increasing " +
						  "responsibilities in the design and development of commercial applications on different " +
						  "platforms and environments \nCertified Cloud Solution Architect (Azure, GCP, AWS) \n" +
						  "Experienced as a Team Leader \nInvolved in full Software Development Life Cycle (SDLC)"
			};

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
					ResumeId = resume.Id
				},
				new CertificationSqlEntity
				{
					Id =Guid.NewGuid(),
					Name = "Professional Cloud Architect",
					Issuer =  "Google",
					IssueDate = new DateOnly(),
					ExpirationDate = new DateOnly(),
					VerificationUrl = new Uri("https://www.credential.net/786961ad-0225-4bb0-883a-3c2feceb5174"),
					ResumeId = resume.Id
				},
				new CertificationSqlEntity
				{
					Id = Guid.NewGuid(),
					Name = "AWS Certified Solutions Architect Associate",
					Issuer =  "Amazon",
					IssueDate = new DateOnly(),
					ExpirationDate = new DateOnly(),
					VerificationUrl = new Uri("https://www.credly.com/badges/dc95ff2a-12d8-4816-91b2-a9292ae5df85/public_url"),
					ResumeId = resume.Id
				},
				new CertificationSqlEntity
				{
					Id = Guid.NewGuid(),
					Name = "DevOps Engineer Expert",
					Issuer =  "Microsoft",
					IssueDate = new DateOnly(),
					ExpirationDate = new DateOnly(),
					VerificationUrl = new Uri("https://www.credly.com/badges/2d29613e-7c7e-481d-aba3-842b409fecd7/public_url"),
					ResumeId = resume.Id
				}
			};

			var contacts = new[]
			{
				new ContactSqlEntity { Key = "Location", Value = "Sunnyvale, CA, 94085", ResumeId = resume.Id },
				new ContactSqlEntity { Key = "Phone", Value = "+1(408)480-3600", ResumeId = resume.Id },
				new ContactSqlEntity { Key = "Email", Value =  "mickey.krasilnikov@gmail.com", ResumeId = resume.Id},
				new ContactSqlEntity { Key = "Accredible", Value = "https://www.credential.net/profile/mikhailkrasilnikov328966/wallet", ResumeId = resume.Id},
				new ContactSqlEntity { Key = "Credly", Value =  "https://www.credly.com/users/mickey-krasilnikov/badges", ResumeId = resume.Id},
				new ContactSqlEntity { Key = "LinkedIn", Value =  "https://www.linkedin.com/in/mickeykrasilnikov/", ResumeId = resume.Id}
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
					Url = new Uri("https://international.pnzgu.ru/"),
					ResumeId = resume.Id
				}
			};

			var epamProjectGroup = new List<ProjectSqlEntity>()
			{
				new ProjectSqlEntity
				{
					Id = Guid.NewGuid(),
					Client = "Broadridge",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ProjectRoles = "Key Developer, Team Lead",
					Environment = ".NET Core 6.0, Vue.js, Python 3.7, AWS, AWS Lambda, AWS S3, " +
									 "AWS Beanstalk, AWS EC2, AWS Code Commit, AWS Code Build, " +
									 "AWS Code Deploy, AWS Code Pipeline, Docker, AWS RDS, GIT"
				},
				new ProjectSqlEntity
				{
					Id = Guid.NewGuid(),
					Client = "ElipsLife",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ProjectRoles = "Key Developer, Team Lead",
					Environment = ".NET Core 6.0" +
								 "Angular 13" +
								 "Go Lang" +
								 "Azure" +
								 "Azure DevOps" +
								 "Octopus" +
								 "OKTA" +
								 "Docker" +
								 "Cosmos DB" +
								 "Redis" +
								 "MS SQL" +
								 "GIT",
					TaskPerformed =
						"Designed microservice-based hybrid-cloud solution architecture for multi-role self-service portal for managing insurance claims + underwriting + and broker reports." +
						"Designed and developed microservices following a RESTful approach and applying best practices. • Covered code with unit and contract tests and maintained code coverage on 80%." +
						"Configured CI/CD pipelines and established automated quality gates on different stages." +
						"Mentored new joiners and supported them during the ramp-up period." +
						"Performed systematic knowledge transfer to the client support team + including the creation of visual documentation. " +
						"Introduced and ensured the development team follows the very best engineering practices (with respect to various limitations on the client side)."
				}
			};
			var csProjectGroup = new List<ProjectSqlEntity>()
			{
				new ProjectSqlEntity
				{
					Id = Guid.NewGuid(),
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ProjectRoles = "Key Developer, Tech Lead",
					Environment = ".NET Core 2.1, .NET 4.6, WPF, WCF, EF, MS SQL, MS SSAS, TeamCity, Jira, Confluence, Splunk, GIT",
					TaskPerformed =
						"Maintained Risk Management System for Credit Suisse Front Office and developed new modules. " +
						"Improved performance and decreased memory usage in CS in-house distributed cache. " +
						"Splatted monolith server-side architecture to microservices. " +
						"Analyzed and arranged requirements with traders + BAU team and QA. " +
						"Supported worldwide users as a part of the SL3 team. " +
						"Administrated CI/CD on TeamCity. " +
						"Documented design decisions and usage examples. " +
						"Mentored new joiners."
				}
			};
			var sintegroProjectGroup = new List<ProjectSqlEntity>()
			{
				new ProjectSqlEntity
				{
					Id = Guid.NewGuid(),
					Client = "Yandex",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ProjectRoles = "Key Developer",
					Environment = ".NET 4.5, ASP.NET MVC 5, ASP.NET Web API, WPF, MS SQL, EF, TFS, WIX, GIT",
					TaskPerformed =
						"Participated in the development of the system that helps organize corporate bonuses + such as meals + mobile phones + fitness + transportation + etc." +
						"Developed user personal page that contains account balance and transaction history. " +
						"Developed desktop administration systems for corporate bonus managers." +
						"Documented design decisions + component APIs and usage examples." +
						"Participated in the software integration process."
				}
			};
			var gollardProjectGroup = new List<ProjectSqlEntity>()
			{
				new ProjectSqlEntity
				{
					Id = Guid.NewGuid(),
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ProjectRoles = "Key Developer",
					Environment = ".NET 4.5, WPF, WCF, ASP.NET Web API, Esri ArcGIS, MS SQL, MySQL, GitLab, WIX, GIT",
					TaskPerformed =
						"Participated in the development of desktop GIS application for the power distribution company dealing with electrical grids, stations and facilities on the map." +
						"Implemented a feature that allows monitoring the service transport on the map in real-time" +
						"Introduced the possibility to view video streams from the cameras marked on the map." +
						"Participated in the development of the solution to maintain security and safety of the buildings and areas using cameras and different types of sensors." +
						"Implemented an alerting system that works based on the biometric data from the cameras or events from the sensors."
				}
			};
			var sgcProjectGroup = new List<ProjectSqlEntity>()
			{
				new ProjectSqlEntity
				{
					Id = Guid.NewGuid(),
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ProjectRoles = "Key Developer",
					Environment = ".NET 4.0, WPF, SOAP, MS SQL, WIX, SVN",
					TaskPerformed =
						"Developed software for composing estimates to determine the cost of construction." +
						"Integrated with other well-known systems available on the market for composing estimates."
				}
			};
			var atomProjectGroup = new List<ProjectSqlEntity>()
			{
				new ProjectSqlEntity
				{
					Id = Guid.NewGuid(),
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ProjectRoles = "Key Developer",
					Environment = ".NET 3.5, WinForms, SOAP, MS SQL, SVN",
					TaskPerformed = "Developed software for designing micro boards and creating a mask for interacting with third-party equipment for printing this kind of product."
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
					EndDate = new DateOnly(),
					ResumeId = resume.Id
				},
				new ExperienceSqlEntity
				{
					Id = Guid.NewGuid(),
					Title = "Front Office Risk System Developer (AVP) (Senior Software Engineer)",
					Company = "Credit Suisse",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ResumeId = resume.Id
				},
				new ExperienceSqlEntity
				{
					Id = Guid.NewGuid(),
					Title = "Senior Software Engineer",
					Company = "SINTEGRO SOFT",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ResumeId = resume.Id
				},
				new ExperienceSqlEntity
				{
					Id = Guid.NewGuid(),
					Title = "Software Engineer",
					Company = "Gollard",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ResumeId = resume.Id
				},
				new ExperienceSqlEntity
				{
					Id = Guid.NewGuid(),
					Title = "Software Engineer",
					Company = "SGC",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ResumeId = resume.Id
				},
				new ExperienceSqlEntity
				{
					Id = Guid.NewGuid(),
					Title = "Software Engineer",
					Company = "Research and Production Center 'Start'",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ResumeId = resume.Id
				}
			};
			epamProjectGroup.ForEach(g => g.ExperienceId = experience[0].Id);
			csProjectGroup.ForEach(g => g.ExperienceId = experience[1].Id);
			sintegroProjectGroup.ForEach(g => g.ExperienceId = experience[2].Id);
			gollardProjectGroup.ForEach(g => g.ExperienceId = experience[3].Id);
			sgcProjectGroup.ForEach(g => g.ExperienceId = experience[4].Id);
			atomProjectGroup.ForEach(g => g.ExperienceId = experience[5].Id);

			var projectsList = new List<ProjectSqlEntity>();
			projectsList.AddRange(epamProjectGroup);
			projectsList.AddRange(csProjectGroup);
			projectsList.AddRange(sintegroProjectGroup);
			projectsList.AddRange(gollardProjectGroup);
			projectsList.AddRange(sgcProjectGroup);
			projectsList.AddRange(atomProjectGroup);
			var projects = projectsList.ToArray();

			var skills = new[]
			{
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Backend",
					Id = Guid.NewGuid(),
					Name ="C#",
					AdditionalInfo = ".Net Core, .Net"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Backend",
					Id = Guid.NewGuid(),
					Name ="GoLang",
					AdditionalInfo = "Gin"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Backend",
					Id = Guid.NewGuid(),
					Name ="Javascript",
					AdditionalInfo = "Node.js"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Backend",
					Id = Guid.NewGuid(),
					Name ="Python",
					AdditionalInfo = "FastAPI"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Frontend",
					Id = Guid.NewGuid(),
					Name = "Angular",
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Frontend",
					Id = Guid.NewGuid(),
					Name ="Vue.js"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Frontend",
					Id = Guid.NewGuid(),
					Name = "JavaScript",
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Frontend",
					Id = Guid.NewGuid(),
					Name = "TypeScript",
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Frontend",
					Id = Guid.NewGuid(),
					Name ="HTML"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Frontend",
					Id = Guid.NewGuid(),
					Name ="CSS"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Database/SQL",
					Id = Guid.NewGuid(),
					Name = "T-SQL",
					AdditionalInfo = "MS SQL"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Database/SQL",
					Id = Guid.NewGuid(),
					Name ="SQL/PSM",
					AdditionalInfo = "MySQL"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Database/SQL",
					Id = Guid.NewGuid(),
					Name ="PL-SQL",
					AdditionalInfo = "PostgreSQL, Oracle"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Database/NoSQL",
					Id = Guid.NewGuid(),
					Name = "MongoDB"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Database/NoSQL",
					Id = Guid.NewGuid(),
					Name ="Redis"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Database/NoSQL",
					Id = Guid.NewGuid(),
					Name ="CosmosDB"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Database/NoSQL",
					Id = Guid.NewGuid(),
					Name ="DynamoDB"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Database/NoSQL",
					Id = Guid.NewGuid(),
					Name ="BigTable"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Container Services",
					Id = Guid.NewGuid(),
					Name = "Docker"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Container Services",
					Id = Guid.NewGuid(),
					Name ="Docker Swarm"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Container Services",
					Id = Guid.NewGuid(),
					Name ="Kubernetes"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "CI/CD",
					Id = Guid.NewGuid(),
					Name = "Azure DevOps"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "CI/CD",
					Id = Guid.NewGuid(),
					Name = "GitHub Actions"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "CI/CD",
					Id = Guid.NewGuid(),
					Name = "AWS CodePipeline"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "CI/CD",
					Id = Guid.NewGuid(),
					Name = "Octopus"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "CI/CD",
					Id = Guid.NewGuid(),
					Name = "Jenkins"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "CI/CD",
					Id = Guid.NewGuid(),
					Name = "TeamCity"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Bug Tracking",
					Id = Guid.NewGuid(),
					Name = "JIRA"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Bug Tracking",
					Id = Guid.NewGuid(),
					Name = "Azure DevOps"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Source Control",
					Id = Guid.NewGuid(),
					Name = "GIT"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Source Control",
					Id = Guid.NewGuid(),
					Name = "SVN"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					Id = Guid.NewGuid(),
					SkillGroup = "OS",
					Name = "Windows"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					Id = Guid.NewGuid(),
					SkillGroup = "OS",
					Name = "MacOS"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					Id = Guid.NewGuid(),
					SkillGroup = "OS",
					Name = "Ubuntu"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					Id = Guid.NewGuid(),
					SkillGroup = "Cloud",
					Name = "Azure"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					Id = Guid.NewGuid(),
					SkillGroup = "Cloud",
					Name = "AWS"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					Id = Guid.NewGuid(),
					SkillGroup = "Cloud",
					Name = "GCP"
				}
			};

			return new DataToSeed
			{
				Resume = resume,
				Certification = certificates,
				Contacts = contacts,
				Eduction = education,
				Projects = projects,
				Experience = experience,
				Skills = skills
			};
		}
	}

	public class DataToSeed
	{
		public ResumeSqlEntity Resume { get; internal set; }
		public CertificationSqlEntity[] Certification { get; internal set; }
		public ContactSqlEntity[] Contacts { get; internal set; }
		public EducationSqlEntity[] Eduction { get; internal set; }
		public ProjectSqlEntity[] Projects { get; internal set; }
		public ExperienceSqlEntity[] Experience { get; internal set; }
		public SkillSqlEntity[] Skills { get; internal set; }
	}
}
