using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using ResumeApp.DataAccess.Mongo.Attributes;

namespace ResumeApp.DataAccess.Mongo.Entities
{
	[BsonCollection("skills")]
	public class SkillMongoEntity
	{
		[BsonId(IdGenerator = typeof(GuidGenerator))]
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string SkillGroup { get; set; }

        public Guid[] ExperienceIds { get; set; }
    }
}