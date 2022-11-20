namespace ResumeApp.Poco
{
	public class Skill
	{
		public string Name { get; set; }
		public string AdditionalInfo { get; set; }
		public ICollection<Skill> Children { get; set; }
	}
}