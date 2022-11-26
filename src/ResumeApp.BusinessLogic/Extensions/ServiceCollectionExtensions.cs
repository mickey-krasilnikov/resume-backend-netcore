using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.DataAccess.Abstractions.Enums;
using ResumeApp.DataAccess.Abstractions.Options;
using ResumeApp.DataAccess.Mongo.Extensions;
using ResumeApp.DataAccess.Sql.Extensions;

namespace ResumeApp.BusinessLogic.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddResumeServices(this IServiceCollection services, IConfiguration config)
		{
			if (config == null) throw new ArgumentNullException(nameof(config));

			var dbConnectionOptions = config.GetSection(DbConnectionConfig.DbConnection).Get<DbConnectionConfig>();
			services.AddSingleton(dbConnectionOptions);

			switch (dbConnectionOptions.DbType)
			{
				case SupportedDbType.Mongo:
					services.AddResumeMongoDb(dbConnectionOptions);
					break;
				case SupportedDbType.MsSql:
					services.AddResumeSqlDb(dbConnectionOptions);
					break;
				default:
					throw new NotSupportedException($"{dbConnectionOptions.DbType} DB type is not supported");
			}

			return services;
		}
	}
}