using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeApp.DataAccess.Sql.Entities
{
	[Index(nameof(Key), IsUnique = true)]
	public class ContactSqlEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		[Required]
		public string Key { get; set; }

		[Required]
		public string Value { get; set; }

        public string Link { get; set; }
    }
}
