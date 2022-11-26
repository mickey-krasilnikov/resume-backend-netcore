using Microsoft.Extensions.DependencyInjection;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Abstractions.Options;
using ResumeApp.DataAccess.Mongo.Repositories;

namespace ResumeApp.DataAccess.Mongo.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddResumeMongoDb(this IServiceCollection services, DbConnectionConfig dbConnectionOptions)
		{
			if (dbConnectionOptions == null) throw new ArgumentNullException(nameof(dbConnectionOptions));

			services.AddScoped(typeof(IRepository<>), typeof(MongoResumeRepository));

			return services;
		}
	}
}