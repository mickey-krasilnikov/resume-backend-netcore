namespace ResumeApp.Poco
{
	public class ShortResume
	{
		public Guid Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Title { get; set; }
		public IReadOnlyDictionary<string, string> Contacts { get; set; }
		public double YearsOfExperience { get; set; }
	}
}