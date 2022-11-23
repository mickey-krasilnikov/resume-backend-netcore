namespace ResumeApp.Poco
{
	public class FullResume
	{
		public Guid Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Title { get; set; }
		public string Summary { get; set; }
		public IReadOnlyDictionary<string, string> Contacts { get; set; }
		public IReadOnlyList<Skill> Skills { get; set; }
		public IReadOnlyList<Experience> Experience { get; set; }
		public IReadOnlyList<Certification> Certifications { get; set; }
		public IReadOnlyList<Education> Education { get; set; }
	}
}