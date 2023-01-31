using Microsoft.Extensions.DependencyInjection;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Mongo.Context;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Mongo.Repositories;

namespace ResumeApp.DataAccess.Mongo.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddMongoResumeDb(this IServiceCollection services)
		{
			services.AddScoped(typeof(IMongoDbContext<>), typeof(MongoDbContext<>));
			services.AddScoped<IRepository<CertificationMongoEntity>, CertificationMongoRepository>();
			services.AddScoped<IRepository<ContactMongoEntity>, ContactsMongoRepository>();
			services.AddScoped<IRepository<EducationMongoEntity>, EducationMongoRepository>();
			services.AddScoped<IRepository<ExperienceMongoEntity>, ExperienceMongoRepository>();
			services.AddScoped<IRepository<SkillMongoEntity>, SkillsMongoRepository>();
			return services;
		}
	}
}