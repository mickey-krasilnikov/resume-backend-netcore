using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using ResumeApp.DataAccess.Mongo.Attributes;

namespace ResumeApp.DataAccess.Mongo.Entities
{
	[BsonCollection("experiences")]
	public class ExperienceMongoEntity
	{
		[BsonId(IdGenerator = typeof(GuidGenerator))]
		public Guid Id { get; set; }

		public string Title { get; set; }

		public string Company { get; set; }

		public string Location { get; set; }

		public string TaskPerformed { get; set; }

		public Guid[] SkillIds { get; set; }

		public DateOnly StartDate { get; set; }

		public DateOnly? EndDate { get; set; }
	}
}