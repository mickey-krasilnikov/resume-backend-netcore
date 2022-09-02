namespace ResumeApp.DataAccess.MongoDb.Entities
{
	public class SkillMongoEntity
	{
		public string Name { get; set; }
		public string AdditionalInfo { get; set; }
		public List<SkillMongoEntity> Children { get; set; }
	}
}