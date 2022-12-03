using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.DataAccess.Sql.Context;
using ResumeApp.DataAccess.Sql.Repositories;

namespace ResumeApp.DataAccess.Sql.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddResumeSqlDb(this IServiceCollection services, IConfiguration configuration)
		{
			var connectionString = configuration.GetConnectionString("Sql");
			services.AddDbContext<SqlDbContext>(options => options.UseSqlServer(connectionString, o => o.EnableRetryOnFailure(3)));
			services.AddScoped<ISqlResumeRepository, SqlResumeRepository>();
			return services;
		}
	}
}