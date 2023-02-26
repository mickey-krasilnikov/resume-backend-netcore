using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.BusinessLogic.Extensions;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Models;

namespace ResumeApp.UnitTests.Extensions
{
	public class ServiceCollectionExtensionsTests
	{
		[Theory]
		[InlineData("Sql")]
		[InlineData("sql")]
		[InlineData("SQL")]
		[InlineData("sQl")]
		public void WhenSqlDb_HappyPath(string sqlDbType)
		{
            //Arrange
            ICrudService<CertificationDto> certificationService = null;
            ICrudService<ContactDto> contactService = null;
            ICrudService<EducationDto> eductionService = null;
            ICrudService<ExperienceDto> experienceService = null;
            ICrudService<SkillDto> skillService = null;

            IRepository<CertificationSqlEntity> certificationSqlRepository = null;
            IRepository<ContactSqlEntity> contactSqlRepository = null;
            IRepository<EducationSqlEntity> educationSqlRepository = null;
            IRepository<ExperienceSqlEntity> experienceSqlRepository = null;
			IRepository<SkillSqlEntity> skillSqlRepository = null;

            var serviceCollection = new ServiceCollection();
			var builder = new ConfigurationBuilder();
			builder.AddInMemoryCollection(new List<KeyValuePair<string, string>>()
			{
				new ("DbConnectionOptions:UseDbType", sqlDbType),
				new ("ConnectionStrings:Sql","Server=tcp:fake_server;Initial Catalog=fake_db;User ID=fake-user;Password=fake-password;")
			});
			var configuration = builder.Build();
			serviceCollection.AddSingleton<IConfiguration>(configuration);

			//Act
			var exception = Record.Exception(() =>
			{
				serviceCollection.AddResumeServices(configuration);
				var serviceProvider = serviceCollection.BuildServiceProvider();

                certificationService = serviceProvider.GetRequiredService<ICrudService<CertificationDto>>();
                contactService = serviceProvider.GetRequiredService<ICrudService<ContactDto>>();
                eductionService = serviceProvider.GetRequiredService<ICrudService<EducationDto>>();
                experienceService = serviceProvider.GetRequiredService<ICrudService<ExperienceDto>>();
                skillService = serviceProvider.GetRequiredService<ICrudService<SkillDto>>();

                certificationSqlRepository = serviceProvider.GetRequiredService<IRepository<CertificationSqlEntity>>();
                contactSqlRepository = serviceProvider.GetRequiredService<IRepository<ContactSqlEntity>>();
                educationSqlRepository = serviceProvider.GetRequiredService<IRepository<EducationSqlEntity>>();
                experienceSqlRepository = serviceProvider.GetRequiredService<IRepository<ExperienceSqlEntity>>();
                skillSqlRepository = serviceProvider.GetRequiredService<IRepository<SkillSqlEntity>>();
            });

			//Assert
			Assert.Null(exception);

			Assert.NotNull(certificationService);
            Assert.NotNull(contactService);
            Assert.NotNull(eductionService);
            Assert.NotNull(experienceService);
            Assert.NotNull(skillService);

            Assert.NotNull(certificationSqlRepository);
            Assert.NotNull(contactSqlRepository);
            Assert.NotNull(educationSqlRepository);
            Assert.NotNull(experienceSqlRepository);
            Assert.NotNull(skillSqlRepository);
        }

		[Theory]
		[InlineData("Mongo")]
		[InlineData("mongo")]
		[InlineData("MONGO")]
		[InlineData("mOnGo")]
		public void WhenMongoDb_HappyPath(string mongoDbType)
		{
            //Arrange
            ICrudService<CertificationDto> certificationService = null;
            ICrudService<ContactDto> contactService = null;
            ICrudService<EducationDto> eductionService = null;
            ICrudService<ExperienceDto> experienceService = null;
            ICrudService<SkillDto> skillService = null;

            IRepository<CertificationMongoEntity> certificationMongoRepository = null;
            IRepository<ContactMongoEntity> contactMongoRepository = null;
            IRepository<EducationMongoEntity> educationMongoRepository = null;
            IRepository<ExperienceMongoEntity> experienceMongoRepository = null;
            IRepository<SkillMongoEntity> skillMongoRepository = null;

            var serviceCollection = new ServiceCollection();
			var builder = new ConfigurationBuilder();
			builder.AddInMemoryCollection(new List<KeyValuePair<string, string>>()
			{
				new ("DbConnectionOptions:UseDbType", mongoDbType),
				new ("ConnectionStrings:Mongo", "mongodb://fake_instance:fakekey==@fake_url/resume-db?ssl=true&appName=@fake-app@")
			});
			var configuration = builder.Build();
			serviceCollection.AddSingleton<IConfiguration>(configuration);

			//Act
			var exception = Record.Exception(() =>
			{
				serviceCollection.AddResumeServices(configuration);
				var serviceProvider = serviceCollection.BuildServiceProvider();

                certificationService = serviceProvider.GetRequiredService<ICrudService<CertificationDto>>();
                contactService = serviceProvider.GetRequiredService<ICrudService<ContactDto>>();
                eductionService = serviceProvider.GetRequiredService<ICrudService<EducationDto>>();
                experienceService = serviceProvider.GetRequiredService<ICrudService<ExperienceDto>>();
                skillService = serviceProvider.GetRequiredService<ICrudService<SkillDto>>();

                certificationMongoRepository = serviceProvider.GetRequiredService<IRepository<CertificationMongoEntity>>();
                contactMongoRepository = serviceProvider.GetRequiredService<IRepository<ContactMongoEntity>>();
                educationMongoRepository = serviceProvider.GetRequiredService<IRepository<EducationMongoEntity>>();
                experienceMongoRepository = serviceProvider.GetRequiredService<IRepository<ExperienceMongoEntity>>();
                skillMongoRepository = serviceProvider.GetRequiredService<IRepository<SkillMongoEntity>>();
            });

			//Assert
			Assert.Null(exception);

            Assert.NotNull(certificationService);
            Assert.NotNull(contactService);
            Assert.NotNull(eductionService);
            Assert.NotNull(experienceService);
            Assert.NotNull(skillService);

            Assert.NotNull(certificationMongoRepository);
            Assert.NotNull(contactMongoRepository);
            Assert.NotNull(educationMongoRepository);
            Assert.NotNull(experienceMongoRepository);
            Assert.NotNull(skillMongoRepository);
        }

		[Theory]
		[InlineData("Abc")]
		[InlineData("")]
		public void WhenUnknownDbType_ExceptionThrown(string dbType)
		{
            //Arrange

            IRepository<CertificationSqlEntity> certificationSqlRepository = null;
            IRepository<ContactSqlEntity> contactSqlRepository = null;
            IRepository<EducationSqlEntity> educationSqlRepository = null;
            IRepository<ExperienceSqlEntity> experienceSqlRepository = null;
            IRepository<SkillSqlEntity> skillSqlRepository = null;

            IRepository<CertificationMongoEntity> certificationMongoRepository = null;
            IRepository<ContactMongoEntity> contactMongoRepository = null;
            IRepository<EducationMongoEntity> educationMongoRepository = null;
            IRepository<ExperienceMongoEntity> experienceMongoRepository = null;
            IRepository<SkillMongoEntity> skillMongoRepository = null;

            var serviceCollection = new ServiceCollection();
			var builder = new ConfigurationBuilder();
			builder.AddInMemoryCollection(new List<KeyValuePair<string, string>>()
			{
				new ("DbConnectionOptions:UseDbType", dbType)
			});
			var configuration = builder.Build();
			serviceCollection.AddSingleton<IConfiguration>(configuration);

			//Act
			var exception = Record.Exception(() =>
			{
				serviceCollection.AddResumeServices(configuration);
				var serviceProvider = serviceCollection.BuildServiceProvider();

                certificationSqlRepository = serviceProvider.GetRequiredService<IRepository<CertificationSqlEntity>>();
                contactSqlRepository = serviceProvider.GetRequiredService<IRepository<ContactSqlEntity>>();
                educationSqlRepository = serviceProvider.GetRequiredService<IRepository<EducationSqlEntity>>();
                experienceSqlRepository = serviceProvider.GetRequiredService<IRepository<ExperienceSqlEntity>>();
                skillSqlRepository = serviceProvider.GetRequiredService<IRepository<SkillSqlEntity>>();

                certificationMongoRepository = serviceProvider.GetRequiredService<IRepository<CertificationMongoEntity>>();
                contactMongoRepository = serviceProvider.GetRequiredService<IRepository<ContactMongoEntity>>();
                educationMongoRepository = serviceProvider.GetRequiredService<IRepository<EducationMongoEntity>>();
                experienceMongoRepository = serviceProvider.GetRequiredService<IRepository<ExperienceMongoEntity>>();
                skillMongoRepository = serviceProvider.GetRequiredService<IRepository<SkillMongoEntity>>();
            });

			//Assert
			Assert.NotNull(exception);

            Assert.Null(certificationSqlRepository);
            Assert.Null(contactSqlRepository);
            Assert.Null(educationSqlRepository);
            Assert.Null(experienceSqlRepository);
            Assert.Null(skillSqlRepository);

            Assert.Null(certificationMongoRepository);
            Assert.Null(contactMongoRepository);
            Assert.Null(educationMongoRepository);
            Assert.Null(experienceMongoRepository);
            Assert.Null(skillMongoRepository);
        }
	}
}
