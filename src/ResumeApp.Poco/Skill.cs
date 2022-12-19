using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Poco
{
	public class Skill
	{
		public Guid Id { get; set; }

		[Required]
		public string Name { get; set; }

		public string AdditionalInfo { get; set; }

		public string SkillGroup { get; set; }
	}
}