using System;
using System.Text;
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
                    VerificationUrl = new Uri("https://www.credly.com/badges/8ea21901-34c7-4cb4-bc48-71e0c5cf3e85"),

                },
                new CertificationSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Professional Cloud Architect",
                    Issuer =  "Google",
                    IssueDate = new DateOnly(2020, 9, 27),
                    ExpirationDate = new DateOnly(2022, 9, 27),
                    VerificationUrl = new Uri("https://www.credential.net/786961ad-0225-4bb0-883a-3c2feceb5174"),

                },
                new CertificationSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "AWS Certified Solutions Architect Associate",
                    Issuer =  "Amazon",
                    IssueDate = new DateOnly(2020, 3, 28),
                    ExpirationDate = new DateOnly(2024, 3, 28),
                    VerificationUrl = new Uri("https://www.credly.com/badges/dc95ff2a-12d8-4816-91b2-a9292ae5df85"),

                },
                new CertificationSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "DevOps Engineer Expert",
                    Issuer =  "Microsoft",
                    IssueDate = new DateOnly(2020, 11, 10),
                    ExpirationDate = new DateOnly(2023, 11, 10),
                    VerificationUrl = new Uri("https://www.credly.com/badges/eaedb35f-5ea9-45b2-b551-acad69b94488"),
                },
                new CertificationSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Azure Developer Associate",
                    Issuer =  "Microsoft",
                    VerificationUrl = new Uri("https://www.credly.com/badges/49ab14ad-ffe5-47ae-b3d1-9d29b00ef4dc"),
                    IssueDate = new DateOnly(2020, 4, 13),
                    ExpirationDate = new DateOnly(2022, 4, 13),
                },
                new CertificationSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Associate Cloud Engineer",
                    Issuer = "Google",
                    VerificationUrl = new Uri("https://www.credential.net/f4054913-d10c-4cd4-89cb-e286f00de2ae"),
                    IssueDate = new DateOnly(2020, 8, 29),
                    ExpirationDate = new DateOnly(2023, 8, 29)
                }
            };

            var contacts = new[]
            {
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "Phone",
                    Value = "+14084803600",
                    Link = "tel:+14084803600"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "Telegram",
                    Value = "+1(408)480-3600",
                    Link = "https://t.me/+14084803600"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "Whatsapp",
                    Value = "+1(408)480-3600",
                    Link = "https://wa.me/+14084803600"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "Email",
                    Value =  "Mickey.Krasilnikov@gmail.com",
                    Link = "mailto:your_email"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "Location",
                    Value =  "Sunyvale, CA, 94085",
                    Link = "https://www.google.com/maps/place/Sunyvale%20CA%2094085/"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "Github",
                    Value = "@mickey-krasilnikov",
                    Link = "https://github.com/mickey-krasilnikov"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "LinkedIn",
                    Value = "@mickeykrasilnikov",
                    Link = "https://www.linkedin.com/in/mickeykrasilnikov"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "Accredible",
                    Value = "@mikhailkrasilnikov328966",
                    Link = "https://www.credential.net/profile/mikhailkrasilnikov328966/wallet"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "Credly",
                    Value = "@mickey-krasilnikov",
                    Link = "https://www.credly.com/users/mickey-krasilnikov/badges"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "Instagram",
                    Value = "@mickey.krasilnikov",
                    Link = "https://www.instagram.com/mickey.krasilnikov"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "Facebook",
                    Value = "@mickey.krasilnikov",
                    Link = "https://www.facebook.com/mickey.krasilnikov"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "Twitter",
                    Value = "@mickey_kras",
                    Link = "https://twitter.com/mickey_kras"
                },
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

            var cloudsAzure = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Clouds", Name = "Azure" };
            var cloudsAws = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Clouds", Name = "AWS" };
            var cloudsGcp = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Clouds", Name = "GCP" };

            var backendCSharp = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "C#" };
            var backendDotNet = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = ".NET" };
            var backendDotNetCore = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = ".NET Core" };
            var backendAspNetCore = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "ASP.NET Core" };
            var backendAspNet = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "ASP.NET" };
            var backendGoLang = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "GoLang" };
            var backendGinWebFramework = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "Gin Web Framework" };
            var backendPython3 = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "Python3" };
            var backendWcf = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "WCF" };

            var frontendAngular8Plus = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "Angular 8+" };
            var frontendVueJs = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "Vue.js" };
            var frontendJavaScript = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "JavaScript" };
            var frontendTypeScript = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "TypeScript" };
            var frontendHtml = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "HTML" };
            var frontendCss = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "CSS" };
            var frontendWpf = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "WPF" };
            var frontendXaml = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "XAML" };
            var frontendWinForms = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "WinForms" };

            var databaseMySql = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Database", Name = "MySQL" };
            var databaseMsSql = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Database", Name = "MS SQL" };
            var databaseMsSsas = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Database", Name = "MS SSAS" };
            var databaseCosmosDb = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Database", Name = "Cosmos DB" };
            var databaseRedis = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Database", Name = "Redis" };

            var toolsDocker = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Docker" };
            var toolsDevOps = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Azure DevOps" };
            var toolsJenkins = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Jenkins" };
            var toolsTeamCity = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "TeamCity" };
            var toolsOkta = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "OKTA" };
            var toolsEf = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Entity Framework" };
            var toolsEfCore = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Entity Framework Core" };
            var toolsXUnit = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "xUnit" };
            var toolsNUnit = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "NUnit" };
            var toolsMsTest = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "MSTest" };
            var toolsEsriArcGis = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Esri ArcGIS" };

            var skills = new[] {
                cloudsAzure,
                cloudsAws,
                cloudsGcp,
                backendCSharp,
                backendDotNet,
                backendDotNetCore,
                backendAspNetCore,
                backendAspNet,
                backendGoLang,
                backendGinWebFramework,
                backendPython3,
                backendWcf,
                frontendAngular8Plus,
                frontendVueJs,
                frontendJavaScript,
                frontendTypeScript,
                frontendHtml,
                frontendCss,
                frontendWpf,
                frontendXaml,
                frontendWinForms,
                databaseMySql,
                databaseMsSql,
                databaseMsSsas,
                databaseCosmosDb,
                databaseRedis,
                toolsDocker,
                toolsDevOps,
                toolsJenkins,
                toolsTeamCity,
                toolsOkta,
                toolsEf,
                toolsEfCore,
                toolsXUnit,
                toolsNUnit,
                toolsMsTest,
                toolsEsriArcGis,
            };

            var epamUs = new ExperienceSqlEntity
            {
                Id = Guid.NewGuid(),
                Title = "Lead Software Engineer",
                Company = "EPAM Systems",
                Location = "San Jose, CA, USA",
                TaskPerformed = new StringBuilder()
                        .AppendLine("Developed cloud-native Execution Compliance and Trade Surveillance System.")
                        .AppendLine("Designed and implemented a web dashboard for monitoring and analyzing using Vue.js.")
                        .AppendLine("Developed backend services following a RESTful approach using.NET Core.")
                        .AppendLine("Implemented event-driven workflow of loading and parsing large data files with Amazon SQS and AWS Lambdas written in Python.")
                        .ToString(),
                StartDate = new DateOnly(2021, 10, 1)
            };
            var epamPoland = new ExperienceSqlEntity
            {
                Id = Guid.NewGuid(),
                Title = "Lead Software Engineer",
                Company = "EPAM Systems",
                Location = "Wroclaw, Poland",
                TaskPerformed = new StringBuilder()
                        .AppendLine("Designed and developed a cloud-native microservice-based system for managing insurance claims, underwriting, and reporting.")
                        .AppendLine("Developed a web self-service portal using Angular, and RESTful Web APIs using .NET Core.")
                        .AppendLine("Implemented performance-critical internal services using GoLang with Gin web framework.")
                        .AppendLine("Achieved and maintained 80% code coverage by unit and contract tests, and established automated quality gates in CI/CD.")
                        .ToString(),
                StartDate = new DateOnly(2019, 4, 1),
                EndDate = new DateOnly(2021, 10, 1)
            };
            var creditSuisse = new ExperienceSqlEntity
            {
                Id = Guid.NewGuid(),
                Title = "Senior Software Engineer",
                Company = "Credit Suisse",
                Location = "Wroclaw, Poland",
                TaskPerformed = new StringBuilder()
                        .AppendLine("Developed a risk management desktop application for the Credit Suisse front office using WPF and C#.")
                        .AppendLine("Converted an existing backend monolithic architecture into microservices and implemented new RESTful Web APIs using .NET Core.")
                        .AppendLine("Maintained and improved the performance of the in-house distributed cache written in C#.")
                        .AppendLine("Supported worldwide users as a part of the SL3 team.")
                        .ToString(),
                StartDate = new DateOnly(2015, 8, 1),
                EndDate = new DateOnly(2019, 3, 1)
            };
            var yandex = new ExperienceSqlEntity
            {
                Id = Guid.NewGuid(),
                Title = "Senior Software Engineer",
                Company = "Yandex",
                Location = "Moscow, Russia",
                TaskPerformed = new StringBuilder()
                        .AppendLine("Developed a payment system that allows employees to pay for lunch at nearby cafes and restaurants with the office access card (RFID tag)")
                        .AppendLine("Developed a personal page for users, a desktop application for administrators, and payment service middleware.")
                        .AppendLine("Participated in the software integration process.")
                        .ToString(),
                StartDate = new DateOnly(2014, 8, 1),
                EndDate = new DateOnly(2015, 8, 1)
            };
            var gollard = new ExperienceSqlEntity
            {
                Id = Guid.NewGuid(),
                Title = "Software Engineer",
                Company = "Gollard",
                Location = "Moscow, Russia",
                TaskPerformed = new StringBuilder()
                        .AppendLine("Developed a desktop GIS application for an energy distribution company that deals with electrical grids, stations, and facilities.")
                        .AppendLine("Implemented real-time tracking of service transport location and engine state.")
                        .AppendLine("Developed an alerting system that uses biometric data from cameras and events from sensors.")
                        .ToString(),
                StartDate = new DateOnly(2013, 6, 1),
                EndDate = new DateOnly(2014, 7, 1)
            };
            var sgc = new ExperienceSqlEntity
            {
                Id = Guid.NewGuid(),
                Title = "Software Engineer",
                Company = "SGC",
                Location = "Moscow, Russia",
                TaskPerformed = new StringBuilder()
                        .AppendLine("Developed software for composing estimates to determine the cost of construction.")
                        .AppendLine("Added functionality for converting files from other well-known systems for composing estimates available on the market.")
                        .AppendLine("Implemented logic that allows exporting the final result to Excel, Word, etc.")
                        .ToString(),
                StartDate = new DateOnly(2012, 7, 1),
                EndDate = new DateOnly(2013, 6, 1)
            };
            var poStart = new ExperienceSqlEntity
            {
                Id = Guid.NewGuid(),
                Title = "Software Engineer",
                Company = "Research and Production Center 'Start'",
                Location = "Penza, Russia",
                TaskPerformed = new StringBuilder()
                        .AppendLine("Developed in-house CAD for designing microboards.")
                        .AppendLine("Implemented functionality for printing photomasks of microboards using special equipment.")
                        .AppendLine("Added the possibility to import AutoCAD files.")
                        .ToString(),
                StartDate = new DateOnly(2010, 8, 1),
                EndDate = new DateOnly(2012, 6, 1)
            };
            var experience = new[]
            {
                epamUs,
                epamPoland,
                creditSuisse,
                yandex,
                gollard,
                sgc,
                poStart
            };

            var skillExperienceMapping = new[]
            {
                new SkillExperienceSqlEntity { ExperienceId = epamUs.Id, SkillId = cloudsAws.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamUs.Id, SkillId = backendCSharp.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamUs.Id, SkillId = backendDotNetCore.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamUs.Id, SkillId = backendAspNetCore.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamUs.Id, SkillId = backendPython3.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamUs.Id, SkillId = frontendVueJs.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamUs.Id, SkillId = frontendJavaScript.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamUs.Id, SkillId = frontendTypeScript.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamUs.Id, SkillId = frontendHtml.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamUs.Id, SkillId = frontendCss.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamUs.Id, SkillId = databaseMySql.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamUs.Id, SkillId = toolsDocker.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamUs.Id, SkillId = toolsJenkins.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamUs.Id, SkillId = toolsNUnit.Id },

                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = cloudsAzure.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = backendCSharp.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = backendDotNetCore.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = backendAspNetCore.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = backendGoLang.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = backendGinWebFramework.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = frontendAngular8Plus.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = frontendTypeScript.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = frontendJavaScript.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = frontendHtml.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = frontendCss.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = databaseCosmosDb.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = databaseRedis.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = toolsDevOps.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = toolsOkta.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = toolsEfCore.Id },
                new SkillExperienceSqlEntity { ExperienceId = epamPoland.Id, SkillId = toolsXUnit.Id },

                new SkillExperienceSqlEntity { ExperienceId = creditSuisse.Id, SkillId = backendCSharp.Id },
                new SkillExperienceSqlEntity { ExperienceId = creditSuisse.Id, SkillId = backendDotNetCore.Id },
                new SkillExperienceSqlEntity { ExperienceId = creditSuisse.Id, SkillId = backendDotNet.Id },
                new SkillExperienceSqlEntity { ExperienceId = creditSuisse.Id, SkillId = backendWcf.Id },
                new SkillExperienceSqlEntity { ExperienceId = creditSuisse.Id, SkillId = frontendWpf.Id },
                new SkillExperienceSqlEntity { ExperienceId = creditSuisse.Id, SkillId = frontendXaml.Id },
                new SkillExperienceSqlEntity { ExperienceId = creditSuisse.Id, SkillId = databaseMsSql.Id },
                new SkillExperienceSqlEntity { ExperienceId = creditSuisse.Id, SkillId = databaseMsSsas.Id },
                new SkillExperienceSqlEntity { ExperienceId = creditSuisse.Id, SkillId = toolsEfCore.Id },
                new SkillExperienceSqlEntity { ExperienceId = creditSuisse.Id, SkillId = toolsEf.Id },
                new SkillExperienceSqlEntity { ExperienceId = creditSuisse.Id, SkillId = toolsNUnit.Id },
                new SkillExperienceSqlEntity { ExperienceId = creditSuisse.Id, SkillId = toolsTeamCity.Id },
                new SkillExperienceSqlEntity { ExperienceId = creditSuisse.Id, SkillId = toolsJenkins.Id },

                new SkillExperienceSqlEntity { ExperienceId = yandex.Id, SkillId = backendCSharp.Id },
                new SkillExperienceSqlEntity { ExperienceId = yandex.Id, SkillId = backendDotNet.Id },
                new SkillExperienceSqlEntity { ExperienceId = yandex.Id, SkillId = backendAspNet.Id },
                new SkillExperienceSqlEntity { ExperienceId = yandex.Id, SkillId = frontendJavaScript.Id },
                new SkillExperienceSqlEntity { ExperienceId = yandex.Id, SkillId = frontendHtml.Id },
                new SkillExperienceSqlEntity { ExperienceId = yandex.Id, SkillId = frontendCss.Id },
                new SkillExperienceSqlEntity { ExperienceId = yandex.Id, SkillId = frontendWpf.Id },
                new SkillExperienceSqlEntity { ExperienceId = yandex.Id, SkillId = frontendXaml.Id },
                new SkillExperienceSqlEntity { ExperienceId = yandex.Id, SkillId = databaseMsSql.Id },
                new SkillExperienceSqlEntity { ExperienceId = yandex.Id, SkillId = toolsEf.Id },
                new SkillExperienceSqlEntity { ExperienceId = yandex.Id, SkillId = toolsNUnit.Id },
                new SkillExperienceSqlEntity { ExperienceId = yandex.Id, SkillId = toolsTeamCity.Id },

                new SkillExperienceSqlEntity { ExperienceId = gollard.Id, SkillId = backendCSharp.Id },
                new SkillExperienceSqlEntity { ExperienceId = gollard.Id, SkillId = backendDotNet.Id },
                new SkillExperienceSqlEntity { ExperienceId = gollard.Id, SkillId = backendAspNet.Id },
                new SkillExperienceSqlEntity { ExperienceId = gollard.Id, SkillId = backendWcf.Id },
                new SkillExperienceSqlEntity { ExperienceId = gollard.Id, SkillId = frontendWpf.Id },
                new SkillExperienceSqlEntity { ExperienceId = gollard.Id, SkillId = frontendXaml.Id },
                new SkillExperienceSqlEntity { ExperienceId = gollard.Id, SkillId = databaseMsSql.Id },
                new SkillExperienceSqlEntity { ExperienceId = gollard.Id, SkillId = databaseMySql.Id },
                new SkillExperienceSqlEntity { ExperienceId = gollard.Id, SkillId = toolsEsriArcGis.Id },
                new SkillExperienceSqlEntity { ExperienceId = gollard.Id, SkillId = toolsTeamCity.Id },
                new SkillExperienceSqlEntity { ExperienceId = gollard.Id, SkillId = toolsNUnit.Id },

                new SkillExperienceSqlEntity { ExperienceId = sgc.Id, SkillId = backendCSharp.Id },
                new SkillExperienceSqlEntity { ExperienceId = sgc.Id, SkillId = backendDotNet.Id },
                new SkillExperienceSqlEntity { ExperienceId = sgc.Id, SkillId = frontendWpf.Id },
                new SkillExperienceSqlEntity { ExperienceId = sgc.Id, SkillId = frontendXaml.Id },
                new SkillExperienceSqlEntity { ExperienceId = sgc.Id, SkillId = databaseMsSql.Id },
                new SkillExperienceSqlEntity { ExperienceId = sgc.Id, SkillId = toolsMsTest.Id },

                new SkillExperienceSqlEntity { ExperienceId = poStart.Id, SkillId = backendCSharp.Id },
                new SkillExperienceSqlEntity { ExperienceId = poStart.Id, SkillId = backendDotNet.Id },
                new SkillExperienceSqlEntity { ExperienceId = poStart.Id, SkillId = frontendWinForms.Id },
                new SkillExperienceSqlEntity { ExperienceId = poStart.Id, SkillId = databaseMsSql.Id }
            };

            return new DataToSeed
            {
                Certification = certificates,
                Contacts = contacts,
                Eduction = education,
                Experience = experience,
                Skills = skills,
                SkillExperienceMapping = skillExperienceMapping
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
        public SkillExperienceSqlEntity[] SkillExperienceMapping { get; internal set; }
    }
}
