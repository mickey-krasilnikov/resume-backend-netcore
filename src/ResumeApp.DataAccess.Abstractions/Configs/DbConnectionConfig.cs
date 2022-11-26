using ResumeApp.DataAccess.Abstractions.Enums;

namespace ResumeApp.DataAccess.Abstractions.Options
{
	public class DbConnectionConfig
	{

		public const string DbConnection = "DbConnection";

		public SupportedDbType DbType { get; set; } = SupportedDbType.NotSupported;

		public string DbName { get; set; } = string.Empty;

		public string ConnectionString { get; set; } = string.Empty;

		public int MaxRetryCount { get; set; } = 3;
	}
}