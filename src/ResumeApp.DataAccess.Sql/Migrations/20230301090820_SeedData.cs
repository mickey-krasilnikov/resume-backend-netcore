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
                    { new Guid("1b6604b4-d3e7-4073-9db6-e352dfc37757"), new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", "Professional Cloud Architect", "https://www.credential.net/786961ad-0225-4bb0-883a-3c2feceb5174" },
                    { new Guid("488f11c3-2b89-453b-93d6-0bcdbe1e2851"), new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "DevOps Engineer Expert", "https://www.credly.com/badges/eaedb35f-5ea9-45b2-b551-acad69b94488" },
                    { new Guid("521f1124-2dc6-41ef-862a-0eee1b59e4c3"), new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "Azure Solutions Architect Expert", "https://www.credly.com/badges/8ea21901-34c7-4cb4-bc48-71e0c5cf3e85" },
                    { new Guid("625d45d1-0135-4086-aad6-7f836cba36e1"), new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon", "AWS Certified Solutions Architect Associate", "https://www.credly.com/badges/dc95ff2a-12d8-4816-91b2-a9292ae5df85" },
                    { new Guid("806000d1-d1f0-495f-8498-73e58af70027"), new DateTime(2022, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "Azure Developer Associate", "https://www.credly.com/badges/49ab14ad-ffe5-47ae-b3d1-9d29b00ef4dc" },
                    { new Guid("87ca393b-4e8f-4eb6-9a84-55286fabeed6"), new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", "Associate Cloud Engineer", "https://www.credential.net/f4054913-d10c-4cd4-89cb-e286f00de2ae" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Key", "Link", "Value" },
                values: new object[,]
                {
                    { new Guid("0f1c366e-54ff-43e0-ba89-7c5409caf466"), "twitter", "https://twitter.com/mickey_kras", "@mickey_kras" },
                    { new Guid("52d23e7b-8078-434a-8045-535e9420effd"), "credly", "https://www.credly.com/users/mickey-krasilnikov/badges", "@mickey-krasilnikov" },
                    { new Guid("5e0076ab-34cc-4702-a9dd-26b70dfcca71"), "phone", "tel:+14084803600", "+14084803600" },
                    { new Guid("75c5c94b-d830-486f-9a8d-9e771f5c0239"), "instagram", "https://www.instagram.com/mickey.krasilnikov", "@mickey.krasilnikov" },
                    { new Guid("8ce4a50a-3fb9-4923-9eb6-e866af138a27"), "location", "https://www.google.com/maps/place/Sunyvale%20CA%2094085/", "Sunyvale, CA, 94085" },
                    { new Guid("9ea39ee0-cd93-4c82-8fa3-06c301d3b7ab"), "accredible", "https://www.credential.net/profile/mikhailkrasilnikov328966/wallet", "@mikhailkrasilnikov328966" },
                    { new Guid("a9028523-6999-4f8c-b9f5-6bbb371b11c9"), "linkedIn", "https://www.linkedin.com/in/mickeykrasilnikov", "@mickeykrasilnikov" },
                    { new Guid("be4e59a9-52b6-42a9-b09a-d88a7eaa801b"), "github", "https://github.com/mickey-krasilnikov", "@mickey-krasilnikov" },
                    { new Guid("d0af11d2-c3ca-49a1-a105-d71dd53fbac0"), "whatsapp", "https://wa.me/+14084803600", "Whatsapp" },
                    { new Guid("df973f56-bd70-4b41-8110-933ce7966bf2"), "email", "mailto:your_email", "Mickey.Krasilnikov@gmail.com" },
                    { new Guid("e2ae7016-b312-4738-acc5-79850a69deb2"), "facebook", "https://www.facebook.com/mickey.krasilnikov", "@mickey.krasilnikov" },
                    { new Guid("f7210666-4526-4324-aee7-ae40ea9552a9"), "telegram", "https://t.me/+14084803600", "Telegram" }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Degree", "EndDate", "FieldOfStudy", "Name", "StartDate", "Url" },
                values: new object[] { new Guid("b5cb0d98-3657-4890-87df-4a6b0acb839c"), "Bachelor's degree", new DateTime(2013, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Design and technology of radio electronic devices", "Penza State University", new DateTime(2006, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://international.pnzgu.ru/" });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Company", "EndDate", "Location", "StartDate", "TaskPerformed", "Title" },
                values: new object[,]
                {
                    { new Guid("1ac11019-b63f-43d8-b9cb-22ac33aa1558"), "SGC", new DateTime(2013, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moscow, Russia", new DateTime(2012, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developed software that composes accurate construction cost estimates, which resulted in a 25% reduction in estimate preparation time.\nImproved software flexibility and saved valuable time by adding the ability to convert estimates from other well-known systems.\nStreamlined report creation process by enabling final estimate result export to various formats, providing customization options for users.\n", "Software Engineer" },
                    { new Guid("51baeba6-a565-4887-8ba4-4754a1d2a5d1"), "Research and Production Center 'Start'", new DateTime(2012, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penza, Russia", new DateTime(2010, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developed an in-house CAD tool for designing microboards, including the ability to import AutoCAD files.\nImplemented a feature that enables the printing of photomasks for microboards using specialized equipment.\nOptimized the CAD tool for faster and more efficient microboard design, resulting in a 30% reduction in design time.\n", "Software Engineer" },
                    { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), "Yandex", new DateTime(2015, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moscow, Russia", new DateTime(2014, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developed a payment system that streamlined the process of paying for lunch at nearby cafes and restaurants using the office access card (RFID tag), resulting in improved efficiency and convenience for employees.\nDesigned and developed a user-friendly personal page for employees, enabling them to view their transaction history and account balance.\nCreated a desktop application for administrators that simplified the process of managing employee accounts and generating reports.\n", "Senior Software Engineer" },
                    { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), "Gollard", new DateTime(2014, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moscow, Russia", new DateTime(2013, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created a GIS desktop app for energy distribution company handling grids, stations, and facilities, improving overall operational efficiency.\nEnabled real-time tracking of service transport location and engine state, enhancing the company's logistical capabilities.\nImplemented an alerting system that utilizes biometric camera data and sensor events, increasing the company's security posture.\n", "Software Engineer" },
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), "EPAM Systems", null, "San Jose, CA, USA", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created Execution Compliance and Trade Surveillance System for analysis of trading activities to ensure regulatory compliance.\nEngineered a Vue.js-based web dashboard for monitoring, analyzing, and visualizing data.\nDesigned and developed high-performance .NET Core backend services, resulting in a scalable and maintainable architecture.\nImplemented an event-driven workflow that utilized Amazon SQS and AWS Lambdas, written in Python, to efficiently load and parse large data files, reducing processing times and increasing overall system throughput.\n", "Lead Software Engineer" },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), "EPAM Systems", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wroclaw, Poland", new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Designed and developed a cloud-native microservice-based system for managing insurance claims, underwriting, and reporting.\nCreated an intuitive self-service portal using Angular, improving customer satisfaction while reducing customer support inquiries.\nDeveloped highly scalable and reliable RESTful microservices in .NET Core, resulting in improved efficiency and cost savings.\nImplemented performance-critical internal services using GoLang, resulting in faster and more accurate claims processing.\nEnsured high software quality with 80% code coverage and automated quality gates in CI/CD, reducing maintenance costs.\n", "Lead Software Engineer" },
                    { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), "Credit Suisse", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wroclaw, Poland", new DateTime(2015, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created a high-performing desktop application for Credit Suisse's front office to manage market risks in real time using WPF and C#.\nRestructured an existing monolithic architecture into microservices, providing more flexibility and scalability while improving performance.\nImplemented automated testing, reducing the likelihood of bugs and errors and increasing the overall reliability of the system.\nOptimized the performance of the in-house distributed cache, leading to faster processing times and greater efficiency in C#.\n", "Senior Software Engineer" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "IsHighlighted", "Name", "Priority", "SkillGroup" },
                values: new object[,]
                {
                    { new Guid("014d3588-b7d8-40a9-af5e-dfc15c339c85"), true, "Docker", 501, "Tools" },
                    { new Guid("0d007ad4-4379-4e5e-aa12-40c62927998c"), true, "Python3", 210, "Backend" },
                    { new Guid("0f16ede3-0bc2-47b2-8a98-4b348f4b8202"), true, "MySQL", 401, "Database" },
                    { new Guid("16f6207a-e38c-4fa5-967d-4d4e1fd330dd"), false, "Entity Framework", 213, "Backend" },
                    { new Guid("19a964ee-362a-4f52-82c7-901ec92b190d"), true, "WPF", 309, "Frontend" },
                    { new Guid("1d205562-0906-4fa3-b410-1994000b8b91"), true, "OKTA", 508, "Tools" },
                    { new Guid("1dc5e010-6f0e-4651-a6e0-7e7061d6c781"), true, "AWS", 102, "Clouds" },
                    { new Guid("1f71b23e-6eb8-444b-945f-04dc3b6e6dcc"), true, "Jenkins", 506, "Tools" },
                    { new Guid("22135820-bfc4-4f17-b0f2-8cbdba10a2a9"), true, "Node.js", 206, "Backend" },
                    { new Guid("25f84d31-59d4-41af-bba4-4a96bd67e373"), true, ".NET", 203, "Backend" },
                    { new Guid("27d65041-3a7b-4443-af7c-7ff20a0cff11"), true, "Express.js Web Framework", 207, "Backend" },
                    { new Guid("2d7e5810-b437-49b5-9801-9d57b1bd0c2f"), true, "MS SSAS", 403, "Database" },
                    { new Guid("2fd77f7a-4f3e-4ba6-a1af-2ab1628471a6"), true, "ASP.NET Core Web API", 204, "Backend" },
                    { new Guid("36f830dc-864f-45bd-a567-ff35d34aa403"), false, "NUnit", 216, "Backend" },
                    { new Guid("3978f616-4c26-43ea-953f-84c62279106e"), true, "Flask Web Framework", 211, "Backend" },
                    { new Guid("3c071533-0266-4ec6-bc24-5e38f4a26bb5"), false, "WinForms", 311, "Frontend" },
                    { new Guid("4087555e-8e8c-474b-8970-62b0149ed194"), false, "Entity Framework Core", 214, "Backend" },
                    { new Guid("447457f9-4a41-4e58-9b24-718e171b965d"), true, "GCP", 103, "Clouds" },
                    { new Guid("494ed162-b23f-4ef3-a97f-3f6770ed821e"), true, "ASP.NET", 304, "Frontend" },
                    { new Guid("4bc1fa9d-d2f2-4aa2-a3fb-1d7760106726"), true, "XAML", 310, "Frontend" },
                    { new Guid("5205ec9e-f063-45cb-a587-21bca1a74892"), true, "Cosmos DB", 404, "Database" },
                    { new Guid("53065d38-ae20-4130-a2de-5dad4d7ab317"), false, "WCF", 212, "Backend" },
                    { new Guid("66721da3-eef3-4fb0-94ab-1ddd99814606"), true, "Azure", 101, "Clouds" },
                    { new Guid("6730c197-4fde-452d-a2e2-1e9b93e82872"), true, ".NET Core", 202, "Backend" },
                    { new Guid("7c4cc9e6-deb5-41e7-85d5-f32ed2d5f771"), true, "ASP.NET Web API", 205, "Backend" },
                    { new Guid("81786180-7ffc-4d9e-a3e1-812acf9ed04b"), true, "Gin Web Framework", 209, "Backend" },
                    { new Guid("888a9550-f2dd-4e7d-a010-bb21411ab52a"), true, "MS SQL", 402, "Database" },
                    { new Guid("918a79ca-a2ec-4878-9d3f-802c4bd10a64"), true, "Angular 8+", 301, "Frontend" },
                    { new Guid("96eef699-0493-4389-8508-e0e5ac7a10ff"), true, "CSS", 308, "Frontend" },
                    { new Guid("99f1aca2-fcf3-42be-a7c9-62c84f54b02e"), false, "MSTest", 217, "Backend" },
                    { new Guid("a079055b-d4b7-4b96-afc3-7cb503e7e76e"), true, "GoLang", 208, "Backend" },
                    { new Guid("a120ba72-3a02-47b0-b626-dc37208d0747"), true, "Esri ArcGIS", 510, "Tools" },
                    { new Guid("afee880a-2ef7-4597-b41d-faa595811aa0"), true, "GitHub Actions", 504, "Tools" },
                    { new Guid("bb99c612-e5e2-43c6-a8f6-4a8bc82fa47a"), true, "JavaScript", 305, "Frontend" },
                    { new Guid("c329e836-2e60-47ed-bcca-0e8b2b3cbef0"), true, "TeamCity", 507, "Tools" },
                    { new Guid("c7499348-ae6f-41a8-8739-92e575988976"), true, "Dynamo DB", 405, "Database" },
                    { new Guid("d4f46599-5251-48f8-9097-eaee336b8993"), true, "ASP.NET Core (Blazor)", 303, "Frontend" },
                    { new Guid("d61e2f58-e592-4550-aad3-14b2da1abe5c"), false, "xUnit", 215, "Backend" },
                    { new Guid("db5b7c7c-e7d7-4b4a-8462-28bbc6ce2a2c"), true, "AWS DevOps", 505, "Tools" },
                    { new Guid("e187b2ef-0a5d-4f5c-bd42-c288b0484bce"), true, "Vue.js", 302, "Frontend" },
                    { new Guid("e370472b-07c1-441f-8161-2c9ad7ed921b"), true, "Azure DevOps", 503, "Tools" },
                    { new Guid("e705f66c-af17-4011-b9f4-77155ca17fba"), true, "Jira", 509, "Tools" },
                    { new Guid("e73e86d9-8c82-4aa8-87f5-29007d4842a0"), true, "TypeScript", 306, "Frontend" },
                    { new Guid("f2a2aa0c-46d2-4500-aae5-f85f93327eb8"), true, "Redis", 406, "Database" },
                    { new Guid("f36deae8-083d-496f-8895-b3e98e7f6a96"), true, "Kubernetes", 502, "Tools" },
                    { new Guid("f6fc53fe-eac7-41c0-a278-062b77a10809"), true, "C#", 201, "Backend" },
                    { new Guid("faedd3e4-ac78-455f-a2a6-8787cc5d2724"), true, "HTML", 307, "Frontend" }
                });

            migrationBuilder.InsertData(
                table: "SkillExperienceMappings",
                columns: new[] { "ExperienceId", "SkillId" },
                values: new object[,]
                {
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("014d3588-b7d8-40a9-af5e-dfc15c339c85") },
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("0d007ad4-4379-4e5e-aa12-40c62927998c") },
                    { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("0f16ede3-0bc2-47b2-8a98-4b348f4b8202") },
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("0f16ede3-0bc2-47b2-8a98-4b348f4b8202") },
                    { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("16f6207a-e38c-4fa5-967d-4d4e1fd330dd") },
                    { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("16f6207a-e38c-4fa5-967d-4d4e1fd330dd") },
                    { new Guid("1ac11019-b63f-43d8-b9cb-22ac33aa1558"), new Guid("19a964ee-362a-4f52-82c7-901ec92b190d") },
                    { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("19a964ee-362a-4f52-82c7-901ec92b190d") },
                    { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("19a964ee-362a-4f52-82c7-901ec92b190d") },
                    { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("19a964ee-362a-4f52-82c7-901ec92b190d") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("1d205562-0906-4fa3-b410-1994000b8b91") },
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("1dc5e010-6f0e-4651-a6e0-7e7061d6c781") },
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("1f71b23e-6eb8-444b-945f-04dc3b6e6dcc") },
                    { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("1f71b23e-6eb8-444b-945f-04dc3b6e6dcc") },
                    { new Guid("1ac11019-b63f-43d8-b9cb-22ac33aa1558"), new Guid("25f84d31-59d4-41af-bba4-4a96bd67e373") },
                    { new Guid("51baeba6-a565-4887-8ba4-4754a1d2a5d1"), new Guid("25f84d31-59d4-41af-bba4-4a96bd67e373") },
                    { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("25f84d31-59d4-41af-bba4-4a96bd67e373") },
                    { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("25f84d31-59d4-41af-bba4-4a96bd67e373") },
                    { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("25f84d31-59d4-41af-bba4-4a96bd67e373") },
                    { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("2d7e5810-b437-49b5-9801-9d57b1bd0c2f") },
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("2fd77f7a-4f3e-4ba6-a1af-2ab1628471a6") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("2fd77f7a-4f3e-4ba6-a1af-2ab1628471a6") },
                    { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("36f830dc-864f-45bd-a567-ff35d34aa403") },
                    { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("36f830dc-864f-45bd-a567-ff35d34aa403") },
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("36f830dc-864f-45bd-a567-ff35d34aa403") },
                    { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("36f830dc-864f-45bd-a567-ff35d34aa403") },
                    { new Guid("51baeba6-a565-4887-8ba4-4754a1d2a5d1"), new Guid("3c071533-0266-4ec6-bc24-5e38f4a26bb5") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("4087555e-8e8c-474b-8970-62b0149ed194") },
                    { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("4087555e-8e8c-474b-8970-62b0149ed194") },
                    { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("494ed162-b23f-4ef3-a97f-3f6770ed821e") },
                    { new Guid("1ac11019-b63f-43d8-b9cb-22ac33aa1558"), new Guid("4bc1fa9d-d2f2-4aa2-a3fb-1d7760106726") },
                    { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("4bc1fa9d-d2f2-4aa2-a3fb-1d7760106726") },
                    { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("4bc1fa9d-d2f2-4aa2-a3fb-1d7760106726") },
                    { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("4bc1fa9d-d2f2-4aa2-a3fb-1d7760106726") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("5205ec9e-f063-45cb-a587-21bca1a74892") },
                    { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("53065d38-ae20-4130-a2de-5dad4d7ab317") },
                    { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("53065d38-ae20-4130-a2de-5dad4d7ab317") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("66721da3-eef3-4fb0-94ab-1ddd99814606") },
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("6730c197-4fde-452d-a2e2-1e9b93e82872") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("6730c197-4fde-452d-a2e2-1e9b93e82872") },
                    { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("6730c197-4fde-452d-a2e2-1e9b93e82872") },
                    { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("7c4cc9e6-deb5-41e7-85d5-f32ed2d5f771") },
                    { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("7c4cc9e6-deb5-41e7-85d5-f32ed2d5f771") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("81786180-7ffc-4d9e-a3e1-812acf9ed04b") },
                    { new Guid("1ac11019-b63f-43d8-b9cb-22ac33aa1558"), new Guid("888a9550-f2dd-4e7d-a010-bb21411ab52a") },
                    { new Guid("51baeba6-a565-4887-8ba4-4754a1d2a5d1"), new Guid("888a9550-f2dd-4e7d-a010-bb21411ab52a") },
                    { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("888a9550-f2dd-4e7d-a010-bb21411ab52a") },
                    { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("888a9550-f2dd-4e7d-a010-bb21411ab52a") },
                    { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("888a9550-f2dd-4e7d-a010-bb21411ab52a") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("918a79ca-a2ec-4878-9d3f-802c4bd10a64") },
                    { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("96eef699-0493-4389-8508-e0e5ac7a10ff") },
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("96eef699-0493-4389-8508-e0e5ac7a10ff") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("96eef699-0493-4389-8508-e0e5ac7a10ff") },
                    { new Guid("1ac11019-b63f-43d8-b9cb-22ac33aa1558"), new Guid("99f1aca2-fcf3-42be-a7c9-62c84f54b02e") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("a079055b-d4b7-4b96-afc3-7cb503e7e76e") },
                    { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("a120ba72-3a02-47b0-b626-dc37208d0747") },
                    { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("bb99c612-e5e2-43c6-a8f6-4a8bc82fa47a") },
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("bb99c612-e5e2-43c6-a8f6-4a8bc82fa47a") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("bb99c612-e5e2-43c6-a8f6-4a8bc82fa47a") },
                    { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("c329e836-2e60-47ed-bcca-0e8b2b3cbef0") },
                    { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("c329e836-2e60-47ed-bcca-0e8b2b3cbef0") },
                    { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("c329e836-2e60-47ed-bcca-0e8b2b3cbef0") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("d61e2f58-e592-4550-aad3-14b2da1abe5c") },
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("db5b7c7c-e7d7-4b4a-8462-28bbc6ce2a2c") },
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("e187b2ef-0a5d-4f5c-bd42-c288b0484bce") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("e370472b-07c1-441f-8161-2c9ad7ed921b") },
                    { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("e705f66c-af17-4011-b9f4-77155ca17fba") },
                    { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("e705f66c-af17-4011-b9f4-77155ca17fba") },
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("e705f66c-af17-4011-b9f4-77155ca17fba") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("e705f66c-af17-4011-b9f4-77155ca17fba") },
                    { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("e705f66c-af17-4011-b9f4-77155ca17fba") },
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("e73e86d9-8c82-4aa8-87f5-29007d4842a0") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("e73e86d9-8c82-4aa8-87f5-29007d4842a0") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("f2a2aa0c-46d2-4500-aae5-f85f93327eb8") },
                    { new Guid("1ac11019-b63f-43d8-b9cb-22ac33aa1558"), new Guid("f6fc53fe-eac7-41c0-a278-062b77a10809") },
                    { new Guid("51baeba6-a565-4887-8ba4-4754a1d2a5d1"), new Guid("f6fc53fe-eac7-41c0-a278-062b77a10809") },
                    { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("f6fc53fe-eac7-41c0-a278-062b77a10809") },
                    { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("f6fc53fe-eac7-41c0-a278-062b77a10809") },
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("f6fc53fe-eac7-41c0-a278-062b77a10809") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("f6fc53fe-eac7-41c0-a278-062b77a10809") },
                    { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("f6fc53fe-eac7-41c0-a278-062b77a10809") },
                    { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("faedd3e4-ac78-455f-a2a6-8787cc5d2724") },
                    { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("faedd3e4-ac78-455f-a2a6-8787cc5d2724") },
                    { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("faedd3e4-ac78-455f-a2a6-8787cc5d2724") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("1b6604b4-d3e7-4073-9db6-e352dfc37757"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("488f11c3-2b89-453b-93d6-0bcdbe1e2851"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("521f1124-2dc6-41ef-862a-0eee1b59e4c3"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("625d45d1-0135-4086-aad6-7f836cba36e1"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("806000d1-d1f0-495f-8498-73e58af70027"));

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: new Guid("87ca393b-4e8f-4eb6-9a84-55286fabeed6"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("0f1c366e-54ff-43e0-ba89-7c5409caf466"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("52d23e7b-8078-434a-8045-535e9420effd"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("5e0076ab-34cc-4702-a9dd-26b70dfcca71"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("75c5c94b-d830-486f-9a8d-9e771f5c0239"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("8ce4a50a-3fb9-4923-9eb6-e866af138a27"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("9ea39ee0-cd93-4c82-8fa3-06c301d3b7ab"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("a9028523-6999-4f8c-b9f5-6bbb371b11c9"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("be4e59a9-52b6-42a9-b09a-d88a7eaa801b"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("d0af11d2-c3ca-49a1-a105-d71dd53fbac0"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("df973f56-bd70-4b41-8110-933ce7966bf2"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("e2ae7016-b312-4738-acc5-79850a69deb2"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("f7210666-4526-4324-aee7-ae40ea9552a9"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("b5cb0d98-3657-4890-87df-4a6b0acb839c"));

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("014d3588-b7d8-40a9-af5e-dfc15c339c85") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("0d007ad4-4379-4e5e-aa12-40c62927998c") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("0f16ede3-0bc2-47b2-8a98-4b348f4b8202") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("0f16ede3-0bc2-47b2-8a98-4b348f4b8202") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("16f6207a-e38c-4fa5-967d-4d4e1fd330dd") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("16f6207a-e38c-4fa5-967d-4d4e1fd330dd") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("1ac11019-b63f-43d8-b9cb-22ac33aa1558"), new Guid("19a964ee-362a-4f52-82c7-901ec92b190d") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("19a964ee-362a-4f52-82c7-901ec92b190d") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("19a964ee-362a-4f52-82c7-901ec92b190d") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("19a964ee-362a-4f52-82c7-901ec92b190d") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("1d205562-0906-4fa3-b410-1994000b8b91") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("1dc5e010-6f0e-4651-a6e0-7e7061d6c781") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("1f71b23e-6eb8-444b-945f-04dc3b6e6dcc") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("1f71b23e-6eb8-444b-945f-04dc3b6e6dcc") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("1ac11019-b63f-43d8-b9cb-22ac33aa1558"), new Guid("25f84d31-59d4-41af-bba4-4a96bd67e373") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("51baeba6-a565-4887-8ba4-4754a1d2a5d1"), new Guid("25f84d31-59d4-41af-bba4-4a96bd67e373") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("25f84d31-59d4-41af-bba4-4a96bd67e373") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("25f84d31-59d4-41af-bba4-4a96bd67e373") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("25f84d31-59d4-41af-bba4-4a96bd67e373") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("2d7e5810-b437-49b5-9801-9d57b1bd0c2f") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("2fd77f7a-4f3e-4ba6-a1af-2ab1628471a6") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("2fd77f7a-4f3e-4ba6-a1af-2ab1628471a6") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("36f830dc-864f-45bd-a567-ff35d34aa403") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("36f830dc-864f-45bd-a567-ff35d34aa403") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("36f830dc-864f-45bd-a567-ff35d34aa403") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("36f830dc-864f-45bd-a567-ff35d34aa403") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("51baeba6-a565-4887-8ba4-4754a1d2a5d1"), new Guid("3c071533-0266-4ec6-bc24-5e38f4a26bb5") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("4087555e-8e8c-474b-8970-62b0149ed194") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("4087555e-8e8c-474b-8970-62b0149ed194") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("494ed162-b23f-4ef3-a97f-3f6770ed821e") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("1ac11019-b63f-43d8-b9cb-22ac33aa1558"), new Guid("4bc1fa9d-d2f2-4aa2-a3fb-1d7760106726") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("4bc1fa9d-d2f2-4aa2-a3fb-1d7760106726") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("4bc1fa9d-d2f2-4aa2-a3fb-1d7760106726") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("4bc1fa9d-d2f2-4aa2-a3fb-1d7760106726") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("5205ec9e-f063-45cb-a587-21bca1a74892") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("53065d38-ae20-4130-a2de-5dad4d7ab317") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("53065d38-ae20-4130-a2de-5dad4d7ab317") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("66721da3-eef3-4fb0-94ab-1ddd99814606") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("6730c197-4fde-452d-a2e2-1e9b93e82872") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("6730c197-4fde-452d-a2e2-1e9b93e82872") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("6730c197-4fde-452d-a2e2-1e9b93e82872") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("7c4cc9e6-deb5-41e7-85d5-f32ed2d5f771") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("7c4cc9e6-deb5-41e7-85d5-f32ed2d5f771") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("81786180-7ffc-4d9e-a3e1-812acf9ed04b") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("1ac11019-b63f-43d8-b9cb-22ac33aa1558"), new Guid("888a9550-f2dd-4e7d-a010-bb21411ab52a") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("51baeba6-a565-4887-8ba4-4754a1d2a5d1"), new Guid("888a9550-f2dd-4e7d-a010-bb21411ab52a") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("888a9550-f2dd-4e7d-a010-bb21411ab52a") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("888a9550-f2dd-4e7d-a010-bb21411ab52a") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("888a9550-f2dd-4e7d-a010-bb21411ab52a") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("918a79ca-a2ec-4878-9d3f-802c4bd10a64") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("96eef699-0493-4389-8508-e0e5ac7a10ff") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("96eef699-0493-4389-8508-e0e5ac7a10ff") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("96eef699-0493-4389-8508-e0e5ac7a10ff") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("1ac11019-b63f-43d8-b9cb-22ac33aa1558"), new Guid("99f1aca2-fcf3-42be-a7c9-62c84f54b02e") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("a079055b-d4b7-4b96-afc3-7cb503e7e76e") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("a120ba72-3a02-47b0-b626-dc37208d0747") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("bb99c612-e5e2-43c6-a8f6-4a8bc82fa47a") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("bb99c612-e5e2-43c6-a8f6-4a8bc82fa47a") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("bb99c612-e5e2-43c6-a8f6-4a8bc82fa47a") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("c329e836-2e60-47ed-bcca-0e8b2b3cbef0") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("c329e836-2e60-47ed-bcca-0e8b2b3cbef0") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("c329e836-2e60-47ed-bcca-0e8b2b3cbef0") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("d61e2f58-e592-4550-aad3-14b2da1abe5c") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("db5b7c7c-e7d7-4b4a-8462-28bbc6ce2a2c") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("e187b2ef-0a5d-4f5c-bd42-c288b0484bce") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("e370472b-07c1-441f-8161-2c9ad7ed921b") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("e705f66c-af17-4011-b9f4-77155ca17fba") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("e705f66c-af17-4011-b9f4-77155ca17fba") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("e705f66c-af17-4011-b9f4-77155ca17fba") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("e705f66c-af17-4011-b9f4-77155ca17fba") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("e705f66c-af17-4011-b9f4-77155ca17fba") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("e73e86d9-8c82-4aa8-87f5-29007d4842a0") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("e73e86d9-8c82-4aa8-87f5-29007d4842a0") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("f2a2aa0c-46d2-4500-aae5-f85f93327eb8") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("1ac11019-b63f-43d8-b9cb-22ac33aa1558"), new Guid("f6fc53fe-eac7-41c0-a278-062b77a10809") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("51baeba6-a565-4887-8ba4-4754a1d2a5d1"), new Guid("f6fc53fe-eac7-41c0-a278-062b77a10809") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("f6fc53fe-eac7-41c0-a278-062b77a10809") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"), new Guid("f6fc53fe-eac7-41c0-a278-062b77a10809") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("f6fc53fe-eac7-41c0-a278-062b77a10809") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("f6fc53fe-eac7-41c0-a278-062b77a10809") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"), new Guid("f6fc53fe-eac7-41c0-a278-062b77a10809") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"), new Guid("faedd3e4-ac78-455f-a2a6-8787cc5d2724") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"), new Guid("faedd3e4-ac78-455f-a2a6-8787cc5d2724") });

            migrationBuilder.DeleteData(
                table: "SkillExperienceMappings",
                keyColumns: new[] { "ExperienceId", "SkillId" },
                keyValues: new object[] { new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"), new Guid("faedd3e4-ac78-455f-a2a6-8787cc5d2724") });

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("22135820-bfc4-4f17-b0f2-8cbdba10a2a9"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("27d65041-3a7b-4443-af7c-7ff20a0cff11"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3978f616-4c26-43ea-953f-84c62279106e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("447457f9-4a41-4e58-9b24-718e171b965d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("afee880a-2ef7-4597-b41d-faa595811aa0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c7499348-ae6f-41a8-8739-92e575988976"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d4f46599-5251-48f8-9097-eaee336b8993"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f36deae8-083d-496f-8895-b3e98e7f6a96"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("1ac11019-b63f-43d8-b9cb-22ac33aa1558"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("51baeba6-a565-4887-8ba4-4754a1d2a5d1"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("540881aa-5796-4a06-8c78-c6e80179ab5b"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("55181ac6-56a8-47ed-90b2-86ca0d83c7b8"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("bdc4ad5c-646f-4e79-9466-f77bac4bf6f5"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("c22a7471-6c35-42c2-9def-6fa83a0df8db"));

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: new Guid("feb5ed7e-8df7-4da3-8d86-83499d25d6da"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("014d3588-b7d8-40a9-af5e-dfc15c339c85"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0d007ad4-4379-4e5e-aa12-40c62927998c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0f16ede3-0bc2-47b2-8a98-4b348f4b8202"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("16f6207a-e38c-4fa5-967d-4d4e1fd330dd"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("19a964ee-362a-4f52-82c7-901ec92b190d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1d205562-0906-4fa3-b410-1994000b8b91"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1dc5e010-6f0e-4651-a6e0-7e7061d6c781"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1f71b23e-6eb8-444b-945f-04dc3b6e6dcc"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("25f84d31-59d4-41af-bba4-4a96bd67e373"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2d7e5810-b437-49b5-9801-9d57b1bd0c2f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2fd77f7a-4f3e-4ba6-a1af-2ab1628471a6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("36f830dc-864f-45bd-a567-ff35d34aa403"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3c071533-0266-4ec6-bc24-5e38f4a26bb5"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4087555e-8e8c-474b-8970-62b0149ed194"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("494ed162-b23f-4ef3-a97f-3f6770ed821e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4bc1fa9d-d2f2-4aa2-a3fb-1d7760106726"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5205ec9e-f063-45cb-a587-21bca1a74892"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("53065d38-ae20-4130-a2de-5dad4d7ab317"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("66721da3-eef3-4fb0-94ab-1ddd99814606"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6730c197-4fde-452d-a2e2-1e9b93e82872"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7c4cc9e6-deb5-41e7-85d5-f32ed2d5f771"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("81786180-7ffc-4d9e-a3e1-812acf9ed04b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("888a9550-f2dd-4e7d-a010-bb21411ab52a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("918a79ca-a2ec-4878-9d3f-802c4bd10a64"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("96eef699-0493-4389-8508-e0e5ac7a10ff"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("99f1aca2-fcf3-42be-a7c9-62c84f54b02e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a079055b-d4b7-4b96-afc3-7cb503e7e76e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a120ba72-3a02-47b0-b626-dc37208d0747"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("bb99c612-e5e2-43c6-a8f6-4a8bc82fa47a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c329e836-2e60-47ed-bcca-0e8b2b3cbef0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d61e2f58-e592-4550-aad3-14b2da1abe5c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("db5b7c7c-e7d7-4b4a-8462-28bbc6ce2a2c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e187b2ef-0a5d-4f5c-bd42-c288b0484bce"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e370472b-07c1-441f-8161-2c9ad7ed921b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e705f66c-af17-4011-b9f4-77155ca17fba"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e73e86d9-8c82-4aa8-87f5-29007d4842a0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f2a2aa0c-46d2-4500-aae5-f85f93327eb8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f6fc53fe-eac7-41c0-a278-062b77a10809"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("faedd3e4-ac78-455f-a2a6-8787cc5d2724"));
        }
    }
}
