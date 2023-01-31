using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Models
{
	public class SkillDto : IHasId
	{
		public Guid Id { get; set; }

		[Required]
		public string Name { get; set; }

		public string AdditionalInfo { get; set; }

		public string SkillGroup { get; set; }
	}
}