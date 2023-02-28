using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ResumeApp.Models.Interfaces;
using ResumeApp.Models.JsonCoverters;

namespace ResumeApp.Models
{
	public class CertificationDto : IHasId
	{
		public Guid Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Issuer { get; set; }

		public Uri VerificationUrl { get; set; }

		[Required]
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly IssueDate { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ExpirationDate { get; set; }
	}
}