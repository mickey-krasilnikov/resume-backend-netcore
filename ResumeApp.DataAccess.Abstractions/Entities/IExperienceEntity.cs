namespace ResumeApp.DataAccess.Abstractions.Entities
{
	public interface IExperienceEntity
	{
		public string Title { get; set; }
		public string Company { get; set; }
		public DateOnly StartDate { get; set; }
		public DateOnly EndDate { get; set; }
		public ICollection<IProjectEntity> Projects { get; set; }
	}
}
