using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Models
{
	public class ExperienceDto : IHasId
	{
		public Guid Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Company { get; set; }

		public string Location { get; set; }

		public SkillDto[] Environment { get; set; }

		public string[] TaskPerformed { get; set; }

		[Required]
		public DateOnly StartDate { get; set; }

		public DateOnly? EndDate { get; set; }
	}
}