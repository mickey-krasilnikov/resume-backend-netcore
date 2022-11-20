namespace ResumeApp.DataAccess.Abstractions.Entities
{
	public interface IProjectEntity
	{
		public string Client { get; set; }
		public DateOnly StartDate { get; set; }
		public DateOnly EndDate { get; set; }
		public string ProjectRoles { get; set; }
		public string Envirnment { get; set; }
		public string TaskPerformed { get; set; }
	}
}
