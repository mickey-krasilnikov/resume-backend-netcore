using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Poco
{
	public class Certification
	{
		public Guid Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Issuer { get; set; }

		[Required]
		public DateOnly IssueDate { get; set; }

		public DateOnly? ExpirationDate { get; set; }

		public Uri VerificationUrl { get; set; }
	}
}