﻿using System;
using System.Collections.Generic;
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
                    Key = "phone",
                    Value = "+14084803600",
                    Link = "tel:+14084803600"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "telegram",
                    Value = "Telegram",
                    Link = "https://t.me/+14084803600"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "whatsapp",
                    Value = "Whatsapp",
                    Link = "https://wa.me/+14084803600"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "email",
                    Value = "Mickey.Krasilnikov@gmail.com",
                    Link = "mailto:your_email"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "location",
                    Value = "Sunyvale, CA, 94085",
                    Link = "https://www.google.com/maps/place/Sunyvale%20CA%2094085/"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "github",
                    Value = "@mickey-krasilnikov",
                    Link = "https://github.com/mickey-krasilnikov"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "linkedIn",
                    Value = "@mickeykrasilnikov",
                    Link = "https://www.linkedin.com/in/mickeykrasilnikov"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "accredible",
                    Value = "@mikhailkrasilnikov328966",
                    Link = "https://www.credential.net/profile/mikhailkrasilnikov328966/wallet"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "credly",
                    Value = "@mickey-krasilnikov",
                    Link = "https://www.credly.com/users/mickey-krasilnikov/badges"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "instagram",
                    Value = "@mickey.krasilnikov",
                    Link = "https://www.instagram.com/mickey.krasilnikov"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "facebook",
                    Value = "@mickey.krasilnikov",
                    Link = "https://www.facebook.com/mickey.krasilnikov"
                },
                new ContactSqlEntity
                {
                    Id = Guid.NewGuid(),
                    Key = "twitter",
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

            var cloudsAzure = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Clouds", Name = "Azure", Priority = 101, IsHighlighted = true };
            var cloudsAws = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Clouds", Name = "AWS", Priority = 102, IsHighlighted = true };
            var cloudsGcp = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Clouds", Name = "GCP", Priority = 103, IsHighlighted = true };

            var backendCSharp = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "C#", Priority = 201, IsHighlighted = true };
            var backendDotNetCore = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = ".NET Core", Priority = 202, IsHighlighted = true };
            var backendDotNet = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = ".NET", Priority = 203, IsHighlighted = true };
            var backendAspNetCoreWebApi = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "ASP.NET Core Web API", Priority = 204, IsHighlighted = true };
            var backendAspNetWebApi = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "ASP.NET Web API", Priority = 205, IsHighlighted = true };
            var backendNodejs = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "Node.js", Priority = 206, IsHighlighted = true };
            var backendExpressWebFramework = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "Express.js Web Framework", Priority = 207, IsHighlighted = true };
            var backendGoLang = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "GoLang", Priority = 208, IsHighlighted = true };
            var backendGinWebFramework = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "Gin Web Framework", Priority = 209, IsHighlighted = true };
            var backendPython3 = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "Python3", Priority = 210, IsHighlighted = true };
            var backendFlaskWebFramework = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "Flask Web Framework", Priority = 211, IsHighlighted = true };
            var backendWcf = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "WCF", Priority = 212, IsHighlighted = false };
            var backendEf = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "Entity Framework", Priority = 213, IsHighlighted = false };
            var backendEfCore = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "Entity Framework Core", Priority = 214, IsHighlighted = false };
            var backendXUnit = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "xUnit", Priority = 215, IsHighlighted = false };
            var backendNUnit = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "NUnit", Priority = 216, IsHighlighted = false };
            var backendMsTest = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Backend", Name = "MSTest", Priority = 217, IsHighlighted = false };

            var frontendAngular8Plus = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "Angular 8+", Priority = 301, IsHighlighted = true };
            var frontendVueJs = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "Vue.js", Priority = 302, IsHighlighted = true };
            var frontendAspNetCore = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "ASP.NET Core (Blazor)", Priority = 303, IsHighlighted = true };
            var frontendAspNet = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "ASP.NET", Priority = 304, IsHighlighted = true };
            var frontendJavaScript = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "JavaScript", Priority = 305, IsHighlighted = true };
            var frontendTypeScript = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "TypeScript", Priority = 306, IsHighlighted = true };
            var frontendHtml = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "HTML", Priority = 307, IsHighlighted = true };
            var frontendCss = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "CSS", Priority = 308, IsHighlighted = true };
            var frontendWpf = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "WPF", Priority = 309, IsHighlighted = true };
            var frontendXaml = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "XAML", Priority = 310, IsHighlighted = true };
            var frontendWinForms = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Frontend", Name = "WinForms", Priority = 311, IsHighlighted = false };

            var databaseMySql = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Database", Name = "MySQL", Priority = 401, IsHighlighted = true };
            var databaseMsSql = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Database", Name = "MS SQL", Priority = 402, IsHighlighted = true };
            var databaseMsSsas = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Database", Name = "MS SSAS", Priority = 403, IsHighlighted = true };
            var databaseCosmosDb = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Database", Name = "Cosmos DB", Priority = 404, IsHighlighted = true };
            var databaseDynamoDb = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Database", Name = "Dynamo DB", Priority = 405, IsHighlighted = true };
            var databaseRedis = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Database", Name = "Redis", Priority = 406, IsHighlighted = true };

            var toolsDocker = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Docker", Priority = 501, IsHighlighted = true };
            var toolsKubernetes = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Kubernetes", Priority = 502, IsHighlighted = true };
            var toolsAzureDevOps = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Azure DevOps", Priority = 503, IsHighlighted = true };
            var toolsGithubActions = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "GitHub Actions", Priority = 504, IsHighlighted = true };
            var toolsAwsDevOps = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "AWS DevOps", Priority = 505, IsHighlighted = true };
            var toolsJenkins = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Jenkins", Priority = 506, IsHighlighted = true };
            var toolsTeamCity = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "TeamCity", Priority = 507, IsHighlighted = true };
            var toolsOkta = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "OKTA", Priority = 508, IsHighlighted = true };
            var toolsJira = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Jira", Priority = 509, IsHighlighted = true };
            var toolsEsriArcGis = new SkillSqlEntity { Id = Guid.NewGuid(), SkillGroup = "Tools", Name = "Esri ArcGIS", Priority = 510, IsHighlighted = true };
         
            var skills = new[] {
                cloudsAzure,
                cloudsAws,
                cloudsGcp,
                backendCSharp,
                backendDotNet,
                backendDotNetCore,
                backendAspNetCoreWebApi,
                backendAspNetWebApi,
                backendNodejs,
                backendExpressWebFramework,
                backendGoLang,
                backendGinWebFramework,
                backendPython3,
                backendFlaskWebFramework,
                backendWcf,
                backendEf,
                backendEfCore,
                backendXUnit,
                backendNUnit,
                backendMsTest,
                frontendAngular8Plus,
                frontendVueJs,
                frontendAspNetCore,
                frontendAspNet,
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
                databaseDynamoDb,
                databaseRedis,
                toolsDocker,
                toolsKubernetes,
                toolsAzureDevOps,
                toolsAwsDevOps,
                toolsGithubActions,
                toolsJenkins,
                toolsTeamCity,
                toolsOkta,
                toolsJira,
                toolsEsriArcGis,
            };

            var epamUs = new ExperienceSqlEntity
            {
                Id = Guid.NewGuid(),
                Title = "Lead Software Engineer",
                Company = "EPAM Systems",
                Location = "San Jose, CA, USA",
                TaskPerformed = new StringBuilder()
                        .AppendLine("Created Execution Compliance and Trade Surveillance System for analysis of trading activities to ensure regulatory compliance.")
                        .AppendLine("Engineered a Vue.js-based web dashboard for monitoring, analyzing, and visualizing data.")
                        .AppendLine("Designed and developed high-performance .NET Core backend services, resulting in a scalable and maintainable architecture.")
                        .AppendLine("Implemented an event-driven workflow that utilized Amazon SQS and AWS Lambdas, written in Python, to efficiently load and parse large data files, reducing processing times and increasing overall system throughput.")
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
                        .AppendLine("Created an intuitive self-service portal using Angular, improving customer satisfaction while reducing customer support inquiries.")
                        .AppendLine("Developed highly scalable and reliable RESTful microservices in .NET Core, resulting in improved efficiency and cost savings.")
                        .AppendLine("Implemented performance-critical internal services using GoLang, resulting in faster and more accurate claims processing.")
                        .AppendLine("Ensured high software quality with 80% code coverage and automated quality gates in CI/CD, reducing maintenance costs.")
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
                        .AppendLine("Created a high-performing desktop application for Credit Suisse's front office to manage market risks in real time using WPF and C#.")
                        .AppendLine("Restructured an existing monolithic architecture into microservices, providing more flexibility and scalability while improving performance.")
                        .AppendLine("Implemented automated testing, reducing the likelihood of bugs and errors and increasing the overall reliability of the system.")
                        .AppendLine("Optimized the performance of the in-house distributed cache, leading to faster processing times and greater efficiency in C#.")
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
                        .AppendLine("Developed a payment system that streamlined the process of paying for lunch at nearby cafes and restaurants using the office access card (RFID tag), resulting in improved efficiency and convenience for employees.")
                        .AppendLine("Designed and developed a user-friendly personal page for employees, enabling them to view their transaction history and account balance.")
                        .AppendLine("Created a desktop application for administrators that simplified the process of managing employee accounts and generating reports.")
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
                        .AppendLine("Created a GIS desktop app for energy distribution company handling grids, stations, and facilities, improving overall operational efficiency.")
                        .AppendLine("Enabled real-time tracking of service transport location and engine state, enhancing the company's logistical capabilities.")
                        .AppendLine("Implemented an alerting system that utilizes biometric camera data and sensor events, increasing the company's security posture.")
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
                        .AppendLine("Developed software that composes accurate construction cost estimates, which resulted in a 25% reduction in estimate preparation time.")
                        .AppendLine("Improved software flexibility and saved valuable time by adding the ability to convert estimates from other well-known systems.")
                        .AppendLine("Streamlined report creation process by enabling final estimate result export to various formats, providing customization options for users.")
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
                        .AppendLine("Developed an in-house CAD tool for designing microboards, including the ability to import AutoCAD files.")
                        .AppendLine("Implemented a feature that enables the printing of photomasks for microboards using specialized equipment.")
                        .AppendLine("Optimized the CAD tool for faster and more efficient microboard design, resulting in a 30% reduction in design time.")
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
                new SkillExperienceMappingSqlEntity { ExperienceId = epamUs.Id, SkillId = cloudsAws.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamUs.Id, SkillId = backendCSharp.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamUs.Id, SkillId = backendDotNetCore.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamUs.Id, SkillId = backendAspNetCoreWebApi.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamUs.Id, SkillId = backendPython3.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamUs.Id, SkillId = backendNUnit.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamUs.Id, SkillId = frontendVueJs.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamUs.Id, SkillId = frontendJavaScript.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamUs.Id, SkillId = frontendTypeScript.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamUs.Id, SkillId = frontendHtml.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamUs.Id, SkillId = frontendCss.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamUs.Id, SkillId = databaseMySql.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamUs.Id, SkillId = toolsDocker.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamUs.Id, SkillId = toolsAwsDevOps.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamUs.Id, SkillId = toolsJenkins.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamUs.Id, SkillId = toolsJira.Id },

                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = cloudsAzure.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = backendCSharp.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = backendDotNetCore.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = backendAspNetCoreWebApi.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = backendGoLang.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = backendGinWebFramework.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = backendEfCore.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = backendXUnit.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = frontendAngular8Plus.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = frontendTypeScript.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = frontendJavaScript.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = frontendHtml.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = frontendCss.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = databaseCosmosDb.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = databaseRedis.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = toolsAzureDevOps.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = toolsOkta.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = epamPoland.Id, SkillId = toolsJira.Id },

                new SkillExperienceMappingSqlEntity { ExperienceId = creditSuisse.Id, SkillId = backendCSharp.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = creditSuisse.Id, SkillId = backendDotNetCore.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = creditSuisse.Id, SkillId = backendDotNet.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = creditSuisse.Id, SkillId = backendWcf.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = creditSuisse.Id, SkillId = frontendWpf.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = creditSuisse.Id, SkillId = frontendXaml.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = creditSuisse.Id, SkillId = databaseMsSql.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = creditSuisse.Id, SkillId = databaseMsSsas.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = creditSuisse.Id, SkillId = backendEfCore.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = creditSuisse.Id, SkillId = backendEf.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = creditSuisse.Id, SkillId = backendNUnit.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = creditSuisse.Id, SkillId = toolsTeamCity.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = creditSuisse.Id, SkillId = toolsJenkins.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = creditSuisse.Id, SkillId = toolsJira.Id },

                new SkillExperienceMappingSqlEntity { ExperienceId = yandex.Id, SkillId = backendCSharp.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = yandex.Id, SkillId = backendDotNet.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = yandex.Id, SkillId = backendAspNetWebApi.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = yandex.Id, SkillId = backendEf.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = yandex.Id, SkillId = backendNUnit.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = yandex.Id, SkillId = frontendAspNet.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = yandex.Id, SkillId = frontendJavaScript.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = yandex.Id, SkillId = frontendHtml.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = yandex.Id, SkillId = frontendCss.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = yandex.Id, SkillId = frontendWpf.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = yandex.Id, SkillId = frontendXaml.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = yandex.Id, SkillId = databaseMsSql.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = yandex.Id, SkillId = toolsTeamCity.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = yandex.Id, SkillId = toolsJira.Id },

                new SkillExperienceMappingSqlEntity { ExperienceId = gollard.Id, SkillId = backendCSharp.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = gollard.Id, SkillId = backendDotNet.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = gollard.Id, SkillId = backendAspNetWebApi.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = gollard.Id, SkillId = backendWcf.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = gollard.Id, SkillId = backendNUnit.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = gollard.Id, SkillId = frontendWpf.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = gollard.Id, SkillId = frontendXaml.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = gollard.Id, SkillId = databaseMsSql.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = gollard.Id, SkillId = databaseMySql.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = gollard.Id, SkillId = toolsEsriArcGis.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = gollard.Id, SkillId = toolsTeamCity.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = gollard.Id, SkillId = toolsJira.Id },

                new SkillExperienceMappingSqlEntity { ExperienceId = sgc.Id, SkillId = backendCSharp.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = sgc.Id, SkillId = backendDotNet.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = sgc.Id, SkillId = backendMsTest.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = sgc.Id, SkillId = frontendWpf.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = sgc.Id, SkillId = frontendXaml.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = sgc.Id, SkillId = databaseMsSql.Id },

                new SkillExperienceMappingSqlEntity { ExperienceId = poStart.Id, SkillId = backendCSharp.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = poStart.Id, SkillId = backendDotNet.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = poStart.Id, SkillId = frontendWinForms.Id },
                new SkillExperienceMappingSqlEntity { ExperienceId = poStart.Id, SkillId = databaseMsSql.Id }
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
        public SkillExperienceMappingSqlEntity[] SkillExperienceMapping { get; internal set; }
    }
}