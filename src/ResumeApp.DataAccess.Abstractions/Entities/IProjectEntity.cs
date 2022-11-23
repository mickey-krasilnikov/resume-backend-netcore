namespace ResumeApp.DataAccess.Abstractions.Entities
{
	public interface IProjectEntity
	{
		Guid Id { get; set; }
		string Client { get; set; }
		DateOnly StartDate { get; set; }
		DateOnly? EndDate { get; set; }
		bool IsCurrentProject { get; set; }
		string ProjectRoles { get; set; }
		string Environment { get; set; }
		string TaskPerformed { get; set; }
	}
}