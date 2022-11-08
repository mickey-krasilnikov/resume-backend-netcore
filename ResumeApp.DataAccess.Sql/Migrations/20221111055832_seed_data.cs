using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ResumeApp.DataAccess.Sql.Migrations
{
	/// <inheritdoc />
	public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Resumes",
                columns: new[] { "Id", "FirstName", "LastName", "Summary", "Title" },
                values: new object[] { 1L, "Mikhail", "Krasilnikov", "12+ years of professional programming experience with consistently increasing responsibilities in the design and development of commercial applications on different platforms and environments \nCertified Cloud Solution Architect (Azure, GCP, AWS) \nExperienced as a Team Leader \nInvolved in full Software Development Life Cycle (SDLC)", "Lead Software Engineer" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "ExpirationDate", "IssueDate", "Issuer", "Name", "ResumeId", "VerificationUrl" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "Azure Solutions Architect Expert", 1L, "https://www.credly.com/badges/42f9be70-0b40-4bb0-8256-bd9d573e36af/public_url" },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", "Professional Cloud Architect", 1L, "https://www.credential.net/786961ad-0225-4bb0-883a-3c2feceb5174" },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon", "AWS Certified Solutions Architect Associate", 1L, "https://www.credly.com/badges/dc95ff2a-12d8-4816-91b2-a9292ae5df85/public_url" },
                    { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "DevOps Engineer Expert", 1L, "https://www.credly.com/badges/2d29613e-7c7e-481d-aba3-842b409fecd7/public_url" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Key", "ResumeId", "Value" },
                values: new object[,]
                {
                    { "Accredible", 1L, "https://www.credential.net/profile/mikhailkrasilnikov328966/wallet" },
                    { "Credly", 1L, "https://www.credly.com/users/mickey-krasilnikov/badges" },
                    { "Email", 1L, "mickey.krasilnikov@gmail.com" },
                    { "LinkedIn", 1L, "https://www.linkedin.com/in/mickeykrasilnikov/" },
                    { "Location", 1L, "Sunnyvale, CA, 94085" },
                    { "Phone", 1L, "+1(408)480-3600" }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Degree", "EndDate", "FieldOfStudy", "Name", "ResumeId", "StartDate", "Url" },
                values: new object[] { 1L, "Bachelor's degree", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Design and technology of radio electronic devices", "Penza State University", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://international.pnzgu.ru/" });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Company", "EndDate", "ResumeId", "StartDate", "Title" },
                values: new object[,]
                {
                    { 1L, "EPAM Systems", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lead Software Engineer" },
                    { 2L, "Credit Suisse", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Front Office Risk System Developer (AVP) (Senior Software Engineer)" },
                    { 3L, "SINTEGRO SOFT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Senior Software Engineer" },
                    { 4L, "Gollard", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer" },
                    { 5L, "SGC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer" },
                    { 6L, "Research and Production Center 'Start'", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "AdditionalInfo", "Name", "ResumeId", "SkillGroup" },
                values: new object[,]
                {
                    { 1L, ".Net Core, .Net", "C#", 1L, "Programming Languages/Backend" },
                    { 2L, "Gin", "GoLang", 1L, "Programming Languages/Backend" },
                    { 3L, "Node.js", "Javascript", 1L, "Programming Languages/Backend" },
                    { 4L, "FastAPI", "Python", 1L, "Programming Languages/Backend" },
                    { 5L, null, "Angular", 1L, "Programming Languages/Frontend" },
                    { 6L, null, "Vue.js", 1L, "Programming Languages/Frontend" },
                    { 7L, null, "JavaScript", 1L, "Programming Languages/Frontend" },
                    { 8L, null, "TypeScript", 1L, "Programming Languages/Frontend" },
                    { 9L, null, "HTML", 1L, "Programming Languages/Frontend" },
                    { 10L, null, "CSS", 1L, "Programming Languages/Frontend" },
                    { 11L, "MS SQL", "T-SQL", 1L, "Programming Languages/Database/SQL" },
                    { 12L, "MySQL", "SQL/PSM", 1L, "Programming Languages/Database/SQL" },
                    { 13L, "PostgreSQL, Oracle", "PL-SQL", 1L, "Programming Languages/Database/SQL" },
                    { 14L, null, "MongoDB", 1L, "Programming Languages/Database/NoSQL" },
                    { 15L, null, "Redis", 1L, "Programming Languages/Database/NoSQL" },
                    { 16L, null, "CosmosDB", 1L, "Programming Languages/Database/NoSQL" },
                    { 17L, null, "DynamoDB", 1L, "Programming Languages/Database/NoSQL" },
                    { 18L, null, "BigTable", 1L, "Programming Languages/Database/NoSQL" },
                    { 19L, null, "Docker", 1L, "Container Services" },
                    { 20L, null, "Docker Swarm", 1L, "Container Services" },
                    { 21L, null, "Kubernetes", 1L, "Container Services" },
                    { 22L, null, "Azure DevOps", 1L, "CI/CD" },
                    { 23L, null, "GitHub Actions", 1L, "CI/CD" },
                    { 24L, null, "AWS CodePipeline", 1L, "CI/CD" },
                    { 25L, null, "Octopus", 1L, "CI/CD" },
                    { 26L, null, "Jenkins", 1L, "CI/CD" },
                    { 27L, null, "TeamCity", 1L, "CI/CD" },
                    { 28L, null, "JIRA", 1L, "Bug Tracking" },
                    { 29L, null, "Azure DevOps", 1L, "Bug Tracking" },
                    { 30L, null, "GIT", 1L, "Source Control" },
                    { 31L, null, "SVN", 1L, "Source Control" },
                    { 32L, null, "Windows", 1L, "OS" },
                    { 33L, null, "MacOS", 1L, "OS" },
                    { 34L, null, "Ubuntu", 1L, "OS" },
                    { 35L, null, "Azure", 1L, "Cloud" },
                    { 36L, null, "AWS", 1L, "Cloud" },
                    { 37L, null, "GCP", 1L, "Cloud" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Client", "EndDate", "Envirnment", "ExperienceId", "ProjectRoles", "StartDate", "TaskPerformed" },
                values: new object[,]
                {
                    { 1L, "Broadridge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET Core 6.0, Vue.js, Python 3.7, AWS, AWS Lambda, AWS S3, AWS Beanstalk, AWS EC2, AWS Code Commit, AWS Code Build, AWS Code Deploy, AWS Code Pipeline, Docker, AWS RDS, GIT", 1L, "Key Developer, Team Lead", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2L, "ElipsLife", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET Core 6.0Angular 13Go LangAzureAzure DevOpsOctopusOKTADockerCosmos DBRedisMS SQLGIT", 1L, "Key Developer, Team Lead", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Designed microservice-based hybrid-cloud solution architecture for multi-role self-service portal for managing insurance claims + underwriting + and broker reports.Designed and developed microservices following a RESTful approach and applying best practices. • Covered code with unit and contract tests and maintained code coverage on 80%.Configured CI/CD pipelines and established automated quality gates on different stages.Mentored new joiners and supported them during the ramp-up period.Performed systematic knowledge transfer to the client support team + including the creation of visual documentation. Introduced and ensured the development team follows the very best engineering practices (with respect to various limitations on the client side)." },
                    { 3L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET Core 2.1, .NET 4.6, WPF, WCF, EF, MS SQL, MS SSAS, TeamCity, Jira, Confluence, Splunk, GIT", 2L, "Key Developer, Tech Lead", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maintained Risk Management System for Credit Suisse Front Office and developed new modules. Improved performance and decreased memory usage in CS in-house distributed cache. Splatted monolith server-side architecture to microservices. Analyzed and arranged requirements with traders + BAU team and QA. Supported worldwide users as a part of the SL3 team. Administrated CI/CD on TeamCity. Documented design decisions and usage examples. Mentored new joiners." },
                    { 4L, "Yandex", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET 4.5, ASP.NET MVC 5, ASP.NET Web API, WPF, MS SQL, EF, TFS, WIX, GIT", 3L, "Key Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Participated in the development of the system that helps organize corporate bonuses + such as meals + mobile phones + fitness + transportation + etc.Developed user personal page that contains account balance and transaction history. Developed desktop administration systems for corporate bonus managers.Documented design decisions + component APIs and usage examples.Participated in the software integration process." },
                    { 5L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET 4.5, WPF, WCF, ASP.NET Web API, Esri ArcGIS, MS SQL, MySQL, GitLab, WIX, GIT", 4L, "Key Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Participated in the development of desktop GIS application for the power distribution company dealing with electrical grids, stations and facilities on the map.Implemented a feature that allows monitoring the service transport on the map in real-timeIntroduced the possibility to view video streams from the cameras marked on the map.Participated in the development of the solution to maintain security and safety of the buildings and areas using cameras and different types of sensors.Implemented an alerting system that works based on the biometric data from the cameras or events from the sensors." },
                    { 6L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET 4.0, WPF, SOAP, MS SQL, WIX, SVN", 5L, "Key Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developed software for composing estimates to determine the cost of construction.Integrated with other well-known systems available on the market for composing estimates." },
                    { 7L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET 3.5, WinForms, SOAP, MS SQL, SVN", 6L, "Key Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developed software for designing micro boards and creating a mask for interacting with third-party equipment for printing this kind of product." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Key",
                keyValue: "Accredible");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Key",
                keyValue: "Credly");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Key",
                keyValue: "Email");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Key",
                keyValue: "LinkedIn");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Key",
                keyValue: "Location");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Key",
                keyValue: "Phone");

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1L);
        }
    }
}
