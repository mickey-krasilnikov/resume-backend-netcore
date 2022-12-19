using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.BusinessLogic.Extensions;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;

namespace ElipsLife.Party.UnitTests.Extensions
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
			IResumeService resumeService = null;
			IRepository<ResumeSqlEntity> sqlRepo = null;
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
				resumeService = serviceProvider.GetRequiredService<IResumeService>();
				sqlRepo = serviceProvider.GetRequiredService<IRepository<ResumeSqlEntity>>();
			});

			//Assert
			Assert.Null(exception);
			Assert.NotNull(resumeService);
			Assert.NotNull(sqlRepo);
		}

		[Theory]
		[InlineData("Mongo")]
		[InlineData("mongo")]
		[InlineData("MONGO")]
		[InlineData("mOnGo")]
		public void WhenMongoDb_HappyPath(string mongoDbType)
		{
			//Arrange
			IResumeService resumeService = null;
			IRepository<ResumeMongoEntity> mongoRepo = null;
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
				resumeService = serviceProvider.GetRequiredService<IResumeService>();
				mongoRepo = serviceProvider.GetRequiredService<IRepository<ResumeMongoEntity>>();
			});

			//Assert
			Assert.Null(exception);
			Assert.NotNull(resumeService);
			Assert.NotNull(mongoRepo);
		}

		[Theory]
		[InlineData("Abc")]
		[InlineData("")]
		[InlineData(null)]
		public void WhenUnknownDbType_ExceptionThrown(string dbType)
		{
			//Arrange
			IResumeService resumeService = null;
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
				resumeService = serviceProvider.GetRequiredService<IResumeService>();
			});

			//Assert
			Assert.NotNull(exception);
			Assert.Null(resumeService);
		}
	}
}
