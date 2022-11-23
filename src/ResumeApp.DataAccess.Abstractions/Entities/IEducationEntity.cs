namespace ResumeApp.DataAccess.Abstractions.Entities
{
	public interface IEducationEntity
	{
		Guid Id { get; set; }
		string Name { get; set; }
		string Degree { get; set; }
		string FieldOfStudy { get; set; }
		DateOnly StartDate { get; set; }
		DateOnly EndDate { get; set; }
		Uri Url { get; set; }
	}
}