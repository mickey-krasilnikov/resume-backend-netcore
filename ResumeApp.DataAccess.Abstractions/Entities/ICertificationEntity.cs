namespace ResumeApp.DataAccess.Abstractions.Entities
{
	public interface ICertificationEntity
	{
		public string Name { get; set; }

		public string Issuer { get; set; }

		public DateOnly IssueDate { get; set; }

		public DateOnly ExpirationDate { get; set; }

		public Uri VerificationUrl { get; set; }
	}
}
