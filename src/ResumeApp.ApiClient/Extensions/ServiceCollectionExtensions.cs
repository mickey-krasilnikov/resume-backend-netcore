using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Polly;
using ResumeApp.ApiClient.Configs;

namespace ResumeApp.ApiClient.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IHttpClientBuilder AddHttpClientConsumer<TContract, TImplementation>(this IServiceCollection services, IConfiguration config)
			where TContract : class
			where TImplementation:class, TContract
		{
			var apiConfig = config.GetSection(HttpApiClientOptions.SectionName).Get<HttpApiClientOptions>();
			return services
				.AddHttpClient<TContract, TImplementation>(client => client.BaseAddress = new Uri(apiConfig.BaseUrl))
				.AddTransientHttpErrorPolicy(policy => policy.WaitAndRetryAsync(apiConfig.RetryCount, _ => apiConfig.RetryDelay));
				
		}
	}
}

