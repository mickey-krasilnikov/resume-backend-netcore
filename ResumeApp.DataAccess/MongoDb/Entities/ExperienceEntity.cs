namespace ResumeApp.DataAccess.MongoDb.Entities
{
	public class ExperienceEntity
	{
		public string Title { get; set; }
		public string Company { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public List<ProjectEntity> Projects { get; set; }
	}
}