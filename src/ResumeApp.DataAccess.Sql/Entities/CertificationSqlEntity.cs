using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class CertificationSqlEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Issuer { get; set; }

		public Uri VerificationUrl { get; set; }

		public DateOnly IssueDate { get; set; }

		public DateOnly? ExpirationDate { get; set; }
	}
}
