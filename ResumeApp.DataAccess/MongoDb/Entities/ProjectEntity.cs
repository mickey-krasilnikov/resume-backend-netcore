namespace ResumeApp.DataAccess.MongoDb.Entities
{
	public class ProjectEntity
	{
		public string Client { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public List<string> ProjectRole { get; set; }
		public List<string> Envirnment { get; set; }
		public List<string> TaskPerformed { get; set; }
	}
}