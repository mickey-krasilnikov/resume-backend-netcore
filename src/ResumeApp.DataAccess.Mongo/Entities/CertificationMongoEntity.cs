using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using ResumeApp.DataAccess.Mongo.Attributes;

namespace ResumeApp.DataAccess.Mongo.Entities
{
	[BsonCollection("certifications")]
	public class CertificationMongoEntity
	{
		[BsonId(IdGenerator = typeof(GuidGenerator))]
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Issuer { get; set; }

		public DateOnly IssueDate { get; set; }

		public DateOnly? ExpirationDate { get; set; }

		public Uri VerificationUrl { get; set; }
	}
}