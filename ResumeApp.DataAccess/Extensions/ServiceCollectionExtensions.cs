
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using ResumeApp.DataAccess.MongoDb;
using ResumeApp.DataAccess.MongoDb.Configs;
using ResumeApp.DataAccess.Sql;

namespace ResumeApp.DataAccess.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddResumeMongoDb(this IServiceCollection services, IConfiguration config)
		{
			if (config == null) throw new ArgumentNullException(nameof(config));

			// MongoDB
			services.AddSingleton(config.GetSection("MongoDb").Get<MongoDbConfig>());
			services.AddScoped(typeof(IResumeRepository<>), typeof(MongoResumeRepository<>));

			// SQL
			services.AddDbContext<ResumeDbContext>(options =>
			{
				options.UseSqlServer(config.GetConnectionString("Sql"));
			});

			return services;
		}

		public static IServiceCollection AddResumePostgreSqlDb(this IServiceCollection services, IConfiguration config)
		{
			throw new NotImplementedException();
		}
	}
}