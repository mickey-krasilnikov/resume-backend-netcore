using Microsoft.Extensions.DependencyInjection;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Mongo.Context;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Mongo.Repositories;

namespace ResumeApp.DataAccess.Mongo.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddResumeMongoDb(this IServiceCollection services)
		{
			services.AddScoped(typeof(IMongoDbContext<>), typeof(MongoDbContext<>));
			services.AddScoped<IRepository<ResumeMongoEntity>, MongoResumeRepository>();
			return services;
		}
	}
}