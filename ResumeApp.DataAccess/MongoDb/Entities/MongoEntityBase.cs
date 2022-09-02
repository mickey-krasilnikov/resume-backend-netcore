using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ResumeApp.DataAccess.MongoDb.Entities
{
	public abstract class MongoEntityBase : IEntity
	{
		[BsonId]
		[BsonRepresentation(BsonType.String)]
		public ObjectId Id { get; set; }

		public DateTime CreatedAt => Id.CreationTime;
	}
}
