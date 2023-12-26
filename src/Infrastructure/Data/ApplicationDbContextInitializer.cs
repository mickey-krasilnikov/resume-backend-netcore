using System.Text;
using ResumeApp.Domain.Constants;
using ResumeApp.Domain.Entities;
using ResumeApp.Infrastructure.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ResumeApp.Infrastructure.Data;

public static class InitializerExtensions
{
    public static async Task InitialiseDatabaseAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var initializer = scope.ServiceProvider.GetRequiredService<ApplicationDbContextInitializer>();
        await initializer.InitialiseAsync();
        await initializer.SeedAsync();
    }
}

public class ApplicationDbContextInitializer(
    ILogger<ApplicationDbContextInitializer> logger,
    ApplicationDbContext context,
    UserManager<ApplicationUser> userManager,
    RoleManager<IdentityRole> roleManager)
{
    public async Task InitialiseAsync()
    {
        try
        {
            if (!context.Database.IsInMemory())
            {
                await context.Database.MigrateAsync();
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while initialising the database.");
            throw;
        }
    }

    public async Task SeedAsync()
    {
        try
        {
            await TrySeedAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while seeding the database.");
            throw;
        }
    }

    private async Task TrySeedAsync()
    {
        // Default roles
        var administratorRole = new IdentityRole(Roles.Administrator);
        if (roleManager.Roles.All(r => r.Name != administratorRole.Name))
        {
            await roleManager.CreateAsync(administratorRole);
        }

        // Default users
        var administrator =
            new ApplicationUser { UserName = "administrator@localhost", Email = "administrator@localhost" };
        if (userManager.Users.All(u => u.UserName != administrator.UserName))
        {
            await userManager.CreateAsync(administrator, "Administrator1!");
            if (!string.IsNullOrWhiteSpace(administratorRole.Name))
            {
                await userManager.AddToRolesAsync(administrator, new[] { administratorRole.Name });
            }
        }

        // Default data
        // Seed, if necessary
        if (!context.Certificates.Any() &&
            !context.Contacts.Any() &&
            !context.Skills.Any() &&
            !context.Experiences.Any())
        {
            context.Certificates.AddRange(
                new Certificate
                {
                    Id = Guid.NewGuid(),
                    Name = "Azure Solutions Architect Expert",
                    Issuer = "Microsoft",
                    IssueDate = new DateOnly(2020, 6, 10),
                    ExpirationDate = new DateOnly(2023, 5, 10),
                    VerificationUrl = new Uri("https://www.credly.com/badges/8ea21901-34c7-4cb4-bc48-71e0c5cf3e85"),
                },
                new Certificate
                {
                    Id = Guid.NewGuid(),
                    Name = "Professional Cloud Architect",
                    Issuer = "Google",
                    IssueDate = new DateOnly(2020, 9, 27),
                    ExpirationDate = new DateOnly(2022, 9, 27),
                    VerificationUrl = new Uri("https://www.credential.net/786961ad-0225-4bb0-883a-3c2feceb5174"),
                },
                new Certificate
                {
                    Id = Guid.NewGuid(),
                    Name = "AWS Certified Solutions Architect Associate",
                    Issuer = "Amazon",
                    IssueDate = new DateOnly(2020, 3, 28),
                    ExpirationDate = new DateOnly(2024, 3, 28),
                    VerificationUrl = new Uri("https://www.credly.com/badges/dc95ff2a-12d8-4816-91b2-a9292ae5df85"),
                },
                new Certificate
                {
                    Id = Guid.NewGuid(),
                    Name = "DevOps Engineer Expert",
                    Issuer = "Microsoft",
                    IssueDate = new DateOnly(2020, 11, 10),
                    ExpirationDate = new DateOnly(2023, 11, 10),
                    VerificationUrl = new Uri("https://www.credly.com/badges/eaedb35f-5ea9-45b2-b551-acad69b94488"),
                },
                new Certificate
                {
                    Id = Guid.NewGuid(),
                    Name = "Azure Developer Associate",
                    Issuer = "Microsoft",
                    VerificationUrl = new Uri("https://www.credly.com/badges/49ab14ad-ffe5-47ae-b3d1-9d29b00ef4dc"),
                    IssueDate = new DateOnly(2020, 4, 13),
                    ExpirationDate = new DateOnly(2022, 4, 13),
                },
                new Certificate
                {
                    Id = Guid.NewGuid(),
                    Name = "Associate Cloud Engineer",
                    Issuer = "Google",
                    VerificationUrl = new Uri("https://www.credential.net/f4054913-d10c-4cd4-89cb-e286f00de2ae"),
                    IssueDate = new DateOnly(2020, 8, 29),
                    ExpirationDate = new DateOnly(2023, 8, 29)
                });

            context.Contacts.AddRange(
                new Contact { Id = Guid.NewGuid(), Key = "location", Value = "Irvine, CA, 92614", Link = "https://www.google.com/maps/place/Irvine%20CA%2092614/" },
                new Contact { Id = Guid.NewGuid(), Key = "github", Value = "@mickey-krasilnikov", Link = "https://github.com/mickey-krasilnikov" },
                new Contact { Id = Guid.NewGuid(), Key = "linkedIn", Value = "@mickeykrasilnikov", Link = "https://www.linkedin.com/in/mickeykrasilnikov" },
                new Contact { Id = Guid.NewGuid(), Key = "credly", Value = "@mickey-krasilnikov", Link = "https://www.credly.com/users/mickey-krasilnikov/badges" },
                new Contact { Id = Guid.NewGuid(), Key = "instagram", Value = "@mickey.krasilnikov", Link = "https://www.instagram.com/mickey.krasilnikov" },
                new Contact { Id = Guid.NewGuid(), Key = "facebook", Value = "@mickey.krasilnikov", Link = "https://www.facebook.com/mickey.krasilnikov" });

            var cloudsAzure = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Clouds",
                Name = "Azure",
                Priority = 101,
                IsHighlighted = true
            };
            var cloudsAws = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Clouds",
                Name = "AWS",
                Priority = 102,
                IsHighlighted = true
            };
            var cloudsGcp = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Clouds",
                Name = "GCP",
                Priority = 103,
                IsHighlighted = true
            };

            var backendCSharp = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = "C#",
                Priority = 201,
                IsHighlighted = true
            };
            var backendDotNetCore = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = ".NET Core",
                Priority = 202,
                IsHighlighted = true
            };
            var backendDotNet = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = ".NET",
                Priority = 203,
                IsHighlighted = true
            };
            var backendAspNetCoreWebApi = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = "ASP.NET Core Web API",
                Priority = 204,
                IsHighlighted = true
            };
            var backendAspNetWebApi = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = "ASP.NET Web API",
                Priority = 205,
                IsHighlighted = true
            };
            var backendNodejs = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = "Node.js",
                Priority = 206,
                IsHighlighted = true
            };
            var backendExpressWebFramework = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = "Express.js Web Framework",
                Priority = 207,
                IsHighlighted = true
            };
            var backendGoLang = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = "GoLang",
                Priority = 208,
                IsHighlighted = true
            };
            var backendGinWebFramework = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = "Gin Web Framework",
                Priority = 209,
                IsHighlighted = true
            };
            var backendPython3 = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = "Python3",
                Priority = 210,
                IsHighlighted = true
            };
            var backendFlaskWebFramework = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = "Flask Web Framework",
                Priority = 211,
                IsHighlighted = true
            };
            var backendWcf = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = "WCF",
                Priority = 212,
                IsHighlighted = false
            };
            var backendEf = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = "Entity Framework",
                Priority = 213,
                IsHighlighted = false
            };
            var backendEfCore = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = "Entity Framework Core",
                Priority = 214,
                IsHighlighted = false
            };
            var backendXUnit = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = "xUnit",
                Priority = 215,
                IsHighlighted = false
            };
            var backendNUnit = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = "NUnit",
                Priority = 216,
                IsHighlighted = false
            };
            var backendMsTest = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Backend",
                Name = "MSTest",
                Priority = 217,
                IsHighlighted = false
            };

            var frontendAngular8Plus = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Frontend",
                Name = "Angular 8+",
                Priority = 301,
                IsHighlighted = true
            };
            var frontendVueJs = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Frontend",
                Name = "Vue.js",
                Priority = 302,
                IsHighlighted = true
            };
            var frontendAspNetCore = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Frontend",
                Name = "ASP.NET Core (Blazor)",
                Priority = 303,
                IsHighlighted = true
            };
            var frontendAspNet = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Frontend",
                Name = "ASP.NET",
                Priority = 304,
                IsHighlighted = true
            };
            var frontendJavaScript = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Frontend",
                Name = "JavaScript",
                Priority = 305,
                IsHighlighted = true
            };
            var frontendTypeScript = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Frontend",
                Name = "TypeScript",
                Priority = 306,
                IsHighlighted = true
            };
            var frontendHtml = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Frontend",
                Name = "HTML",
                Priority = 307,
                IsHighlighted = true
            };
            var frontendCss = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Frontend",
                Name = "CSS",
                Priority = 308,
                IsHighlighted = true
            };
            var frontendWpf = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Frontend",
                Name = "WPF",
                Priority = 309,
                IsHighlighted = true
            };
            var frontendXaml = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Frontend",
                Name = "XAML",
                Priority = 310,
                IsHighlighted = true
            };
            var frontendWinForms = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Frontend",
                Name = "WinForms",
                Priority = 311,
                IsHighlighted = false
            };

            var databaseMySql = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Database",
                Name = "MySQL",
                Priority = 401,
                IsHighlighted = true
            };
            var databaseMsSql = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Database",
                Name = "MS SQL",
                Priority = 402,
                IsHighlighted = true
            };
            var databaseMsSsas = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Database",
                Name = "MS SSAS",
                Priority = 403,
                IsHighlighted = true
            };
            var databaseCosmosDb = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Database",
                Name = "Cosmos DB",
                Priority = 404,
                IsHighlighted = true
            };
            var databaseDynamoDb = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Database",
                Name = "Dynamo DB",
                Priority = 405,
                IsHighlighted = true
            };
            var databaseRedis = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Database",
                Name = "Redis",
                Priority = 406,
                IsHighlighted = true
            };

            var toolsDocker = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Tools",
                Name = "Docker",
                Priority = 501,
                IsHighlighted = true
            };
            var toolsKubernetes = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Tools",
                Name = "Kubernetes",
                Priority = 502,
                IsHighlighted = true
            };
            var toolsAzureDevOps = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Tools",
                Name = "Azure DevOps",
                Priority = 503,
                IsHighlighted = true
            };
            var toolsGithubActions = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Tools",
                Name = "GitHub Actions",
                Priority = 504,
                IsHighlighted = true
            };
            var toolsAwsDevOps = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Tools",
                Name = "AWS DevOps",
                Priority = 505,
                IsHighlighted = true
            };
            var toolsJenkins = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Tools",
                Name = "Jenkins",
                Priority = 506,
                IsHighlighted = true
            };
            var toolsTeamCity = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Tools",
                Name = "TeamCity",
                Priority = 507,
                IsHighlighted = true
            };
            var toolsOkta = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Tools",
                Name = "OKTA",
                Priority = 508,
                IsHighlighted = true
            };
            var toolsJira = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Tools",
                Name = "Jira",
                Priority = 509,
                IsHighlighted = true
            };
            var toolsEsriArcGis = new Skill
            {
                Id = Guid.NewGuid(),
                SkillGroup = "Tools",
                Name = "Esri ArcGIS",
                Priority = 510,
                IsHighlighted = true
            };

            context.Skills.AddRange(
                cloudsAzure, cloudsAws, cloudsGcp, backendCSharp, backendDotNet, backendDotNetCore,
                backendAspNetCoreWebApi, backendAspNetWebApi, backendNodejs, backendExpressWebFramework,
                backendGoLang, backendGinWebFramework, backendPython3, backendFlaskWebFramework, backendWcf,
                backendEf, backendEfCore, backendXUnit, backendNUnit, backendMsTest, frontendAngular8Plus,
                frontendVueJs, frontendAspNetCore, frontendAspNet, frontendJavaScript, frontendTypeScript,
                frontendHtml, frontendCss, frontendWpf, frontendXaml, frontendWinForms, databaseMySql,
                databaseMsSql, databaseMsSsas, databaseCosmosDb, databaseDynamoDb, databaseRedis, toolsDocker,
                toolsKubernetes, toolsAzureDevOps, toolsAwsDevOps, toolsGithubActions, toolsJenkins, toolsTeamCity,
                toolsOkta, toolsJira, toolsEsriArcGis
            );

            var epamUs = new Experience
            {
                Id = Guid.NewGuid(),
                Title = "Lead Software Engineer",
                Company = "EPAM Systems",
                Location = "San Jose, CA, USA",
                TaskPerformed = new StringBuilder()
                    .AppendLine(
                        "Created Execution Compliance and Trade Surveillance System for analysis of trading activities to ensure regulatory compliance.")
                    .AppendLine(
                        "Engineered a Vue.js-based web dashboard for monitoring, analyzing, and visualizing data.")
                    .AppendLine(
                        "Designed and developed high-performance .NET Core backend services, resulting in a scalable and maintainable architecture.")
                    .AppendLine(
                        "Implemented an event-driven workflow that utilized Amazon SQS and AWS Lambdas, written in Python, to efficiently load and parse large data files, reducing processing times and increasing overall system throughput.")
                    .ToString(),
                StartDate = new DateOnly(2021, 10, 1),
                Skills =
                {
                    cloudsAws,
                    backendCSharp,
                    backendDotNetCore,
                    backendAspNetCoreWebApi,
                    backendPython3,
                    backendNUnit,
                    frontendVueJs,
                    frontendJavaScript,
                    frontendTypeScript,
                    frontendHtml,
                    frontendCss,
                    databaseMySql,
                    toolsDocker,
                    toolsAwsDevOps,
                    toolsJenkins,
                    toolsJira,
                }
            };


            var epamPoland = new Experience
            {
                Id = Guid.NewGuid(),
                Title = "Lead Software Engineer",
                Company = "EPAM Systems",
                Location = "Wroclaw, Poland",
                TaskPerformed = new StringBuilder()
                    .AppendLine(
                        "Designed and developed a cloud-native microservice-based system for managing insurance claims, underwriting, and reporting.")
                    .AppendLine(
                        "Created an intuitive self-service portal using Angular, improving customer satisfaction while reducing customer support inquiries.")
                    .AppendLine(
                        "Developed highly scalable and reliable RESTful microservices in .NET Core, resulting in improved efficiency and cost savings.")
                    .AppendLine(
                        "Implemented performance-critical internal services using GoLang, resulting in faster and more accurate claims processing.")
                    .AppendLine(
                        "Ensured high software quality with 80% code coverage and automated quality gates in CI/CD, reducing maintenance costs.")
                    .ToString(),
                StartDate = new DateOnly(2019, 4, 1),
                EndDate = new DateOnly(2021, 10, 1),
                Skills =
                {
                    cloudsAzure,
                    backendCSharp,
                    backendDotNetCore,
                    backendAspNetCoreWebApi,
                    backendGoLang,
                    backendGinWebFramework,
                    backendEfCore,
                    backendXUnit,
                    frontendAngular8Plus,
                    frontendTypeScript,
                    frontendJavaScript,
                    frontendHtml,
                    frontendCss,
                    databaseCosmosDb,
                    databaseRedis,
                    toolsAzureDevOps,
                    toolsOkta,
                    toolsJira,
                }
            };

            var creditSuisse = new Experience
            {
                Id = Guid.NewGuid(),
                Title = "Senior Software Engineer",
                Company = "Credit Suisse",
                Location = "Wroclaw, Poland",
                TaskPerformed = new StringBuilder()
                    .AppendLine(
                        "Created a high-performing desktop application for Credit Suisse front office to manage market risks in real time using WPF and C#.")
                    .AppendLine(
                        "Restructured an existing monolithic architecture into microservices, providing more flexibility and scalability while improving performance.")
                    .AppendLine(
                        "Implemented automated testing, reducing the likelihood of bugs and errors and increasing the overall reliability of the system.")
                    .AppendLine(
                        "Optimized the performance of the in-house distributed cache, leading to faster processing times and greater efficiency in C#.")
                    .ToString(),
                StartDate = new DateOnly(2015, 8, 1),
                EndDate = new DateOnly(2019, 3, 1),
                Skills =
                {
                    backendCSharp,
                    backendDotNetCore,
                    backendDotNet,
                    backendWcf,
                    frontendWpf,
                    frontendXaml,
                    databaseMsSql,
                    databaseMsSsas,
                    backendEfCore,
                    backendEf,
                    backendNUnit,
                    toolsTeamCity,
                    toolsJenkins,
                    toolsJira,
                }
            };

            var yandex = new Experience
            {
                Id = Guid.NewGuid(),
                Title = "Senior Software Engineer",
                Company = "Yandex",
                Location = "Moscow, Russia",
                TaskPerformed = new StringBuilder()
                    .AppendLine(
                        "Developed a payment system that streamlined the process of paying for lunch at nearby cafes and restaurants using the office access card (RFID tag), resulting in improved efficiency and convenience for employees.")
                    .AppendLine(
                        "Designed and developed a user-friendly personal page for employees, enabling them to view their transaction history and account balance.")
                    .AppendLine(
                        "Created a desktop application for administrators that simplified the process of managing employee accounts and generating reports.")
                    .ToString(),
                StartDate = new DateOnly(2014, 8, 1),
                EndDate = new DateOnly(2015, 8, 1),
                Skills =
                {
                    backendCSharp,
                    backendDotNet,
                    backendAspNetWebApi,
                    backendEf,
                    backendNUnit,
                    frontendAspNet,
                    frontendJavaScript,
                    frontendHtml,
                    frontendCss,
                    frontendWpf,
                    frontendXaml,
                    databaseMsSql,
                    toolsTeamCity,
                    toolsJira,
                }
            };

            var gollard = new Experience
            {
                Id = Guid.NewGuid(),
                Title = "Software Engineer",
                Company = "Gollard",
                Location = "Moscow, Russia",
                TaskPerformed = new StringBuilder()
                    .AppendLine(
                        "Created a GIS desktop app for energy distribution company handling grids, stations, and facilities, improving overall operational efficiency.")
                    .AppendLine(
                        "Enabled real-time tracking of service transport location and engine state, enhancing the company's logistical capabilities.")
                    .AppendLine(
                        "Implemented an alerting system that utilizes biometric camera data and sensor events, increasing the company's security posture.")
                    .ToString(),
                StartDate = new DateOnly(2013, 6, 1),
                EndDate = new DateOnly(2014, 7, 1),
                Skills =
                {
                    backendCSharp,
                    backendDotNet,
                    backendAspNetWebApi,
                    backendWcf,
                    backendNUnit,
                    frontendWpf,
                    frontendXaml,
                    databaseMsSql,
                    databaseMySql,
                    toolsEsriArcGis,
                    toolsTeamCity,
                    toolsJira,
                }
            };

            var sgc = new Experience
            {
                Id = Guid.NewGuid(),
                Title = "Software Engineer",
                Company = "SGC",
                Location = "Moscow, Russia",
                TaskPerformed = new StringBuilder()
                    .AppendLine(
                        "Developed software that composes accurate construction cost estimates, which resulted in a 25% reduction in estimate preparation time.")
                    .AppendLine(
                        "Improved software flexibility and saved valuable time by adding the ability to convert estimates from other well-known systems.")
                    .AppendLine(
                        "Streamlined report creation process by enabling final estimate result export to various formats, providing customization options for users.")
                    .ToString(),
                StartDate = new DateOnly(2012, 7, 1),
                EndDate = new DateOnly(2013, 6, 1),
                Skills =
                {
                    backendCSharp,
                    backendDotNet,
                    backendMsTest,
                    frontendWpf,
                    frontendXaml,
                    databaseMsSql,
                }
            };

            var poStart = new Experience
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
                EndDate = new DateOnly(2012, 6, 1),
                Skills = { backendCSharp, backendDotNet, frontendWinForms, databaseMsSql }
            };

            context.Experiences.AddRange(epamUs, epamPoland, creditSuisse, yandex, gollard, sgc, poStart);

            await context.SaveChangesAsync();
        }
    }
}
