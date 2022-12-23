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

		public bool IsCurrentCompany { get; set; }

		public DateOnly? EndDate { get; set; }

		public IEnumerable<Project> Projects { get; set; }
	}
}