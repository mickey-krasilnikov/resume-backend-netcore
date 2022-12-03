using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.DataAccess.Mongo.Context;
using ResumeApp.DataAccess.Mongo.Repositories;

namespace ResumeApp.DataAccess.Mongo.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddResumeMongoDb(this IServiceCollection services)
		{
			services.AddScoped(typeof(IMongoDbContext<>), typeof(MongoDbContext<>));
			services.AddScoped<IMongoResumeRepository, MongoResumeRepository>();
			return services;
		}
	}
}