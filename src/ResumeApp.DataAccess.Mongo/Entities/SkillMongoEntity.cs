namespace ResumeApp.DataAccess.Mongo.Entities
{
	public class SkillMongoEntity
	{
		public long Id { get; set; }

		public string Name { get; set; }

		public string AdditionalInfo { get; set; }

		public string SkillGroup { get; set; }
	}
}