using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Poco
{
	public class Education
	{
		public Guid Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Degree { get; set; }

		public string FieldOfStudy { get; set; }

		[Required]
		public DateOnly StartDate { get; set; }

		public DateOnly? EndDate { get; set; }

		public Uri Url { get; set; }
	}
}