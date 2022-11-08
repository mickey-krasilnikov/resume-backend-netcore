using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Mongo.Attributes;

namespace ResumeApp.DataAccess.Mongo.Entities
{
	[BsonCollection("resumes")]
	public class ResumeMongoEntity : IEntity
	{
		[BsonId(IdGenerator = typeof(GuidGenerator))]
		public Guid Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Title { get; set; }

		public string Summary { get; set; }

		public ICollection<ContactMongoEntity> Contacts { get; set; } = new HashSet<ContactMongoEntity>();

		public ICollection<SkillMongoEntity> Skills { get; set; } = new HashSet<SkillMongoEntity>();

		public ICollection<ExperienceMongoEntity> Experience { get; set; } = new HashSet<ExperienceMongoEntity>();

		public ICollection<CertificationMongoEntity> Certifications { get; set; } = new HashSet<CertificationMongoEntity>();

		public ICollection<EducationMongoEntity> Education { get; set; } = new HashSet<EducationMongoEntity>();
	}
}