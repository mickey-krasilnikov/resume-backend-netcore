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
		public static IServiceCollection AddSqlResumeDb(this IServiceCollection services, IConfiguration configuration, int maxReties)
		{
			var connectionString = configuration.GetConnectionString("Sql");
			services.AddDbContext<ISqlDbContext, SqlDbContext>(options => options.UseSqlServer(connectionString, o =>
			{
				o.EnableRetryOnFailure(maxReties);
				o.MigrationsAssembly("ResumeApp.WebApi");
            }));
			services.AddScoped<IRepository<CertificationSqlEntity>, CertificationSqlRepository>();
			services.AddScoped<IRepository<ContactSqlEntity>, ContactsSqlRepository>();
			services.AddScoped<IRepository<EducationSqlEntity>, EducationSqlRepository>();
			services.AddScoped<IRepository<ExperienceSqlEntity>, ExperienceSqlRepository>();
			services.AddScoped<IRepository<SkillSqlEntity>, SkillsSqlRepository>();
			return services;
		}
	}
}