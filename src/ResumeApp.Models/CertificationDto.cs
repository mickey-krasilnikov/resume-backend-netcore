using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Models
{
	public class CertificationDto : IHasId
	{
		public Guid Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Issuer { get; set; }

		public Uri VerificationUrl { get; set; }

		[Required]
		public DateOnly IssueDate { get; set; }

		public DateOnly? ExpirationDate { get; set; }
	}
}