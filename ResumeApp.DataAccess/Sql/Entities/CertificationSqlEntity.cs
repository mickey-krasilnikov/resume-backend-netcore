using System.ComponentModel.DataAnnotations;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class CertificationSqlEntity : SqlEntityBase
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Issuer { get; set; }
		public DateTime IssueDate { get; set; }
		public DateTime ExpirationDate { get; set; }
		public Uri VerificationURL { get; set; }
	}
}
