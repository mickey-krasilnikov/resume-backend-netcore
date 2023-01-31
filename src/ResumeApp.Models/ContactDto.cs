namespace ResumeApp.Models
{
	public class ContactDto : IHasId
	{
		public Guid Id { get; set; }

		public string Key { get; set; }

		public string Value { get; set; }
	}
}