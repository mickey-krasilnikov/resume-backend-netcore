using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Mongo.Configs;
using ResumeApp.DataAccess.Mongo.Repositories;

namespace ResumeApp.DataAccess.Mongo.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddResumeMongoDb(this IServiceCollection services, IConfiguration config)
		{
			if (config == null) throw new ArgumentNullException(nameof(config));

			// MongoDB
			services.AddSingleton(config.GetSection("MongoDb").Get<MongoDbConfig>());
			services.AddScoped(typeof(IRepository<>), typeof(MongoResumeRepository));

			return services;
		}
	}
}