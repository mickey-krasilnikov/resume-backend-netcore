using System.ComponentModel.DataAnnotations;
using ResumeApp.Models.Interfaces;

namespace ResumeApp.Models
{
	public class ContactDto : IHasId
	{
		public Guid Id { get; set; }

		[Required]
		public string Key { get; set; }

		[Required]
		public string Value { get; set; }

        public string Link { get; set; }
    }
}