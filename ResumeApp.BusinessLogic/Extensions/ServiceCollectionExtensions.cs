using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.BusinessLogic.Validations;
using ResumeApp.DataAccess.Extensions;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddResumeServices(this IServiceCollection services, IConfiguration config)
		{
			if (config == null) throw new ArgumentNullException(nameof(config));

			services.AddResumeMongoDb(config);

			services.AddScoped<IResumeService, ResumeService>();

			services.AddScoped<IValidator<FullResume>, ResumeValidator>();

			return services;
		}
	}
}