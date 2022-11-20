namespace ResumeApp.DataAccess.Mongo.Entities
{
	public class ExperienceMongoEntity
	{
		public long Id { get; set; }

		public string Title { get; set; }

		public string Company { get; set; }

		public DateOnly StartDate { get; set; }

		public DateOnly EndDate { get; set; }


		public ICollection<ProjectMongoEntity> Projects { get; set; } = new HashSet<ProjectMongoEntity>();
	}
}