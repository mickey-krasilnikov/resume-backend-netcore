namespace ResumeApp.DataAccess.Mongo.Entities
{
	public class ProjectMongoEntity
	{
		public Guid Id { get; set; }

		public string Client { get; set; }

		public DateOnly StartDate { get; set; }

		public DateOnly? EndDate { get; set; }

		public bool IsCurrentProject { get; set; }

		public string ProjectRoles { get; set; }

		public string Environment { get; set; }

		public string TaskPerformed { get; set; }
	}
}