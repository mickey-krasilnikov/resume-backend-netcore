using ResumeApp.BusinessLogic.Enums;

namespace ResumeApp.BusinessLogic.Configs
{
	public class DbConnectionOptions
	{
		public const string SectionName = "DbConnectionOptions";
		private const int _defaultMaxRetries = 3;

		public SupportedDbType UseDbType { get; set; }

		public int SqlMaxRetries { get; set; } = _defaultMaxRetries;
	}
}
