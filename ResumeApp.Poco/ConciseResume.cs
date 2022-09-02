namespace ResumeApp.Poco
{
	public class ConciseResume
	{
		public string ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Title { get; set; }
		public Dictionary<string, string> Contacts { get; set; }
		public List<string> MainSkills { get; set; }
		public double YearsOfExperience { get; set; }
	}
}