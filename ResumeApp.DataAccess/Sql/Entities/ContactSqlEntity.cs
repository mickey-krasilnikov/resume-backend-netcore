using System.ComponentModel.DataAnnotations;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class ContactSqlEntity : SqlEntityBase
	{
		[Key]
		public string Key { get; set; }

		[Required]
		public string Value { get; set; }
	}
}
