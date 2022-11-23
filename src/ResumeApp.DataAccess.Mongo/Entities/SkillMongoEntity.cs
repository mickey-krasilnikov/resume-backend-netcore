using ResumeApp.DataAccess.Abstractions.Entities;

namespace ResumeApp.DataAccess.Mongo.Entities
{
	public class SkillMongoEntity : ISkillEntity
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string AdditionalInfo { get; set; }

		public string SkillGroup { get; set; }
	}
}