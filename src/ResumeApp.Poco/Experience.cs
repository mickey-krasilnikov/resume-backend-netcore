using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Poco
{
	public class Experience
	{
		public Guid Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Company { get; set; }

		[Required]
		public DateOnly StartDate { get; set; }

		public DateOnly? EndDate { get; set; }

		public IReadOnlyList<Project> Projects { get; set; }
	}
}