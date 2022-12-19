using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Poco
{
	public class Project
	{
		public Guid Id { get; set; }

		[Required]
		public string Client { get; set; }

		[Required]
		public DateOnly StartDate { get; set; }

		public DateOnly? EndDate { get; set; }

		public string ProjectRoles { get; set; }

		public string Environment { get; set; }

		public string TaskPerformed { get; set; }
	}
}