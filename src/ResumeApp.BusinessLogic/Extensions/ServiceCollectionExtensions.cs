using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.BusinessLogic.Configs;
using ResumeApp.BusinessLogic.Enums;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Mongo.Extensions;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.DataAccess.Sql.Extensions;

namespace ResumeApp.BusinessLogic.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddResumeServices(this IServiceCollection services, IConfiguration configuration)
		{
			var dbOptions = configuration.GetSection(DbConnectionOptions.SectionName).Get<DbConnectionOptions>();
			switch (dbOptions.UseDbType)
			{
				case SupportedDbType.Mongo:
					services.AddScoped<IResumeService, ResumeService<ResumeMongoEntity>>();
					services.AddResumeMongoDb();
					break;

				case SupportedDbType.Sql:
					services.AddScoped<IResumeService, ResumeService<ResumeSqlEntity>>();
					services.AddResumeSqlDb(configuration, dbOptions.SqlMaxReties);
					break;
			}

			return services;
		}
	}
}