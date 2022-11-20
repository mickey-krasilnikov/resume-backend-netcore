namespace ResumeApp.Poco
{
	public class FullResume
	{
		public string ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Title { get; set; }
		public Dictionary<string, string> Contacts { get; set; }
		public List<string> Summary { get; set; }
		public List<Skill> Skills { get; set; }
		public List<Experience> Experience { get; set; }
		public List<Certification> Certifications { get; set; }
		public List<Education> Education { get; set; }
	}
}