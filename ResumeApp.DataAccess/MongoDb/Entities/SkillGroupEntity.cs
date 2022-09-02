namespace ResumeApp.DataAccess.MongoDb.Entities
{
	public class SkillGroupEntity
	{
		public string Name { get; set; }
		public List<SkillGroupEntity> SubGroups { get; set; }
		public List<SkillEntity> Skills { get; set; }
	}
}