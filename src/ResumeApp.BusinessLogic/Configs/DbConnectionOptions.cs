using ResumeApp.BusinessLogic.Enums;

namespace ResumeApp.BusinessLogic.Configs
{
	public class DbConnectionOptions
	{
		public const string SectionName = "DbConnectionOptions";

		public SupportedDbType UseDbType { get; set; }
		public int SqlMaxReties { get; set; }
	}
}
