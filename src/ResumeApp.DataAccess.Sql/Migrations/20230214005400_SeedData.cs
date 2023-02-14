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
                table: "Certifications",
                columns: new[] { "Id", "ExpirationDate", "IssueDate", "Issuer", "Name", "VerificationUrl" },
                values: new object[,]
                {
                    { new Guid("1c609b35-f19b-4366-90eb-f44440fa26e8"), new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", "Professional Cloud Architect", "https://www.credential.net/786961ad-0225-4bb0-883a-3c2feceb5174" },
                    { new Guid("62d2fc22-9881-4bc0-9cdd-4c70a4feb65e"), new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon", "AWS Certified Solutions Architect Associate", "https://www.credly.com/badges/dc95ff2a-12d8-4816-91b2-a9292ae5df85" },
                    { new Guid("691ecc14-6081-4568-af4b-b43364c0c6eb"), new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "Azure Solutions Architect Expert", "https://www.credly.com/badges/8ea21901-34c7-4cb4-bc48-71e0c5cf3e85" },
                    { new Guid("7b16b9a1-18d2-46fb-9c31-d1c44ad8ee5f"), new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "DevOps Engineer Expert", "https://www.credly.com/badges/eaedb35f-5ea9-45b2-b551-acad69b94488" },
                    { new Guid("b3099c2b-9ea7-4e0b-8dc1-661aa8df665a"), new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "Azure Developer Associate", "https://www.credly.com/badges/49ab14ad-ffe5-47ae-b3d1-9d29b00ef4dc" },
                    { new Guid("e6b50372-d4e8-4d5e-ae05-fe8d9394c586"), new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", "Associate Cloud Engineer", "https://www.credential.net/f4054913-d10c-4cd4-89cb-e286f00de2ae" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Key", "Link", "Value" },
                values: new object[,]
                {
                    { new Guid("02a4cae9-d308-4f64-b007-a8c0ed0b33f9"), "Email", "mailto:your_email", "Mickey.Krasilnikov@gmail.com" },
                    { new Guid("0d07ede7-68cf-45f3-af42-74c2be4c3696"), "Whatsapp", "https://wa.me/+14084803600", "+1(408)480-3600" },
                    { new Guid("5319715d-9d2b-4453-86dd-3339b6dfdcd7"), "Credly", "https://www.credly.com/users/mickey-krasilnikov/badges", "@mickey-krasilnikov" },
                    { new Guid("700cb581-aea0-4bfd-9e01-d479b36cc979"), "Facebook", "https://www.facebook.com/mickey.krasilnikov", "@mickey.krasilnikov" },
                    { new Guid("93039dbe-5c88-4fb6-9dc4-aa4037cb725c"), "Accredible", "https://www.credential.net/profile/mikhailkrasilnikov328966/wallet", "@mikhailkrasilnikov328966" },
                    { new Guid("a44a818a-47fb-4b31-b7c5-06e7d84221e5"), "Instagram", "https://www.instagram.com/mickey.krasilnikov", "@mickey.krasilnikov" },
                    { new Guid("a46aee19-f5cb-4c90-8150-9d7e8c276567"), "LinkedIn", "https://www.linkedin.com/in/mickeykrasilnikov", "@mickeykrasilnikov" },
                    { new Guid("aa60daa6-7474-416f-aaea-1df70aee2f5a"), "Telegram", "https://t.me/+14084803600", "+1(408)480-3600" },
                    { new Guid("b9a5e6ef-64ac-415c-bd98-3df641eebe1f"), "Github", "https://github.com/mickey-krasilnikov", "@mickey-krasilnikov" },
                    { new Guid("d4b0c82d-55e3-4ab4-bea1-11cd56635640"), "Twitter", "https://twitter.com/mickey_kras", "@mickey_kras" },
                    { new Guid("d74d843d-a55b-493a-ae1a-9d6d3121bf57"), "Location", "https://www.google.com/maps/place/Sunyvale%20CA%2094085/", "Sunyvale, CA, 94085" },
                    { new Guid("f85b7a75-1df7-481c-b8e3-f9413d19d6d5"), "Phone", "tel:+14084803600", "+14084803600" }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Degree", "EndDate", "FieldOfStudy", "Name", "StartDate", "Url" },
                values: new object[] { new Guid("d31a9a15-a883-46c7-a4f6-acd2e2da6ade"), "Bachelor's degree", new DateTime(2013, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Design and technology of radio electronic devices", "Penza State University", new DateTime(2006, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://international.pnzgu.ru/" });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Company", "EndDate", "Location", "StartDate", "TaskPerformed", "Title" },
                values: new object[,]
                {
                    { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), "Credit Suisse", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wroclaw, Poland", new DateTime(2015, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developed a risk management desktop application for the Credit Suisse front office using WPF and C#.\r\nConverted an existing backend monolithic architecture into microservices and implemented new RESTful Web APIs using .NET Core.\r\nMaintained and improved the performance of the in-house distributed cache written in C#.\r\nSupported worldwide users as a part of the SL3 team.\r\n", "Senior Software Engineer" },
                    { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), "EPAM Systems", null, "San Jose, CA, USA", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developed cloud-native Execution Compliance and Trade Surveillance System.\r\nDesigned and implemented a web dashboard for monitoring and analyzing using Vue.js.\r\nDeveloped backend services following a RESTful approach using.NET Core.\r\nImplemented event-driven workflow of loading and parsing large data files with Amazon SQS and AWS Lambdas written in Python.\r\n", "Lead Software Engineer" },
                    { new Guid("4a3d0a26-55dd-458e-a2d6-34be27f9466a"), "Research and Production Center 'Start'", new DateTime(2012, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penza, Russia", new DateTime(2010, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developed in-house CAD for designing microboards.\r\nImplemented functionality for printing photomasks of microboards using special equipment.\r\nAdded the possibility to import AutoCAD files.\r\n", "Software Engineer" },
                    { new Guid("4d99f5fe-c1e3-4008-8946-69324331ed01"), "SGC", new DateTime(2013, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moscow, Russia", new DateTime(2012, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developed software for composing estimates to determine the cost of construction.\r\nAdded functionality for converting files from other well-known systems for composing estimates available on the market.\r\nImplemented logic that allows exporting the final result to Excel, Word, etc.\r\n", "Software Engineer" },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), "EPAM Systems", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wroclaw, Poland", new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Designed and developed a cloud-native microservice-based system for managing insurance claims, underwriting, and reporting.\r\nDeveloped a web self-service portal using Angular, and RESTful Web APIs using .NET Core.\r\nImplemented performance-critical internal services using GoLang with Gin web framework.\r\nAchieved and maintained 80% code coverage by unit and contract tests, and established automated quality gates in CI/CD.\r\n", "Lead Software Engineer" },
                    { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), "Yandex", new DateTime(2015, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moscow, Russia", new DateTime(2014, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developed a payment system that allows employees to pay for lunch at nearby cafes and restaurants with the office access card (RFID tag)\r\nDeveloped a personal page for users, a desktop application for administrators, and payment service middleware.\r\nParticipated in the software integration process.\r\n", "Senior Software Engineer" },
                    { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), "Gollard", new DateTime(2014, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moscow, Russia", new DateTime(2013, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developed a desktop GIS application for an energy distribution company that deals with electrical grids, stations, and facilities.\r\nImplemented real-time tracking of service transport location and engine state.\r\nDeveloped an alerting system that uses biometric data from cameras and events from sensors.\r\n", "Software Engineer" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "SkillGroup" },
                values: new object[,]
                {
                    { new Guid("06c18dc9-80b6-494f-8bb0-a2cede682f9e"), "Esri ArcGIS", "Tools" },
                    { new Guid("0cc1df6b-654b-4037-b3f0-3c88c5c842fa"), "Entity Framework Core", "Tools" },
                    { new Guid("27deee5d-937a-4801-a028-97226a9d97d6"), "Entity Framework", "Tools" },
                    { new Guid("2f179910-d592-4b5c-82b8-7c0b7383fce7"), "Jenkins", "Tools" },
                    { new Guid("38bfe8d8-8498-45b0-bc6e-292ba75ded7b"), "ASP.NET", "Backend" },
                    { new Guid("45404f69-3e14-4107-8b5f-77dacbd1736c"), "C#", "Backend" },
                    { new Guid("48a6631b-2edc-45fd-b3fe-cdbbe624ce04"), "NUnit", "Tools" },
                    { new Guid("5498dd83-f3db-49f3-91b8-0c12fdd9e33f"), "MySQL", "Database" },
                    { new Guid("595c5389-0d7a-446a-bcaa-f8ce30e5152a"), "Azure", "Clouds" },
                    { new Guid("5c5e078a-4826-4c07-a75c-5f770a134a69"), "JavaScript", "Frontend" },
                    { new Guid("5f1e1abf-d068-4d06-b176-698c2c6fd38d"), "xUnit", "Tools" },
                    { new Guid("63ed5300-cebd-4167-b383-348c98695ee5"), "XAML", "Frontend" },
                    { new Guid("6b028ae2-734d-453a-8ecb-f37a7202c1a2"), "AWS", "Clouds" },
                    { new Guid("71977b8e-458e-4fd1-bdac-c608325777d9"), "WinForms", "Frontend" },
                    { new Guid("7861c16e-d82f-4527-8914-175384a7272f"), "Cosmos DB", "Database" },
                    { new Guid("837daf5d-2d2c-4bde-a944-7fd722a3a5d9"), "Vue.js", "Frontend" },
                    { new Guid("85e045bf-f5d8-428a-9ea7-4403b8459176"), "Azure DevOps", "Tools" },
                    { new Guid("8c277707-ef89-48c7-9e11-b3da5a2f55d2"), ".NET Core", "Backend" },
                    { new Guid("9dd966f9-47d0-4c8e-aee4-13ebeaf24c02"), "MS SQL", "Database" },
                    { new Guid("b2545caa-91d4-4363-b48c-3a9685d90725"), "WPF", "Frontend" },
                    { new Guid("b5a6230a-be9f-4197-8169-6a6db0cebeaa"), "Gin Web Framework", "Backend" },
                    { new Guid("b6988db9-10e0-4bad-9b1d-bd2ef54bdc62"), "Python3", "Backend" },
                    { new Guid("b7b6a8ae-3713-4427-a2c2-8b78258ab802"), "OKTA", "Tools" },
                    { new Guid("c2430241-81bd-4ca8-8f52-e0739e43877d"), "WCF", "Backend" },
                    { new Guid("c546ed63-b96a-4f78-8562-cd55b6562a68"), "HTML", "Frontend" },
                    { new Guid("ce64e8ef-238d-4e65-8a7e-c9564c9340bc"), "TeamCity", "Tools" },
                    { new Guid("d0f0c657-3ab6-41a2-9303-18cab0a8dfe6"), "TypeScript", "Frontend" },
                    { new Guid("d2b44131-4f80-4a59-a60d-4828e3f90866"), "Docker", "Tools" },
                    { new Guid("d494d01f-a939-48db-bcc2-88a3021a8d06"), "MS SSAS", "Database" },
                    { new Guid("d573787a-8021-48f7-acbc-0f16fc7ecb80"), "Redis", "Database" },
                    { new Guid("d6e10246-2b24-4a87-b6b7-aae4e8ffa04d"), "MSTest", "Tools" },
                    { new Guid("ed19e565-ad16-427d-9965-d8122f88e635"), "CSS", "Frontend" },
                    { new Guid("edf93b3f-e56a-4e37-8910-70b59655efd9"), "GCP", "Clouds" },
                    { new Guid("f64a7f5a-1ed0-4bed-a39e-8a952ad295c4"), "ASP.NET Core", "Backend" },
                    { new Guid("f71e817d-978c-4c3c-b43b-212b658b9861"), ".NET", "Backend" },
                    { new Guid("f90c4279-a314-4960-8bf7-da6606cee19c"), "GoLang", "Backend" },
                    { new Guid("fdf6c906-5b27-40a8-bfd3-c20d9d2a62cc"), "Angular 8+", "Frontend" }
                });

            migrationBuilder.InsertData(
                table: "SkillExperienceMappings",
                columns: new[] { "ExperienceId", "SkillId" },
                values: new object[,]
                {
                    { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("06c18dc9-80b6-494f-8bb0-a2cede682f9e") },
                    { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("0cc1df6b-654b-4037-b3f0-3c88c5c842fa") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("0cc1df6b-654b-4037-b3f0-3c88c5c842fa") },
                    { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("27deee5d-937a-4801-a028-97226a9d97d6") },
                    { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("27deee5d-937a-4801-a028-97226a9d97d6") },
                    { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("2f179910-d592-4b5c-82b8-7c0b7383fce7") },
                    { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("2f179910-d592-4b5c-82b8-7c0b7383fce7") },
                    { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("38bfe8d8-8498-45b0-bc6e-292ba75ded7b") },
                    { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("38bfe8d8-8498-45b0-bc6e-292ba75ded7b") },
                    { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("45404f69-3e14-4107-8b5f-77dacbd1736c") },
                    { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("45404f69-3e14-4107-8b5f-77dacbd1736c") },
                    { new Guid("4a3d0a26-55dd-458e-a2d6-34be27f9466a"), new Guid("45404f69-3e14-4107-8b5f-77dacbd1736c") },
                    { new Guid("4d99f5fe-c1e3-4008-8946-69324331ed01"), new Guid("45404f69-3e14-4107-8b5f-77dacbd1736c") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("45404f69-3e14-4107-8b5f-77dacbd1736c") },
                    { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("45404f69-3e14-4107-8b5f-77dacbd1736c") },
                    { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("45404f69-3e14-4107-8b5f-77dacbd1736c") },
                    { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("48a6631b-2edc-45fd-b3fe-cdbbe624ce04") },
                    { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("48a6631b-2edc-45fd-b3fe-cdbbe624ce04") },
                    { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("48a6631b-2edc-45fd-b3fe-cdbbe624ce04") },
                    { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("48a6631b-2edc-45fd-b3fe-cdbbe624ce04") },
                    { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("5498dd83-f3db-49f3-91b8-0c12fdd9e33f") },
                    { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("5498dd83-f3db-49f3-91b8-0c12fdd9e33f") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("595c5389-0d7a-446a-bcaa-f8ce30e5152a") },
                    { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("5c5e078a-4826-4c07-a75c-5f770a134a69") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("5c5e078a-4826-4c07-a75c-5f770a134a69") },
                    { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("5c5e078a-4826-4c07-a75c-5f770a134a69") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("5f1e1abf-d068-4d06-b176-698c2c6fd38d") },
                    { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("63ed5300-cebd-4167-b383-348c98695ee5") },
                    { new Guid("4d99f5fe-c1e3-4008-8946-69324331ed01"), new Guid("63ed5300-cebd-4167-b383-348c98695ee5") },
                    { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("63ed5300-cebd-4167-b383-348c98695ee5") },
                    { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("63ed5300-cebd-4167-b383-348c98695ee5") },
                    { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("6b028ae2-734d-453a-8ecb-f37a7202c1a2") },
                    { new Guid("4a3d0a26-55dd-458e-a2d6-34be27f9466a"), new Guid("71977b8e-458e-4fd1-bdac-c608325777d9") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("7861c16e-d82f-4527-8914-175384a7272f") },
                    { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("837daf5d-2d2c-4bde-a944-7fd722a3a5d9") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("85e045bf-f5d8-428a-9ea7-4403b8459176") },
                    { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("8c277707-ef89-48c7-9e11-b3da5a2f55d2") },
                    { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("8c277707-ef89-48c7-9e11-b3da5a2f55d2") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("8c277707-ef89-48c7-9e11-b3da5a2f55d2") },
                    { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("9dd966f9-47d0-4c8e-aee4-13ebeaf24c02") },
                    { new Guid("4a3d0a26-55dd-458e-a2d6-34be27f9466a"), new Guid("9dd966f9-47d0-4c8e-aee4-13ebeaf24c02") },
                    { new Guid("4d99f5fe-c1e3-4008-8946-69324331ed01"), new Guid("9dd966f9-47d0-4c8e-aee4-13ebeaf24c02") },
                    { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("9dd966f9-47d0-4c8e-aee4-13ebeaf24c02") },
                    { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("9dd966f9-47d0-4c8e-aee4-13ebeaf24c02") },
                    { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("b2545caa-91d4-4363-b48c-3a9685d90725") },
                    { new Guid("4d99f5fe-c1e3-4008-8946-69324331ed01"), new Guid("b2545caa-91d4-4363-b48c-3a9685d90725") },
                    { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("b2545caa-91d4-4363-b48c-3a9685d90725") },
                    { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("b2545caa-91d4-4363-b48c-3a9685d90725") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("b5a6230a-be9f-4197-8169-6a6db0cebeaa") },
                    { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("b6988db9-10e0-4bad-9b1d-bd2ef54bdc62") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("b7b6a8ae-3713-4427-a2c2-8b78258ab802") },
                    { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("c2430241-81bd-4ca8-8f52-e0739e43877d") },
                    { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("c2430241-81bd-4ca8-8f52-e0739e43877d") },
                    { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("c546ed63-b96a-4f78-8562-cd55b6562a68") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("c546ed63-b96a-4f78-8562-cd55b6562a68") },
                    { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("c546ed63-b96a-4f78-8562-cd55b6562a68") },
                    { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("ce64e8ef-238d-4e65-8a7e-c9564c9340bc") },
                    { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("ce64e8ef-238d-4e65-8a7e-c9564c9340bc") },
                    { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("ce64e8ef-238d-4e65-8a7e-c9564c9340bc") },
                    { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("d0f0c657-3ab6-41a2-9303-18cab0a8dfe6") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("d0f0c657-3ab6-41a2-9303-18cab0a8dfe6") },
                    { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("d2b44131-4f80-4a59-a60d-4828e3f90866") },
                    { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("d494d01f-a939-48db-bcc2-88a3021a8d06") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("d573787a-8021-48f7-acbc-0f16fc7ecb80") },
                    { new Guid("4d99f5fe-c1e3-4008-8946-69324331ed01"), new Guid("d6e10246-2b24-4a87-b6b7-aae4e8ffa04d") },
                    { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("ed19e565-ad16-427d-9965-d8122f88e635") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("ed19e565-ad16-427d-9965-d8122f88e635") },
                    { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("ed19e565-ad16-427d-9965-d8122f88e635") },
                    { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("f64a7f5a-1ed0-4bed-a39e-8a952ad295c4") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("f64a7f5a-1ed0-4bed-a39e-8a952ad295c4") },
                    { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("f71e817d-978c-4c3c-b43b-212b658b9861") },
                    { new Guid("4a3d0a26-55dd-458e-a2d6-34be27f9466a"), new Guid("f71e817d-978c-4c3c-b43b-212b658b9861") },
                    { new Guid("4d99f5fe-c1e3-4008-8946-69324331ed01"), new Guid("f71e817d-978c-4c3c-b43b-212b658b9861") },
                    { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("f71e817d-978c-4c3c-b43b-212b658b9861") },
                    { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("f71e817d-978c-4c3c-b43b-212b658b9861") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("f90c4279-a314-4960-8bf7-da6606cee19c") },
                    { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("fdf6c906-5b27-40a8-bfd3-c20d9d2a62cc") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("1c609b35-f19b-4366-90eb-f44440fa26e8"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("62d2fc22-9881-4bc0-9cdd-4c70a4feb65e"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("691ecc14-6081-4568-af4b-b43364c0c6eb"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("7b16b9a1-18d2-46fb-9c31-d1c44ad8ee5f"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("b3099c2b-9ea7-4e0b-8dc1-661aa8df665a"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("e6b50372-d4e8-4d5e-ae05-fe8d9394c586"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("02a4cae9-d308-4f64-b007-a8c0ed0b33f9"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("0d07ede7-68cf-45f3-af42-74c2be4c3696"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("5319715d-9d2b-4453-86dd-3339b6dfdcd7"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("700cb581-aea0-4bfd-9e01-d479b36cc979"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("93039dbe-5c88-4fb6-9dc4-aa4037cb725c"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("a44a818a-47fb-4b31-b7c5-06e7d84221e5"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("a46aee19-f5cb-4c90-8150-9d7e8c276567"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("aa60daa6-7474-416f-aaea-1df70aee2f5a"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("b9a5e6ef-64ac-415c-bd98-3df641eebe1f"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("d4b0c82d-55e3-4ab4-bea1-11cd56635640"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("d74d843d-a55b-493a-ae1a-9d6d3121bf57"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("f85b7a75-1df7-481c-b8e3-f9413d19d6d5"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("d31a9a15-a883-46c7-a4f6-acd2e2da6ade"));

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("06c18dc9-80b6-494f-8bb0-a2cede682f9e") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("0cc1df6b-654b-4037-b3f0-3c88c5c842fa") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("0cc1df6b-654b-4037-b3f0-3c88c5c842fa") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("27deee5d-937a-4801-a028-97226a9d97d6") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("27deee5d-937a-4801-a028-97226a9d97d6") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("2f179910-d592-4b5c-82b8-7c0b7383fce7") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("2f179910-d592-4b5c-82b8-7c0b7383fce7") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("38bfe8d8-8498-45b0-bc6e-292ba75ded7b") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("38bfe8d8-8498-45b0-bc6e-292ba75ded7b") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("45404f69-3e14-4107-8b5f-77dacbd1736c") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("45404f69-3e14-4107-8b5f-77dacbd1736c") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("4a3d0a26-55dd-458e-a2d6-34be27f9466a"), new Guid("45404f69-3e14-4107-8b5f-77dacbd1736c") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("4d99f5fe-c1e3-4008-8946-69324331ed01"), new Guid("45404f69-3e14-4107-8b5f-77dacbd1736c") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("45404f69-3e14-4107-8b5f-77dacbd1736c") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("45404f69-3e14-4107-8b5f-77dacbd1736c") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("45404f69-3e14-4107-8b5f-77dacbd1736c") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("48a6631b-2edc-45fd-b3fe-cdbbe624ce04") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("48a6631b-2edc-45fd-b3fe-cdbbe624ce04") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("48a6631b-2edc-45fd-b3fe-cdbbe624ce04") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("48a6631b-2edc-45fd-b3fe-cdbbe624ce04") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("5498dd83-f3db-49f3-91b8-0c12fdd9e33f") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("5498dd83-f3db-49f3-91b8-0c12fdd9e33f") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("595c5389-0d7a-446a-bcaa-f8ce30e5152a") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("5c5e078a-4826-4c07-a75c-5f770a134a69") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("5c5e078a-4826-4c07-a75c-5f770a134a69") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("5c5e078a-4826-4c07-a75c-5f770a134a69") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("5f1e1abf-d068-4d06-b176-698c2c6fd38d") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("63ed5300-cebd-4167-b383-348c98695ee5") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("4d99f5fe-c1e3-4008-8946-69324331ed01"), new Guid("63ed5300-cebd-4167-b383-348c98695ee5") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("63ed5300-cebd-4167-b383-348c98695ee5") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("63ed5300-cebd-4167-b383-348c98695ee5") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("6b028ae2-734d-453a-8ecb-f37a7202c1a2") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("4a3d0a26-55dd-458e-a2d6-34be27f9466a"), new Guid("71977b8e-458e-4fd1-bdac-c608325777d9") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("7861c16e-d82f-4527-8914-175384a7272f") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("837daf5d-2d2c-4bde-a944-7fd722a3a5d9") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("85e045bf-f5d8-428a-9ea7-4403b8459176") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("8c277707-ef89-48c7-9e11-b3da5a2f55d2") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("8c277707-ef89-48c7-9e11-b3da5a2f55d2") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("8c277707-ef89-48c7-9e11-b3da5a2f55d2") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("9dd966f9-47d0-4c8e-aee4-13ebeaf24c02") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("4a3d0a26-55dd-458e-a2d6-34be27f9466a"), new Guid("9dd966f9-47d0-4c8e-aee4-13ebeaf24c02") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("4d99f5fe-c1e3-4008-8946-69324331ed01"), new Guid("9dd966f9-47d0-4c8e-aee4-13ebeaf24c02") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("9dd966f9-47d0-4c8e-aee4-13ebeaf24c02") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("9dd966f9-47d0-4c8e-aee4-13ebeaf24c02") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("b2545caa-91d4-4363-b48c-3a9685d90725") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("4d99f5fe-c1e3-4008-8946-69324331ed01"), new Guid("b2545caa-91d4-4363-b48c-3a9685d90725") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("b2545caa-91d4-4363-b48c-3a9685d90725") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("b2545caa-91d4-4363-b48c-3a9685d90725") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("b5a6230a-be9f-4197-8169-6a6db0cebeaa") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("b6988db9-10e0-4bad-9b1d-bd2ef54bdc62") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("b7b6a8ae-3713-4427-a2c2-8b78258ab802") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("c2430241-81bd-4ca8-8f52-e0739e43877d") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("c2430241-81bd-4ca8-8f52-e0739e43877d") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("c546ed63-b96a-4f78-8562-cd55b6562a68") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("c546ed63-b96a-4f78-8562-cd55b6562a68") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("c546ed63-b96a-4f78-8562-cd55b6562a68") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("ce64e8ef-238d-4e65-8a7e-c9564c9340bc") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("ce64e8ef-238d-4e65-8a7e-c9564c9340bc") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("ce64e8ef-238d-4e65-8a7e-c9564c9340bc") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("d0f0c657-3ab6-41a2-9303-18cab0a8dfe6") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("d0f0c657-3ab6-41a2-9303-18cab0a8dfe6") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("d2b44131-4f80-4a59-a60d-4828e3f90866") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("d494d01f-a939-48db-bcc2-88a3021a8d06") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("d573787a-8021-48f7-acbc-0f16fc7ecb80") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("4d99f5fe-c1e3-4008-8946-69324331ed01"), new Guid("d6e10246-2b24-4a87-b6b7-aae4e8ffa04d") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("ed19e565-ad16-427d-9965-d8122f88e635") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("ed19e565-ad16-427d-9965-d8122f88e635") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("ed19e565-ad16-427d-9965-d8122f88e635") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"), new Guid("f64a7f5a-1ed0-4bed-a39e-8a952ad295c4") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("f64a7f5a-1ed0-4bed-a39e-8a952ad295c4") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"), new Guid("f71e817d-978c-4c3c-b43b-212b658b9861") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("4a3d0a26-55dd-458e-a2d6-34be27f9466a"), new Guid("f71e817d-978c-4c3c-b43b-212b658b9861") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("4d99f5fe-c1e3-4008-8946-69324331ed01"), new Guid("f71e817d-978c-4c3c-b43b-212b658b9861") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"), new Guid("f71e817d-978c-4c3c-b43b-212b658b9861") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"), new Guid("f71e817d-978c-4c3c-b43b-212b658b9861") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("f90c4279-a314-4960-8bf7-da6606cee19c") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"), new Guid("fdf6c906-5b27-40a8-bfd3-c20d9d2a62cc") });

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("edf93b3f-e56a-4e37-8910-70b59655efd9"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("11896c54-51ef-4ecb-9d76-d47f98ecf703"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("42647a6a-5498-4a76-8ef2-3c5f2932989b"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("4a3d0a26-55dd-458e-a2d6-34be27f9466a"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("4d99f5fe-c1e3-4008-8946-69324331ed01"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("b229a58a-9799-462e-a69a-b0443e0f5f0c"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("d40c5c03-514b-4c52-9c16-e0f212d2a709"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("f38b7451-ad35-4f0f-8135-3b296738939f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("06c18dc9-80b6-494f-8bb0-a2cede682f9e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0cc1df6b-654b-4037-b3f0-3c88c5c842fa"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("27deee5d-937a-4801-a028-97226a9d97d6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2f179910-d592-4b5c-82b8-7c0b7383fce7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("38bfe8d8-8498-45b0-bc6e-292ba75ded7b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("45404f69-3e14-4107-8b5f-77dacbd1736c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("48a6631b-2edc-45fd-b3fe-cdbbe624ce04"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5498dd83-f3db-49f3-91b8-0c12fdd9e33f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("595c5389-0d7a-446a-bcaa-f8ce30e5152a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5c5e078a-4826-4c07-a75c-5f770a134a69"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5f1e1abf-d068-4d06-b176-698c2c6fd38d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("63ed5300-cebd-4167-b383-348c98695ee5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6b028ae2-734d-453a-8ecb-f37a7202c1a2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("71977b8e-458e-4fd1-bdac-c608325777d9"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7861c16e-d82f-4527-8914-175384a7272f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("837daf5d-2d2c-4bde-a944-7fd722a3a5d9"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("85e045bf-f5d8-428a-9ea7-4403b8459176"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8c277707-ef89-48c7-9e11-b3da5a2f55d2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9dd966f9-47d0-4c8e-aee4-13ebeaf24c02"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b2545caa-91d4-4363-b48c-3a9685d90725"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b5a6230a-be9f-4197-8169-6a6db0cebeaa"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b6988db9-10e0-4bad-9b1d-bd2ef54bdc62"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b7b6a8ae-3713-4427-a2c2-8b78258ab802"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c2430241-81bd-4ca8-8f52-e0739e43877d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c546ed63-b96a-4f78-8562-cd55b6562a68"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ce64e8ef-238d-4e65-8a7e-c9564c9340bc"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d0f0c657-3ab6-41a2-9303-18cab0a8dfe6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d2b44131-4f80-4a59-a60d-4828e3f90866"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d494d01f-a939-48db-bcc2-88a3021a8d06"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d573787a-8021-48f7-acbc-0f16fc7ecb80"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d6e10246-2b24-4a87-b6b7-aae4e8ffa04d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ed19e565-ad16-427d-9965-d8122f88e635"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f64a7f5a-1ed0-4bed-a39e-8a952ad295c4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f71e817d-978c-4c3c-b43b-212b658b9861"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f90c4279-a314-4960-8bf7-da6606cee19c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("fdf6c906-5b27-40a8-bfd3-c20d9d2a62cc"));
        }
    }
}
