using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using ResumeApp.DataAccess.Mongo.Attributes;

namespace ResumeApp.DataAccess.Mongo.Entities
{
	[BsonCollection("resumes")]
	public class ResumeMongoEntity
	{
		[BsonId(IdGenerator = typeof(GuidGenerator))]
		public Guid Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Title { get; set; }

		public string Summary { get; set; }

		public IEnumerable<ContactMongoEntity> Contacts { get; set; } = new HashSet<ContactMongoEntity>();

		public IEnumerable<SkillMongoEntity> Skills { get; set; } = new HashSet<SkillMongoEntity>();

		public IEnumerable<ExperienceMongoEntity> Experience { get; set; } = new HashSet<ExperienceMongoEntity>();

		public IEnumerable<CertificationMongoEntity> Certifications { get; set; } = new HashSet<CertificationMongoEntity>();

		public IEnumerable<EducationMongoEntity> Education { get; set; } = new HashSet<EducationMongoEntity>();
	}
}