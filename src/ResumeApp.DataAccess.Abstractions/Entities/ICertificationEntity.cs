namespace ResumeApp.DataAccess.Abstractions.Entities
{
	public interface ICertificationEntity
	{
		Guid Id { get; set; }
		string Name { get; set; }
		string Issuer { get; set; }
		DateOnly IssueDate { get; set; }
		DateOnly ExpirationDate { get; set; }
		Uri VerificationUrl { get; set; }
	}
}