using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Poco
{
	public class ShortResume
	{
		public Guid Id { get; set; }

		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		[Required]
		public string Title { get; set; }

		public IReadOnlyDictionary<string, string> Contacts { get; set; }

		public double YearsOfExperience { get; set; }
	}
}