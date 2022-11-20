namespace ResumeApp.DataAccess.Mongo.Entities
{
	public class ProjectMongoEntity
	{
		public long Id { get; set; }

		public string Client { get; set; }

		public DateOnly StartDate { get; set; }

		public DateOnly EndDate { get; set; }

		public string ProjectRoles { get; set; }

		public string Envirnment { get; set; }

		public string TaskPerformed { get; set; }
	}
}