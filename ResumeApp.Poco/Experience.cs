namespace ResumeApp.Poco
{
	public class Experience
	{
		public string Title { get; set; }
		public string Company { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public List<Project> Projects { get; set; }
	}
}