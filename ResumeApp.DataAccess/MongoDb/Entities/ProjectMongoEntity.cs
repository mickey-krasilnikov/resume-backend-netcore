namespace ResumeApp.DataAccess.MongoDb.Entities
{
	public class ProjectMongoEntity
	{
		public string Client { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public List<string> ProjectRole { get; set; }
		public List<string> Envirnment { get; set; }
		public List<string> TaskPerformed { get; set; }
	}
}