using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ResumeApp.Models.Interfaces;
using ResumeApp.Models.JsonCoverters;

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
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly StartDate { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? EndDate { get; set; }
	}
}