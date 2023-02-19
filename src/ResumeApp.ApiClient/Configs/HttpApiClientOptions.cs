using System;
namespace ResumeApp.ApiClient.Configs
{
	public class HttpApiClientOptions
	{
        private const int _defaultRetryCount = 5;
        private const int _defaultRetryDelayMilliseconds = 1000;

        public const string SectionName = "HttpApiClient";

        public string BaseUrl { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int RetryCount { get; set; } = _defaultRetryCount;

        public TimeSpan RetryDelay { get; set; } = TimeSpan.FromMilliseconds(_defaultRetryDelayMilliseconds);
    }
}

