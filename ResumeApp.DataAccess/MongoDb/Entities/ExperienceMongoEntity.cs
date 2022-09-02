namespace ResumeApp.DataAccess.MongoDb.Entities
{
	public class ExperienceMongoEntity
	{
		public string Title { get; set; }
		public string Company { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public List<ProjectMongoEntity> Projects { get; set; }
	}
}