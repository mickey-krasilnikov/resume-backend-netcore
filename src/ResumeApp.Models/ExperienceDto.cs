using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ResumeApp.Models.Interfaces;
using ResumeApp.Models.JsonCoverters;

namespace ResumeApp.Models
{
	public class ExperienceDto : IHasId
	{
		public Guid Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Company { get; set; }

		[Required]
		public string Location { get; set; }

		public IReadOnlyList<Guid> SkillIds { get; set; }

		public IReadOnlyList<string> TaskPerformed { get; set; }

		[Required]
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly StartDate { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? EndDate { get; set; }
	}
}