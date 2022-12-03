namespace ResumeApp.DataAccess.Mongo.Entities
{
	public class SkillMongoEntity
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string AdditionalInfo { get; set; }

		public string SkillGroup { get; set; }
	}
}