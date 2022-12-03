namespace ResumeApp.DataAccess.Mongo.Entities
{
	public class EducationMongoEntity
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Degree { get; set; }

		public string FieldOfStudy { get; set; }

		public DateOnly StartDate { get; set; }

		public DateOnly EndDate { get; set; }

		public Uri Url { get; set; }
	}
}