using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.BusinessLogic.Configs;
using ResumeApp.BusinessLogic.Enums;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.DataAccess.Mongo.Extensions;
using ResumeApp.DataAccess.Sql.Extensions;

namespace ResumeApp.BusinessLogic.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddResumeServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<IResumeService, ResumeService>();

			var dbOptions = configuration.GetSection(DbConnectionOptions.SectionName).Get<DbConnectionOptions>();
			switch (dbOptions.UseDbType)
			{
				case SupportedDbType.Mongo:
					services.AddResumeMongoDb();
					break;

				case SupportedDbType.Sql:
					services.AddResumeSqlDb(configuration, dbOptions.SqlMaxReties);
					break;
			}

			return services;
		}
	}
}