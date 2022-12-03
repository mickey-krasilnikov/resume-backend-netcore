using System.ComponentModel.DataAnnotations;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class ContactSqlEntity
	{
		[Key]
		public string Key { get; set; }

		[Required]
		public string Value { get; set; }


		public Guid ResumeId { get; internal set; }

		public ResumeSqlEntity Resume { get; set; }
	}
}
