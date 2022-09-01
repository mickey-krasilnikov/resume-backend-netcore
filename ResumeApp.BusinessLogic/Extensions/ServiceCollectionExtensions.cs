using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.BusinessLogic.Validations;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddResumeServices(this IServiceCollection services)
		{
			services.AddScoped<IResumeService, ResumeService>();

			services.AddScoped<IValidator<Resume>, ResumeValidator>();

			return services;
		}
	}
}