using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.DataAccess.Abstractions.Options;
using ResumeApp.DataAccess.Sql.Context;

namespace ResumeApp.DataAccess.Sql.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddResumeSqlDb(this IServiceCollection services, DbConnectionConfig dbConnectionOptions)
		{
			if (dbConnectionOptions == null) throw new ArgumentNullException(nameof(dbConnectionOptions));

			services.AddDbContext<ResumeDbContext>(options =>
				options.UseSqlServer(
					dbConnectionOptions.ConnectionString,
					o => o.EnableRetryOnFailure(dbConnectionOptions.MaxRetryCount)));

			return services;
		}
	}
}