using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.DataAccess.Mongo.Extensions;
using ResumeApp.DataAccess.Sql.Extensions;

namespace ResumeApp.BusinessLogic.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddResumeServices(this IServiceCollection services, IConfiguration config)
		{
			if (config == null) throw new ArgumentNullException(nameof(config));

			services.AddResumeSqlDb(config);

			services.AddResumeMongoDb(config);

			//services.AddScoped<IResumeService, ResumeService>();

			//services.AddScoped<IValidator<FullResume>, ResumeValidator>();

			return services;
		}
	}
}