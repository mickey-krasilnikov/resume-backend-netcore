using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Sql.Context;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.DataAccess.Sql.Repositories;

namespace ResumeApp.DataAccess.Sql.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddResumeSqlDb(this IServiceCollection services, IConfiguration configuration, int maxReties)
		{
			var connectionString = configuration.GetConnectionString("Sql");
			services.AddDbContext<SqlDbContext>(options => options.UseSqlServer(connectionString, o => o.EnableRetryOnFailure(maxReties)));
			services.AddScoped<IRepository<ResumeSqlEntity>, SqlResumeRepository>();
			return services;
		}
	}
}