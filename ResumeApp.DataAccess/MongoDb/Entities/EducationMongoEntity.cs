namespace ResumeApp.DataAccess.MongoDb.Entities
{
	public class EducationMongoEntity
	{
		public string Name { get; set; }
		public string Degree { get; set; }
		public string FieldOfStudy { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public Uri Url { get; set; }
	}
}