namespace ResumeApp.DataAccess.Abstractions.Entities
{
	public interface IExperienceEntity
	{
		Guid Id { get; set; }
		string Title { get; set; }
		string Company { get; set; }
		DateOnly StartDate { get; set; }
		DateOnly? EndDate { get; set; }
		bool IsCurrentCompany { get; set; }
		IEnumerable<IProjectEntity> Projects { get; set; }
	}
}