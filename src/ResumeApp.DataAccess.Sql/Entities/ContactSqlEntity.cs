using ResumeApp.DataAccess.Abstractions.Entities;
using System.ComponentModel.DataAnnotations;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class ContactSqlEntity : IContactEntity
	{
		[Key]
		public string Key { get; set; }

		[Required]
		public string Value { get; set; }


		public Guid ResumeId { get; internal set; }

		public ResumeSqlEntity Resume { get; set; }
	}
}
