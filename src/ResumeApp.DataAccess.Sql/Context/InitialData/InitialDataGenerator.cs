using ResumeApp.DataAccess.Sql.Entities;

namespace ResumeApp.DataAccess.Sql.Context.InitialData
{
	public static class InitialDataGenerator
	{
		public static DataToSeed GetDataToSeed()
		{
			var resume = new ResumeSqlEntity()
			{
				Id = 1,
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
					Id = 1,
					Name = "Azure Solutions Architect Expert",
					Issuer =  "Microsoft",
					IssueDate = new DateOnly(),
					ExpirationDate = new DateOnly(),
					VerificationUrl = new Uri("https://www.credly.com/badges/42f9be70-0b40-4bb0-8256-bd9d573e36af/public_url"),
					ResumeId = resume.Id
				},
				new CertificationSqlEntity
				{
					Id =2,
					Name = "Professional Cloud Architect",
					Issuer =  "Google",
					IssueDate = new DateOnly(),
					ExpirationDate = new DateOnly(),
					VerificationUrl = new Uri("https://www.credential.net/786961ad-0225-4bb0-883a-3c2feceb5174"),
					ResumeId = resume.Id
				},
				new CertificationSqlEntity
				{
					Id = 3,
					Name = "AWS Certified Solutions Architect Associate",
					Issuer =  "Amazon",
					IssueDate = new DateOnly(),
					ExpirationDate = new DateOnly(),
					VerificationUrl = new Uri("https://www.credly.com/badges/dc95ff2a-12d8-4816-91b2-a9292ae5df85/public_url"),
					ResumeId = resume.Id
				},
				new CertificationSqlEntity
				{
					Id = 4,
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
					Id = 1,
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
					Id = 1,
					Client = "Broadridge",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ProjectRoles = "Key Developer, Team Lead",
					Envirnment = ".NET Core 6.0, Vue.js, Python 3.7, AWS, AWS Lambda, AWS S3, " +
									 "AWS Beanstalk, AWS EC2, AWS Code Commit, AWS Code Build, " +
									 "AWS Code Deploy, AWS Code Pipeline, Docker, AWS RDS, GIT"
				},
				new ProjectSqlEntity
				{
					Id = 2,
					Client = "ElipsLife",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ProjectRoles = "Key Developer, Team Lead",
					Envirnment = ".NET Core 6.0" +
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
					Id = 3,
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ProjectRoles = "Key Developer, Tech Lead",
					Envirnment = ".NET Core 2.1, .NET 4.6, WPF, WCF, EF, MS SQL, MS SSAS, TeamCity, Jira, Confluence, Splunk, GIT",
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
					Id = 4,
					Client = "Yandex",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ProjectRoles = "Key Developer",
					Envirnment = ".NET 4.5, ASP.NET MVC 5, ASP.NET Web API, WPF, MS SQL, EF, TFS, WIX, GIT",
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
					Id = 5,
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ProjectRoles = "Key Developer",
					Envirnment = ".NET 4.5, WPF, WCF, ASP.NET Web API, Esri ArcGIS, MS SQL, MySQL, GitLab, WIX, GIT",
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
					Id = 6,
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ProjectRoles = "Key Developer",
					Envirnment = ".NET 4.0, WPF, SOAP, MS SQL, WIX, SVN",
					TaskPerformed =
						"Developed software for composing estimates to determine the cost of construction." +
						"Integrated with other well-known systems available on the market for composing estimates."
				}
			};
			var atomProjectGroup = new List<ProjectSqlEntity>()
			{
				new ProjectSqlEntity
				{
					Id = 7,
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ProjectRoles = "Key Developer",
					Envirnment = ".NET 3.5, WinForms, SOAP, MS SQL, SVN",
					TaskPerformed = "Developed software for designing micro boards and creating a mask for interacting with third-party equipment for printing this kind of product."
				}
			};

			var experience = new[]
			{
				new ExperienceSqlEntity
				{
					Id = 1,
					Title = "Lead Software Engineer",
					Company = "EPAM Systems",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ResumeId = resume.Id
				},
				new ExperienceSqlEntity
				{
					Id = 2,
					Title = "Front Office Risk System Developer (AVP) (Senior Software Engineer)",
					Company = "Credit Suisse",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ResumeId = resume.Id
				},
				new ExperienceSqlEntity
				{
					Id = 3,
					Title = "Senior Software Engineer",
					Company = "SINTEGRO SOFT",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ResumeId = resume.Id
				},
				new ExperienceSqlEntity
				{
					Id = 4,
					Title = "Software Engineer",
					Company = "Gollard",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ResumeId = resume.Id
				},
				new ExperienceSqlEntity
				{
					Id = 5,
					Title = "Software Engineer",
					Company = "SGC",
					StartDate = new DateOnly(),
					EndDate = new DateOnly(),
					ResumeId = resume.Id
				},
				new ExperienceSqlEntity
				{
					Id = 6,
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
					Id = 1,
					Name ="C#",
					AdditionalInfo = ".Net Core, .Net"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Backend",
					Id = 2,
					Name ="GoLang",
					AdditionalInfo = "Gin"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Backend",
					Id = 3,
					Name ="Javascript",
					AdditionalInfo = "Node.js"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Backend",
					Id = 4,
					Name ="Python",
					AdditionalInfo = "FastAPI"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Frontend",
					Id = 5,
					Name = "Angular",
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Frontend",
					Id = 6,
					Name ="Vue.js"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Frontend",
					Id = 7,
					Name = "JavaScript",
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Frontend",
					Id = 8,
					Name = "TypeScript",
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Frontend",
					Id = 9,
					Name ="HTML"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Frontend",
					Id = 10,
					Name ="CSS"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Database/SQL",
					Id = 11,
					Name = "T-SQL",
					AdditionalInfo = "MS SQL"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Database/SQL",
					Id = 12,
					Name ="SQL/PSM",
					AdditionalInfo = "MySQL"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Database/SQL",
					Id = 13,
					Name ="PL-SQL",
					AdditionalInfo = "PostgreSQL, Oracle"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Database/NoSQL",
					Id = 14,
					Name = "MongoDB"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Database/NoSQL",
					Id = 15,
					Name ="Redis"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Database/NoSQL",
					Id = 16,
					Name ="CosmosDB"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Database/NoSQL",
					Id = 17,
					Name ="DynamoDB"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Programming Languages/Database/NoSQL",
					Id = 18,
					Name ="BigTable"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Container Services",
					Id = 19,
					Name = "Docker"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Container Services",
					Id = 20,
					Name ="Docker Swarm"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Container Services",
					Id = 21,
					Name ="Kubernetes"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "CI/CD",
					Id = 22,
					Name = "Azure DevOps"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "CI/CD",
					Id = 23,
					Name = "GitHub Actions"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "CI/CD",
					Id = 24,
					Name = "AWS CodePipeline"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "CI/CD",
					Id = 25,
					Name = "Octopus"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "CI/CD",
					Id = 26,
					Name = "Jenkins"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "CI/CD",
					Id = 27,
					Name = "TeamCity"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Bug Tracking",
					Id = 28,
					Name = "JIRA"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Bug Tracking",
					Id = 29,
					Name = "Azure DevOps"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Source Control",
					Id = 30,
					Name = "GIT"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					SkillGroup = "Source Control",
					Id = 31,
					Name = "SVN"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					Id = 32,
					SkillGroup = "OS",
					Name = "Windows"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					Id = 33,
					SkillGroup = "OS",
					Name = "MacOS"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					Id = 34,
					SkillGroup = "OS",
					Name = "Ubuntu"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					Id = 35,
					SkillGroup = "Cloud",
					Name = "Azure"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					Id = 36,
					SkillGroup = "Cloud",
					Name = "AWS"
				},
				new SkillSqlEntity
				{
					ResumeId = resume.Id,
					Id = 37,
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
	//internal static SkillSqlEntity[] GetSkillEntities()
	//{
	//	return new[]
	//	{
	//			new SkillSqlEntity
	//			{
	//				Id = 1,
	//				Name = "Programming Languages",
	//				SubSkills = new List<SkillSqlEntity>
	//				{
	//					new SkillSqlEntity
	//					{
	//						Id = 2,
	//						Name = "Backend",
	//						SubSkills = new List<SkillSqlEntity>
	//						{
	//							new SkillSqlEntity
	//							{
	//								Id = 3,
	//								Name ="C#",
	//								AdditionalInfo = ".Net Core, .Net"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 4,
	//								Name ="Javascript",
	//								AdditionalInfo = "Node.js"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 5,
	//								Name ="GoLang",
	//								AdditionalInfo = "Gin"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 6,
	//								Name ="Python",
	//								AdditionalInfo = "FastAPI"
	//							},
	//						}
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 7,
	//						Name = "Frontend",
	//						SubSkills = new List<SkillSqlEntity>
	//						{
	//							new SkillSqlEntity
	//							{
	//								Id = 8,
	//								Name = "JavaScript",
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 9,
	//								Name = "TypeScript",
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 10,
	//								Name = "Angular",
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 11,
	//								Name ="Vue.js"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 12,
	//								Name ="HTML"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 13,
	//								Name ="CSS"
	//							},
	//						}
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 14,
	//						Name = "Database",
	//						SubSkills = new List<SkillSqlEntity>
	//						{
	//							new SkillSqlEntity
	//							{
	//								Id = 15,
	//								Name = "SQL",
	//								SubSkills = new List<SkillSqlEntity>
	//								{
	//									new SkillSqlEntity
	//									{
	//										Id = 16,
	//										Name = "T-SQL",
	//										AdditionalInfo = "MS SQL"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 17,
	//										Name ="SQL/PSM",
	//										AdditionalInfo = "MySQL"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 18,
	//										Name ="PL-SQL",
	//										AdditionalInfo = "PostgreSQL, Oracle"

	//									}
	//								}
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 19,
	//								Name = "NoSQL",
	//								SubSkills = new List<SkillSqlEntity>
	//								{
	//									new SkillSqlEntity
	//									{
	//										Id = 20,
	//										Name = "MongoDB"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 21,
	//										Name ="Redis"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 22,
	//										Name ="CosmosDB"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 23,
	//										Name ="DynamoDB"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 24,
	//										Name ="BigTable"
	//									}
	//								}
	//							},
	//						}
	//					},
	//				},
	//			},
	//			new SkillSqlEntity
	//			{
	//				Id = 25,
	//				Name = "Container Services",
	//				SubSkills = new List<SkillSqlEntity>
	//				{
	//					new SkillSqlEntity
	//					{
	//						Id = 26,
	//						Name = "Docker"
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 27,
	//						Name ="Docker Swarm"
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 28,
	//						Name ="Kubernetes"
	//					}
	//				}
	//			},
	//			new SkillSqlEntity
	//			{
	//				Id = 29, Name = "CI/CD",
	//				SubSkills = new List<SkillSqlEntity>
	//				{
	//					new SkillSqlEntity
	//					{
	//						Id = 30, Name = "Azure DevOps"
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 31, Name = "GitHub Actions"
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 32, Name = "AWS CodePipeline"
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 33, Name = "Octopus"
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 34, Name = "Jenkins"
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 35, Name = "TeamCity"
	//					},
	//				}
	//			},
	//			new SkillSqlEntity
	//			{
	//				Id = 36, Name = "Bug Tracking",
	//				SubSkills = new List<SkillSqlEntity>
	//				{
	//					new SkillSqlEntity
	//					{
	//						Id = 37, Name = "JIRA"
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 38, Name = "Azure DevOps"
	//					}
	//				}
	//			},
	//			new SkillSqlEntity
	//			{
	//				Id = 39, Name = "Source Control",
	//				SubSkills = new List<SkillSqlEntity>
	//				{
	//					new SkillSqlEntity
	//					{
	//						Id = 40, Name = "GIT"
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 41, Name = "SVN"
	//					}
	//				}
	//			},
	//			new SkillSqlEntity
	//			{
	//				Id = 42, Name = "OS",
	//				SubSkills = new List<SkillSqlEntity>
	//				{
	//					new SkillSqlEntity
	//					{
	//						Id = 43, Name = "Windows"
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 44, Name = "MacOS"
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 45, Name = "Ubuntu"
	//					}
	//				}
	//			},
	//			new SkillSqlEntity
	//			{
	//				Id = 46, Name = "Clouds",
	//				AdditionalInfo = "Azure, AWS, GCP",
	//				SubSkills = new List<SkillSqlEntity>
	//				{
	//					new SkillSqlEntity
	//					{
	//						Id = 47, Name = "Compute",
	//						SubSkills = new List<SkillSqlEntity>
	//						{
	//							new SkillSqlEntity
	//							{
	//								Id = 48, Name = "IaaS",
	//								SubSkills = new List<SkillSqlEntity>
	//								{
	//									new SkillSqlEntity
	//									{
	//										Id = 49, Name = "Azure VM"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 50, Name = "Google Compute Engine"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 51, Name = "AWS EC2"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 52, Name = "Azure Container Instance"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 53, Name = "AWS ECS"
	//									}
	//								}
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 54, Name = "PaaS",
	//								SubSkills = new List<SkillSqlEntity>
	//								{
	//									new SkillSqlEntity
	//									{
	//										Id = 55, Name = "Azure App Service"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 56, Name = "Google App Engine"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 57, Name = "AWS Beanstalk"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 58, Name = "Azure AKS"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 59, Name = "Google Kubernetes Service"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 60, Name = "AWS EKS"
	//									}
	//								}
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 61, Name = "Serverless",
	//								SubSkills = new List<SkillSqlEntity>
	//								{
	//									new SkillSqlEntity
	//									{
	//										Id = 62, Name = "Azure Functions"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 63, Name = "Azure Logic Apps"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 64, Name = "Google Cloud Functions"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 65, Name = "Google Workflows"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 66, Name = "AWS Lambda"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 67, Name = "AWS Step Functions"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 68, Name = "AWS Fargate"
	//									}
	//								}
	//							}
	//						}
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 69, Name = "Storage",
	//						SubSkills = new List<SkillSqlEntity>
	//						{
	//							new SkillSqlEntity
	//							{
	//								Id = 70, Name = "RDS",
	//								SubSkills = new List<SkillSqlEntity>
	//								{
	//									new SkillSqlEntity
	//									{
	//										Id = 71, Name = "Azure SQL"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 72, Name = "Google Cloud SQL"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 73, Name = "AWS RDS"
	//									}
	//								}
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 74, Name = "NoSQL",
	//								SubSkills = new List<SkillSqlEntity>
	//								{
	//									new SkillSqlEntity
	//									{
	//										Id = 75, Name = "Azure CosmosDB"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 76, Name = "Azure Table Storage"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 77, Name = "Google BigTable"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 78, Name = "AWS DynamoDB"
	//									}
	//								}
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 79, Name = "Object",
	//								SubSkills = new List<SkillSqlEntity>
	//								{
	//									new SkillSqlEntity
	//									{
	//										Id = 80, Name = "Azure Blob Storage"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 81, Name = "Google Cloud Storage"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 82, Name = "AWS S3"
	//									}
	//								}
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 83, Name = "File",
	//								SubSkills = new List<SkillSqlEntity>
	//								{
	//									new SkillSqlEntity
	//									{
	//										Id = 84, Name = "Azure File Storage"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 85, Name = "Google Filestore"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 86, Name = "AWS EFS"
	//									}
	//								}
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 87, Name = "Archive",
	//								SubSkills = new List<SkillSqlEntity>
	//								{
	//									new SkillSqlEntity
	//									{
	//										Id = 88, Name = "Azure Archive Storage"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 89, Name = "Google Archive Storage"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 90, Name = "Amazon S3 Glacier"
	//									}
	//								}
	//							}
	//						},
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 91, Name = "Messaging",
	//						SubSkills = new List<SkillSqlEntity>
	//						{
	//							new SkillSqlEntity
	//							{
	//								Id = 92, Name = "Azure Service Bus"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 93, Name = "Azure Queue Storage"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 94, Name = "Azure Notification Hub"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 95, Name = "Google Pub/Sub"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 96, Name = "AWS SQS"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 97, Name = "AWS SNS"
	//							}
	//						}
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 98, Name = "Secret Management",
	//						SubSkills = new List<SkillSqlEntity>
	//						{
	//							new SkillSqlEntity
	//							{
	//								Id = 99, Name = "Azure KeyVault"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 100, Name = "Google Secret Manager"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 101, Name = "Google Cloud KMS"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 102, Name = "AWS Secrets Manager"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 103, Name = "AWS KMS"
	//							}
	//						}
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 104, Name = "Monitoring and Logging",
	//						SubSkills = new List<SkillSqlEntity>
	//						{
	//							new SkillSqlEntity
	//							{
	//								Id = 105, Name = "Azure Monitor"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 106, Name = "Google Cloud Logging"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 107, Name = "Google Cloud Monitoring"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 108, Name = "AWS CloudWatch"
	//							}
	//						}
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 109, Name = "Networking",
	//						SubSkills = new List<SkillSqlEntity>
	//						{
	//							new SkillSqlEntity
	//							{
	//								Id = 110, Name = "Virtual Network",
	//								SubSkills = new List<SkillSqlEntity>
	//								{
	//									new SkillSqlEntity
	//									{
	//										Id = 111, Name = "Azure VNET"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 112, Name = "Google VPC"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 113, Name = "AWS VPC"
	//									}
	//								}
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 114, Name = "Load Balancing",
	//								SubSkills = new List<SkillSqlEntity>
	//								{
	//									new SkillSqlEntity
	//									{
	//										Id = 115, Name = "Azure Load Balancer"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 116, Name = "Azure Traffic Manager"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 117, Name = "Google Cloud Load Balancing"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 118, Name = "AWS ELB"
	//									}
	//								}
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 119, Name = "Firewall",
	//								SubSkills = new List<SkillSqlEntity>
	//								{
	//									new SkillSqlEntity
	//									{
	//										Id = 120, Name = "Azure WAF"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 121, Name = "Google Cloud Firewalls"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 122, Name = "AWS WAF"
	//									}
	//								}
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 123, Name = "DNS",
	//								SubSkills = new List<SkillSqlEntity>
	//								{
	//									new SkillSqlEntity
	//									{
	//										Id = 124, Name = "Azure DNS"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 125, Name = "Google Cloud DNS"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 126, Name = "AWS Route 53"
	//									}
	//								}
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 127, Name = "CDN",
	//								SubSkills = new List<SkillSqlEntity>
	//								{
	//									new SkillSqlEntity
	//									{
	//										Id = 128, Name = "Azure CDN"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 129, Name = "Google Cloud CDN"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 130, Name = "AWS CloudFront"
	//									}
	//								}
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 131, Name = "Gateways",
	//								SubSkills = new List<SkillSqlEntity>
	//								{
	//									new SkillSqlEntity
	//									{
	//										Id = 132, Name = "Azure API Gateway"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 133, Name = "Azure API Management"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 134, Name = "Azure Frontdoor"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 135, Name = "Google API Management"
	//									},
	//									new SkillSqlEntity
	//									{
	//										Id = 136, Name = "AWS API Gateway"
	//									}
	//								}
	//							}
	//						},
	//					},
	//					new SkillSqlEntity
	//					{
	//						Id = 137, Name = "DevOps",
	//						SubSkills = new List<SkillSqlEntity>
	//						{
	//							new SkillSqlEntity
	//							{
	//								Id = 138, Name = "Azure DevOps",
	//								AdditionalInfo = "Boards, Pipelines, Repos, TestPlans, Artifacts"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 139, Name = "GCP DevOps",
	//								AdditionalInfo = "Cloud Build, Artifact Registry"
	//							},
	//							new SkillSqlEntity
	//							{
	//								Id = 140, Name = "AWS DevOps",
	//								AdditionalInfo = "CodePipeline, CodeBuild, CodeDeploy, CodeStar"
	//							}
	//						}
	//					}
	//				},
	//			}
	//		};
	//}
}
