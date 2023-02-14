using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Models
{
	public class EducationDto : IHasId
	{
		public Guid Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Degree { get; set; }

		public string FieldOfStudy { get; set; }

		public Uri Url { get; set; }

		[Required]
		public DateOnly StartDate { get; set; }

		public DateOnly? EndDate { get; set; }
	}
}