using ResumeApp.BusinessLogic.Enums;

namespace ResumeApp.BusinessLogic.Configs
{
	public class CorsOptions
	{
		public const string SectionName = "Cors";

		public IReadOnlyList<string> AllowedOrigins { get; set; }
}
}
