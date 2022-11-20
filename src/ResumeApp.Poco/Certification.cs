namespace ResumeApp.Poco
{
	public class Certification
	{
		public string Name { get; set; }
		public string Issuer { get; set; }
		public DateTime IssueDate { get; set; }
		public DateTime ExpirationDate { get; set; }
		public Uri VerificationURL { get; set; }
	}
}