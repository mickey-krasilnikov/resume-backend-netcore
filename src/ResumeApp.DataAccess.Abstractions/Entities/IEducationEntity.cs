namespace ResumeApp.DataAccess.Abstractions.Entities
{
	public interface IEducationEntity
	{
		public string Name { get; set; }
		public string Degree { get; set; }
		public string FieldOfStudy { get; set; }
		public DateOnly StartDate { get; set; }
		public DateOnly EndDate { get; set; }
		public Uri Url { get; set; }
	}
}
