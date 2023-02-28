using System.ComponentModel.DataAnnotations;
using ResumeApp.Models.Interfaces;

namespace ResumeApp.Models
{
    public class SkillDto : IHasId
	{
		public Guid Id { get; set; }

		[Required]
		public string Name { get; set; }

		public string SkillGroup { get; set; }

        public IReadOnlyList<Guid> ExperienceIds { get; set; }
    }
}