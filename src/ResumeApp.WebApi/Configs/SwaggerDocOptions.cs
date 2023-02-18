using ResumeApp.BusinessLogic.Enums;

namespace ResumeApp.BusinessLogic.Configs
{
	public class SwaggerDocOptions
	{
		public const string SectionName = "SwaggerDoc";

        public string DocName { get; set; }

        public string Version { get; set; }

        public string Title { get; set; } 

        public string Description { get; set; }

        public string ContactName { get; set; }

        public string ContactEmail { get; set; }
    }
}
