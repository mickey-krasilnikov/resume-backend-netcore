using System;
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
                    IssueDate = new DateOnly(2020, 6, 10),
                    ExpirationDate = new DateOnly(2023, 5, 10),
                    VerificationUrl = new Uri("https, Value = //www.credly.com/badges/8ea21901-34c7-4cb4-bc48-71e0c5cf3e85"),

                },
                new CertificationSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Professional Cloud Architect",
                    Issuer =  "Google",
                    IssueDate = new DateOnly(2020, 9, 27),
                    ExpirationDate = new DateOnly(2022, 9, 27),
                    VerificationUrl = new Uri("https, Value = //www.credential.net/786961ad-0225-4bb0-883a-3c2feceb5174"),

                },
                new CertificationSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "AWS Certified Solutions Architect Associate",
                    Issuer =  "Amazon",
                    IssueDate = new DateOnly(2020, 3, 28),
                    ExpirationDate = new DateOnly(2024, 3, 28),
                    VerificationUrl = new Uri("https, Value = //www.credly.com/badges/dc95ff2a-12d8-4816-91b2-a9292ae5df85"),

                },
                new CertificationSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "DevOps Engineer Expert",
                    Issuer =  "Microsoft",
                    IssueDate = new DateOnly(2020, 11, 10),
                    ExpirationDate = new DateOnly(2023, 11, 10),
                    VerificationUrl = new Uri("eaedb35f-5ea9-45b2-b551-acad69b94488"),
                },
                new CertificationSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Azure Developer Associate",
                    Issuer =  "Microsoft",
                    VerificationUrl = new Uri("https, Value = //www.credly.com/badges/49ab14ad-ffe5-47ae-b3d1-9d29b00ef4dc"),
                    IssueDate = new DateOnly(2020, 4, 13),
                    ExpirationDate = new DateOnly(2022, 4, 13),
                },
                new CertificationSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Associate Cloud Engineer",
                    Issuer = "Google",
                    VerificationUrl = new Uri("https, Value = //www.credential.net/f4054913-d10c-4cd4-89cb-e286f00de2ae"),
                    IssueDate = new DateOnly(2020, 8, 29),
                    ExpirationDate = new DateOnly(2023, 8, 29)
                }
            };

            var contacts = new[]
            {
                new ContactSqlEntity { Key = "Phone", Value = "+14084803600", Link = "tel:+14084803600" },
                new ContactSqlEntity { Key = "Telegram", Value = "+1(408)480-3600", Link = "https://t.me/+14084803600" },
                new ContactSqlEntity { Key = "Whatsapp", Value = "+1(408)480-3600", Link = "https://wa.me/+14084803600" },
                new ContactSqlEntity { Key = "Email", Value =  "Mickey.Krasilnikov@gmail.com", Link = "mailto:your_email"},
                new ContactSqlEntity { Key = "Location", Value =  "Sunyvale, CA, 94085", Link = "https://www.google.com/maps/place/Sunyvale%20CA%2094085/" },
                new ContactSqlEntity { Key = "Github", Value = "@mickey-krasilnikov", Link = "https://github.com/mickey-krasilnikov" },
                new ContactSqlEntity { Key = "LinkedIn", Value = "@mickeykrasilnikov", Link = "https://www.linkedin.com/in/mickeykrasilnikov" },
                new ContactSqlEntity { Key = "Accredible", Value = "@mikhailkrasilnikov328966", Link = "https://www.credential.net/profile/mikhailkrasilnikov328966/wallet"},
                new ContactSqlEntity { Key = "Credly", Value = "@mickey-krasilnikov", Link = "https://www.credly.com/users/mickey-krasilnikov/badges"},
                new ContactSqlEntity { Key = "Instagram", Value = "@mickey.krasilnikov", Link = "https://www.instagram.com/mickey.krasilnikov" },
                new ContactSqlEntity { Key = "Facebook", Value = "@mickey.krasilnikov", Link = "https://www.facebook.com/mickey.krasilnikov" },
                new ContactSqlEntity { Key = "Twitter", Value = "@mickey_kras", Link = "https://twitter.com/mickey_kras" },
            };

            var education = new[]
            {
                new EducationSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Penza State University",
                    Degree = "Bachelor's degree",
                    FieldOfStudy = "Design and technology of radio electronic devices",
                    StartDate = new DateOnly(2006, 9, 1),
                    EndDate = new DateOnly(2013,06, 19),
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
                    Location = "San Jose, CA, USA",
                    Skills = new List<SkillSqlEntity>
                    {
                        new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Clouds", Name = "AWS"},
                        new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name =  "C#",AdditionalInfo=".NET Core 6.0"},
                        new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "ASP.NET Core Web API"},
                        new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "Python 3.9"},
                        new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "Vue.js"},
                        new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "JavaScript"},
                        new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name =  "TypeScript"},
                        new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "HTML"},
                        new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "CSS"},
                        new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Database",Name =  "MySQL"},
                        new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Docker"},
                        new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Jenkins"},
                        new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name =  "NUnit" }
                    },
                    TaskPerformed = new string[]
                    {
                        "Developed cloud-native Execution Compliance and Trade Surveillance System.",
                        "Designed and implemented a web dashboard for monitoring and analyzing using Vue.js.",
                        "Developed backend services following a RESTful approach using.NET Core.",
                        "Implemented event-driven workflow of loading and parsing large data files with Amazon SQS and AWS Lambdas written in Python."
                    },
                    StartDate = new DateOnly(2021, 10, 1)
                },
                new ExperienceSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Title = "Lead Software Engineer",
                    Company = "EPAM Systems",
                    Location = "Wroclaw, Poland",
                    Skills = new List<SkillSqlEntity>
                    {
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Clouds", Name = "Azure"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "C#", AdditionalInfo = ".NET Core 6.0"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "ASP.NET Core Web API"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "GoLang", AdditionalInfo = "Gin"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "Angular 13"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "JavaScript"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "TypeScript"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "HTML"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "CSS"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Database", Name = "Cosmos DB"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Database", Name = "Redis"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Azure DevOps"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "OKTA"},
                      new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "xUnit" }
                    },
                    TaskPerformed = new string[]
                    {
                      "Designed and developed a cloud-native microservice-based system for managing insurance claims, underwriting, and reporting.",
                      "Developed a web self-service portal using Angular, and RESTful Web APIs using .NET Core.",
                      "Implemented performance-critical internal services using GoLang with Gin web framework.",
                      "Achieved and maintained 80% code coverage by unit and contract tests, and established automated quality gates in CI/CD.",
                    },
                    StartDate = new DateOnly(2019, 4, 1),
                    EndDate = new DateOnly(2021, 10, 1)
                },
                new ExperienceSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Title = "Senior Software Engineer",
                    Company = "Credit Suisse",
                    Location = "Wroclaw, Poland",
                    Skills = new List<SkillSqlEntity>
                    {
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "C#", AdditionalInfo = ".NET Core 2.1 and .NET 4.6"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "WCF"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "WPF"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "XAML"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Database", Name = "MS SQL"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Database", Name = "MS SSAS"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Entity Framework"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "NUnit"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "TeamCity"},
                      new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Jenkins"},
                    },
                    TaskPerformed = new string[]
                    {
                      "Developed a risk management desktop application for the Credit Suisse front office using WPF and C#.",
                      "Converted an existing backend monolithic architecture into microservices and implemented new RESTful Web APIs using .NET Core.",
                      "Maintained and improved the performance of the in-house distributed cache written in C#.",
                      "Supported worldwide users as a part of the SL3 team.",
                    },
                    StartDate = new DateOnly(2015, 8, 1),
                    EndDate = new DateOnly(2019, 3, 1)
                },
                new ExperienceSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Title = "Senior Software Engineer",
                    Company = "Yandex",
                    Location = "Moscow, Russia",
                    Skills = new List<SkillSqlEntity>
                    {
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "C#", AdditionalInfo = ".NET 4.5"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "ASP.NET Web API"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "ASP.NET", AdditionalInfo = "MVC 5"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "JavaScript"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "HTML"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "CSS"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "WPF"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "XAML"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Database", Name = "MS SQL"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Entity Framework"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "NUnit"},
                      new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "TeamCity"},
                    },
                    TaskPerformed = new string[]
                    {
                      "Developed a payment system that allows employees to pay for lunch at nearby cafes and restaurants with the office access card (RFID tag)",
                      "Developed a personal page for users, a desktop application for administrators, and payment service middleware.",
                      "Participated in the software integration process."
                    },
                    StartDate = new DateOnly(2014, 8, 1),
                    EndDate = new DateOnly(2015, 8, 1)
                },
                new ExperienceSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Title = "Software Engineer",
                    Company = "Gollard",
                    Location = "Moscow, Russia",
                    Skills = new List<SkillSqlEntity>
                    {
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "C#",AdditionalInfo = ".NET 4.5"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "ASP.NET Web API"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "WCF"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "WPF"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "XAML"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Database", Name = "MS SQL"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Database", Name = "MySQL"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Esri ArcGIS"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "TeamCity"},
                      new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "NUnit"}
                    },
                    TaskPerformed = new string[]
                    {
                      "Developed a desktop GIS application for an energy distribution company that deals with electrical grids, stations, and facilities.",
                      "Implemented real-time tracking of service transport location and engine state.",
                      "Developed an alerting system that uses biometric data from cameras and events from sensors."
                    },
                    StartDate = new DateOnly(2013, 6, 1),
                    EndDate = new DateOnly(2014, 7, 1)
                },
                new ExperienceSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Title = "Software Engineer",
                    Company = "SGC",
                    Location = "Moscow, Russia",
                    Skills = new List<SkillSqlEntity>
                    {
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "C#",AdditionalInfo = ".NET 4.0"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "SOAP"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "WPF"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "XAML"},
                      new SkillSqlEntity {Id = Guid.NewGuid(), SkillGroup = "Database", Name = "MS SQL"},
                      new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "MSTest"},
                    },
                    TaskPerformed = new string[]
                    {
                      "Developed software for composing estimates to determine the cost of construction.",
                      "Added functionality for converting files from other well-known systems for composing estimates available on the market.",
                      "Implemented logic that allows exporting the final result to Excel, Word, etc."
                    },
                    StartDate = new DateOnly(2012, 7, 1),
                    EndDate = new DateOnly(2013, 6, 1)
                },
                new ExperienceSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Title = "Software Engineer",
                    Company = "Research and Production Center 'Start'",
                    Location = "Penza, Russia",
                    Skills = new List<SkillSqlEntity>
                    {
                      new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "C#", AdditionalInfo = ".NET 3.5" },
                      new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "SOAP" },
                      new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "WinForms" },
                      new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Database", Name = "MS SQL" }
                    },
                    TaskPerformed = new string[]
                    {
                      "Developed in-house CAD for designing microboards.",
                      "Implemented functionality for printing photomasks of microboards using special equipment.",
                      "Added the possibility to import AutoCAD files."
                    },
                    StartDate = new DateOnly(2010, 8, 1),
                    EndDate = new DateOnly(2012, 6, 1)
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
