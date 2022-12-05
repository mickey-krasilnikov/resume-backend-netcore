using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ResumeApp.DataAccess.Sql.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Resumes",
                columns: new[] { "Id", "FirstName", "LastName", "Summary", "Title" },
                values: new object[] { new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Mikhail", "Krasilnikov", "12+ years of professional programming experience with consistently increasing responsibilities in the design and development of commercial applications on different platforms and environments \nCertified Cloud Solution Architect (Azure, GCP, AWS) \nExperienced as a Team Leader \nInvolved in full Software Development Life Cycle (SDLC)", "Lead Software Engineer" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "ExpirationDate", "IssueDate", "Issuer", "Name", "ResumeId", "VerificationUrl" },
                values: new object[,]
                {
                    { new Guid("85ad96eb-09d9-49ff-9f43-03ba5ee9bbc2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", "Professional Cloud Architect", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "https://www.credential.net/786961ad-0225-4bb0-883a-3c2feceb5174" },
                    { new Guid("8a1079de-f850-47e5-9ffd-2bd42609e2d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon", "AWS Certified Solutions Architect Associate", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "https://www.credly.com/badges/dc95ff2a-12d8-4816-91b2-a9292ae5df85/public_url" },
                    { new Guid("a96937f6-9a00-44c8-a216-de6858efed75"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "DevOps Engineer Expert", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "https://www.credly.com/badges/2d29613e-7c7e-481d-aba3-842b409fecd7/public_url" },
                    { new Guid("f0a5c173-10e6-4fa6-91c4-8c31adcb0c34"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "Azure Solutions Architect Expert", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "https://www.credly.com/badges/42f9be70-0b40-4bb0-8256-bd9d573e36af/public_url" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Key", "ResumeId", "Value" },
                values: new object[,]
                {
                    { "Accredible", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "https://www.credential.net/profile/mikhailkrasilnikov328966/wallet" },
                    { "Credly", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "https://www.credly.com/users/mickey-krasilnikov/badges" },
                    { "Email", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "mickey.krasilnikov@gmail.com" },
                    { "LinkedIn", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "https://www.linkedin.com/in/mickeykrasilnikov/" },
                    { "Location", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Sunnyvale, CA, 94085" },
                    { "Phone", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "+1(408)480-3600" }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Degree", "EndDate", "FieldOfStudy", "Name", "ResumeId", "StartDate", "Url" },
                values: new object[] { new Guid("c60ecfd2-bd9a-4aba-8b41-7235c78cec03"), "Bachelor's degree", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Design and technology of radio electronic devices", "Penza State University", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://international.pnzgu.ru/" });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Company", "EndDate", "IsCurrentCompany", "ResumeId", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("126533a6-23c5-4fd8-8c9c-f332e2da0173"), "Research and Production Center 'Start'", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer" },
                    { new Guid("30509bff-4c5d-41f0-ae29-852b51dd07b2"), "SINTEGRO SOFT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Senior Software Engineer" },
                    { new Guid("88ddacf2-141f-4f28-9740-7f4477eb5cf2"), "Gollard", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer" },
                    { new Guid("9e7b2051-8774-47c3-b826-7d7dfb34bf6d"), "EPAM Systems", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lead Software Engineer" },
                    { new Guid("9ef842b2-26e0-47db-9906-45bf5c9aa12d"), "SGC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer" },
                    { new Guid("ebae285d-cde6-4cc6-a4d0-fd40966bf331"), "Credit Suisse", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Front Office Risk System Developer (AVP) (Senior Software Engineer)" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "AdditionalInfo", "Name", "ResumeId", "SkillGroup" },
                values: new object[,]
                {
                    { new Guid("088736fb-df50-4fc3-a131-c92c23192969"), "FastAPI", "Python", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Backend" },
                    { new Guid("1128cef7-65ba-4699-b917-dedb135713d6"), null, "Ubuntu", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "OS" },
                    { new Guid("1467bc6b-d0b2-451c-8640-be2c06c1aa05"), null, "Docker Swarm", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Container Services" },
                    { new Guid("19bbef85-71ee-414d-beee-acc6eb18f10f"), null, "JIRA", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Bug Tracking" },
                    { new Guid("1a5e5d9d-3d21-42fd-96e7-84fa8cca13fa"), "PostgreSQL, Oracle", "PL-SQL", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Database/SQL" },
                    { new Guid("1ca6a89f-b808-4d6e-adfc-90509c750c45"), null, "Azure", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Cloud" },
                    { new Guid("1e673657-545a-477b-92cc-e2b2c99d72f5"), null, "TypeScript", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Frontend" },
                    { new Guid("280e6565-d075-418b-ad16-f354c426d5e4"), null, "Vue.js", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Frontend" },
                    { new Guid("32bdb763-b939-4d4c-a266-6dc9d2a60b06"), null, "Kubernetes", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Container Services" },
                    { new Guid("363c11a3-df91-489c-ab75-50c2d69cf3a0"), null, "GitHub Actions", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "CI/CD" },
                    { new Guid("4106fd00-8048-460e-8f1d-cf47d38042d5"), null, "TeamCity", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "CI/CD" },
                    { new Guid("41e824af-bcaf-40c9-9884-ede94b0dcfec"), null, "JavaScript", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Frontend" },
                    { new Guid("45b62247-f738-48f6-8339-c0c8e57f6eb5"), null, "BigTable", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Database/NoSQL" },
                    { new Guid("4bda5608-4160-4a65-a874-b672b248cd1f"), null, "Angular", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Frontend" },
                    { new Guid("5d2b12df-fee4-48fa-afde-07f5d841674e"), null, "MacOS", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "OS" },
                    { new Guid("669e70e0-4a36-4864-8a7c-31dc78c1fa94"), null, "MongoDB", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Database/NoSQL" },
                    { new Guid("6bedf9e7-625d-454c-b51e-35871fc2fbe8"), null, "Redis", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Database/NoSQL" },
                    { new Guid("70bf6a37-9cec-4554-824c-08b66e6650c6"), null, "Jenkins", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "CI/CD" },
                    { new Guid("73200eac-f79b-4a68-abd7-785bc9b4c42b"), null, "AWS", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Cloud" },
                    { new Guid("7b3fe737-ee87-4939-9d24-13f50b6956c5"), null, "Azure DevOps", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "CI/CD" },
                    { new Guid("87b0c15c-b4a5-41e4-9346-c5fdeba4affa"), "Gin", "GoLang", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Backend" },
                    { new Guid("9170bfed-4b5c-4583-aacc-c596324249cd"), null, "Octopus", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "CI/CD" },
                    { new Guid("91968550-e11e-45b1-bd35-e628c6898214"), "Node.js", "Javascript", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Backend" },
                    { new Guid("91a03baa-03c4-4d53-8e75-f555ff64ee6b"), null, "SVN", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Source Control" },
                    { new Guid("9d808f6e-92be-4acf-95c3-d89c66d4af36"), null, "CosmosDB", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Database/NoSQL" },
                    { new Guid("9e48dff5-2bde-4d84-bbec-ea8e5c10f5e0"), "MySQL", "SQL/PSM", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Database/SQL" },
                    { new Guid("9f7db796-8d0b-4c9d-a50d-5535273dafc1"), null, "DynamoDB", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Database/NoSQL" },
                    { new Guid("a1102dc4-d1af-4e78-be19-7a2f20bb77b6"), null, "AWS CodePipeline", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "CI/CD" },
                    { new Guid("acda6dfa-e4f5-4c6a-9a9f-e43d36925eb7"), null, "GCP", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Cloud" },
                    { new Guid("ad9f085b-2675-4bce-be22-f6158130b734"), null, "GIT", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Source Control" },
                    { new Guid("b2f4335f-3ff6-4ba8-8144-4d9d89fb42e2"), null, "Docker", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Container Services" },
                    { new Guid("bb571259-c6bd-4425-b4b8-1e44261ef599"), ".Net Core, .Net", "C#", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Backend" },
                    { new Guid("d7833db0-6942-435b-a0c8-97a6beaccbe2"), null, "Windows", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "OS" },
                    { new Guid("d7951bcb-29b0-44f2-a044-3f48e70a4ab1"), "MS SQL", "T-SQL", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Database/SQL" },
                    { new Guid("d9dbe63f-09c8-48ea-b87b-989aa5f3cdc6"), null, "CSS", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Frontend" },
                    { new Guid("e04fd530-1420-43bd-9e16-42be22d6ff29"), null, "HTML", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Programming Languages/Frontend" },
                    { new Guid("eca45e48-2c5c-4edb-8349-60282302d68c"), null, "Azure DevOps", new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"), "Bug Tracking" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Client", "EndDate", "Environment", "ExperienceId", "IsCurrentProject", "ProjectRoles", "StartDate", "TaskPerformed" },
                values: new object[,]
                {
                    { new Guid("39e39a57-b90e-4ca9-8724-2e103e5fe35f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET 4.5, WPF, WCF, ASP.NET Web API, Esri ArcGIS, MS SQL, MySQL, GitLab, WIX, GIT", new Guid("88ddacf2-141f-4f28-9740-7f4477eb5cf2"), false, "Key Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Participated in the development of desktop GIS application for the power distribution company dealing with electrical grids, stations and facilities on the map.Implemented a feature that allows monitoring the service transport on the map in real-timeIntroduced the possibility to view video streams from the cameras marked on the map.Participated in the development of the solution to maintain security and safety of the buildings and areas using cameras and different types of sensors.Implemented an alerting system that works based on the biometric data from the cameras or events from the sensors." },
                    { new Guid("4f7ba226-dca3-4f6a-8587-ebceef364b7d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET 4.0, WPF, SOAP, MS SQL, WIX, SVN", new Guid("9ef842b2-26e0-47db-9906-45bf5c9aa12d"), false, "Key Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developed software for composing estimates to determine the cost of construction.Integrated with other well-known systems available on the market for composing estimates." },
                    { new Guid("82f125db-50d1-499b-a00d-96a953d96918"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET Core 2.1, .NET 4.6, WPF, WCF, EF, MS SQL, MS SSAS, TeamCity, Jira, Confluence, Splunk, GIT", new Guid("ebae285d-cde6-4cc6-a4d0-fd40966bf331"), false, "Key Developer, Tech Lead", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maintained Risk Management System for Credit Suisse Front Office and developed new modules. Improved performance and decreased memory usage in CS in-house distributed cache. Splatted monolith server-side architecture to microservices. Analyzed and arranged requirements with traders + BAU team and QA. Supported worldwide users as a part of the SL3 team. Administrated CI/CD on TeamCity. Documented design decisions and usage examples. Mentored new joiners." },
                    { new Guid("83c9f60f-673e-4e80-9e9c-b65f6a34fee2"), "ElipsLife", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET Core 6.0Angular 13Go LangAzureAzure DevOpsOctopusOKTADockerCosmos DBRedisMS SQLGIT", new Guid("9e7b2051-8774-47c3-b826-7d7dfb34bf6d"), false, "Key Developer, Team Lead", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Designed microservice-based hybrid-cloud solution architecture for multi-role self-service portal for managing insurance claims + underwriting + and broker reports.Designed and developed microservices following a RESTful approach and applying best practices. • Covered code with unit and contract tests and maintained code coverage on 80%.Configured CI/CD pipelines and established automated quality gates on different stages.Mentored new joiners and supported them during the ramp-up period.Performed systematic knowledge transfer to the client support team + including the creation of visual documentation. Introduced and ensured the development team follows the very best engineering practices (with respect to various limitations on the client side)." },
                    { new Guid("86f3fb29-4dd8-4696-8fc6-7a90d64736ce"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET 3.5, WinForms, SOAP, MS SQL, SVN", new Guid("126533a6-23c5-4fd8-8c9c-f332e2da0173"), false, "Key Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developed software for designing micro boards and creating a mask for interacting with third-party equipment for printing this kind of product." },
                    { new Guid("beddb152-6ad7-4f70-b554-7a72e04227fd"), "Yandex", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET 4.5, ASP.NET MVC 5, ASP.NET Web API, WPF, MS SQL, EF, TFS, WIX, GIT", new Guid("30509bff-4c5d-41f0-ae29-852b51dd07b2"), false, "Key Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Participated in the development of the system that helps organize corporate bonuses + such as meals + mobile phones + fitness + transportation + etc.Developed user personal page that contains account balance and transaction history. Developed desktop administration systems for corporate bonus managers.Documented design decisions + component APIs and usage examples.Participated in the software integration process." },
                    { new Guid("cb2bd704-e700-4d53-b666-4d239f184ac5"), "Broadridge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET Core 6.0, Vue.js, Python 3.7, AWS, AWS Lambda, AWS S3, AWS Beanstalk, AWS EC2, AWS Code Commit, AWS Code Build, AWS Code Deploy, AWS Code Pipeline, Docker, AWS RDS, GIT", new Guid("9e7b2051-8774-47c3-b826-7d7dfb34bf6d"), false, "Key Developer, Team Lead", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("85ad96eb-09d9-49ff-9f43-03ba5ee9bbc2"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("8a1079de-f850-47e5-9ffd-2bd42609e2d5"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("a96937f6-9a00-44c8-a216-de6858efed75"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("f0a5c173-10e6-4fa6-91c4-8c31adcb0c34"));

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
                keyValue: new Guid("c60ecfd2-bd9a-4aba-8b41-7235c78cec03"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("39e39a57-b90e-4ca9-8724-2e103e5fe35f"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("4f7ba226-dca3-4f6a-8587-ebceef364b7d"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("82f125db-50d1-499b-a00d-96a953d96918"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("83c9f60f-673e-4e80-9e9c-b65f6a34fee2"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("86f3fb29-4dd8-4696-8fc6-7a90d64736ce"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("beddb152-6ad7-4f70-b554-7a72e04227fd"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("cb2bd704-e700-4d53-b666-4d239f184ac5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("088736fb-df50-4fc3-a131-c92c23192969"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1128cef7-65ba-4699-b917-dedb135713d6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1467bc6b-d0b2-451c-8640-be2c06c1aa05"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("19bbef85-71ee-414d-beee-acc6eb18f10f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1a5e5d9d-3d21-42fd-96e7-84fa8cca13fa"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1ca6a89f-b808-4d6e-adfc-90509c750c45"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1e673657-545a-477b-92cc-e2b2c99d72f5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("280e6565-d075-418b-ad16-f354c426d5e4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("32bdb763-b939-4d4c-a266-6dc9d2a60b06"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("363c11a3-df91-489c-ab75-50c2d69cf3a0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4106fd00-8048-460e-8f1d-cf47d38042d5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("41e824af-bcaf-40c9-9884-ede94b0dcfec"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("45b62247-f738-48f6-8339-c0c8e57f6eb5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4bda5608-4160-4a65-a874-b672b248cd1f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5d2b12df-fee4-48fa-afde-07f5d841674e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("669e70e0-4a36-4864-8a7c-31dc78c1fa94"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6bedf9e7-625d-454c-b51e-35871fc2fbe8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("70bf6a37-9cec-4554-824c-08b66e6650c6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("73200eac-f79b-4a68-abd7-785bc9b4c42b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7b3fe737-ee87-4939-9d24-13f50b6956c5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("87b0c15c-b4a5-41e4-9346-c5fdeba4affa"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9170bfed-4b5c-4583-aacc-c596324249cd"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("91968550-e11e-45b1-bd35-e628c6898214"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("91a03baa-03c4-4d53-8e75-f555ff64ee6b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9d808f6e-92be-4acf-95c3-d89c66d4af36"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9e48dff5-2bde-4d84-bbec-ea8e5c10f5e0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9f7db796-8d0b-4c9d-a50d-5535273dafc1"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a1102dc4-d1af-4e78-be19-7a2f20bb77b6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("acda6dfa-e4f5-4c6a-9a9f-e43d36925eb7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ad9f085b-2675-4bce-be22-f6158130b734"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b2f4335f-3ff6-4ba8-8144-4d9d89fb42e2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("bb571259-c6bd-4425-b4b8-1e44261ef599"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d7833db0-6942-435b-a0c8-97a6beaccbe2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d7951bcb-29b0-44f2-a044-3f48e70a4ab1"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d9dbe63f-09c8-48ea-b87b-989aa5f3cdc6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e04fd530-1420-43bd-9e16-42be22d6ff29"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("eca45e48-2c5c-4edb-8349-60282302d68c"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("126533a6-23c5-4fd8-8c9c-f332e2da0173"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("30509bff-4c5d-41f0-ae29-852b51dd07b2"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("88ddacf2-141f-4f28-9740-7f4477eb5cf2"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("9e7b2051-8774-47c3-b826-7d7dfb34bf6d"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("9ef842b2-26e0-47db-9906-45bf5c9aa12d"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("ebae285d-cde6-4cc6-a4d0-fd40966bf331"));

            migrationBuilder.DeleteData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: new Guid("84b91e21-e998-464e-b8ba-c6be6c16b3be"));
        }
    }
}
