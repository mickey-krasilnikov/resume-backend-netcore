using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.DataAccess.Sql.Context;

namespace ResumeApp.DataAccess.Sql.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddResumeSqlDb(this IServiceCollection services, IConfiguration config)
		{
			if (config == null) throw new ArgumentNullException(nameof(config));

			services.AddDbContext<ResumeDbContext>(options =>
				options.UseSqlServer(
					config.GetConnectionString("Sql"),
					o => o.EnableRetryOnFailure(3)));

			return services;
		}
	}
}