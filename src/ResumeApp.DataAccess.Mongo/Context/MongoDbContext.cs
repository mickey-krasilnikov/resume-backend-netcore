using Microsoft.Extensions.Configuration;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using ResumeApp.DataAccess.Mongo.Attributes;
using ResumeApp.DataAccess.Mongo.Exceptions;

namespace ResumeApp.DataAccess.Mongo.Context
{
	public class MongoDbContext<TMongoCollection> : IMongoDbContext<TMongoCollection> where TMongoCollection : class
	{
		public IMongoCollection<TMongoCollection> Collection { get; }

		public MongoDbContext(IConfiguration configuration)
		{
			var connectionString = configuration.GetConnectionString("Mongo");
			if (string.IsNullOrEmpty(connectionString))
			{
				throw new ArgumentException("Connection string for MongoDb should not be empty");
			}

			var attributes = typeof(TMongoCollection).GetCustomAttributes(typeof(BsonCollectionAttribute), true);
			if (attributes.Length == 0)
			{
				throw new ArgumentException($"Type '{typeof(TMongoCollection)}' does not have attribute BsonCollectionAttribute");
			}

			var conventionPack = new ConventionPack { new CamelCaseElementNameConvention() };
			ConventionRegistry.Register("camelCase", conventionPack, _ => true);

			var dbName = MongoUrl.Create(connectionString).DatabaseName;
			var db = new MongoClient(connectionString).GetDatabase(dbName);

			Collection = db.GetCollection<TMongoCollection>(GetCollectionName(typeof(TMongoCollection)));
		}

		public static FilterDefinition<TMongoCollection> GetFilterById(Guid id) => Builders<TMongoCollection>.Filter.Eq("_id", id);

		public static FilterDefinition<TMongoCollection> GetEmptyFilter() => Builders<TMongoCollection>.Filter.Empty;

		private protected static string GetCollectionName(Type documentType)
		{
			if (documentType is null) throw new ArgumentNullException(nameof(documentType));

			var collectionAttribute = documentType.GetCustomAttributes(typeof(BsonCollectionAttribute), true).FirstOrDefault();
			if (collectionAttribute == null) throw new BsonCollectionAttributeMissingException();

			return ((BsonCollectionAttribute)collectionAttribute).CollectionName;
		}
	}
}
