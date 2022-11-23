namespace ResumeApp.Poco
{
	public class Experience
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Company { get; set; }
		public DateOnly StartDate { get; set; }
		public DateOnly? EndDate { get; set; }
		public IReadOnlyList<Project> Projects { get; set; }
	}
}