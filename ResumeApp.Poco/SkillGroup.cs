namespace ResumeApp.Poco
{
	public class SkillGroup
	{
		public string Name { get; set; }
		public List<SkillGroup> SubGroups { get; set; }
		public List<Skill> Skills { get; set; }
	}
}