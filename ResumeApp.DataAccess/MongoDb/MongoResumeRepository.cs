using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using ResumeApp.DataAccess.MongoDb.Attributes;
using ResumeApp.DataAccess.MongoDb.Configs;
using ResumeApp.DataAccess.MongoDb.Entities;
using ResumeApp.DataAccess.MongoDb.Exceptions;
using System.Linq.Expressions;

namespace ResumeApp.DataAccess.MongoDb
{
	public class MongoResumeRepository<TDocument> : IResumeRepository<TDocument> where TDocument : MongoEntityBase
	{
		private readonly IMongoCollection<TDocument> _collection;

		public MongoResumeRepository(MongoDbConfig settings)
		{
			if (settings is null) throw new ArgumentNullException(nameof(settings));

			var conventionPack = new ConventionPack { new CamelCaseElementNameConvention() };
			ConventionRegistry.Register("camelCase", conventionPack, _ => true);

			var database = new MongoClient(settings.ConnectionString).GetDatabase(settings.DatabaseName);
			_collection = database.GetCollection<TDocument>(MongoResumeRepository<TDocument>.GetCollectionName(typeof(TDocument)));
		}

		public async Task<IReadOnlyList<TDocument>> FilterByAsync(
			Expression<Func<TDocument, bool>> filterExpression)
		{
			return await _collection.Find(filterExpression).ToListAsync();
		}

		public async Task<IReadOnlyList<TProjected>> FilterByAsync<TProjected>(
			Expression<Func<TDocument, bool>> filterExpression,
			Expression<Func<TDocument, TProjected>> projectionExpression)
		{
			return await _collection.Find(filterExpression).Project(projectionExpression).ToListAsync();
		}

		public async Task<IReadOnlyList<TProjected>> ProjectAsync<TProjected>(Expression<Func<TDocument, TProjected>> projectionExpression)
		{
			return await _collection.Find(GetEmptyFilter()).Project(projectionExpression).ToListAsync();
		}

		public async Task<TDocument> FindOneAsync(Expression<Func<TDocument, bool>> filterExpression)
		{
			return await _collection.Find(filterExpression).FirstOrDefaultAsync();
		}

		public async Task<bool> CheckIfItemExistsAsync(string id)
		{
			var isParsed = ObjectId.TryParse(id, out var objectId);
			if (!isParsed) return false;
			var count = await _collection.CountDocumentsAsync(GetFilterById(objectId));
			return count == 1;
		}

		public async Task<TDocument> FindByIdAsync(string id)
		{
			var isParsed = ObjectId.TryParse(id, out var objectId);
			if (!isParsed) return null!;
			return await _collection.Find(GetFilterById(objectId)).SingleOrDefaultAsync();
		}

		public Task InsertOneAsync(TDocument document)
		{
			return Task.Run(() => _collection.InsertOneAsync(document));
		}

		public async Task InsertManyAsync(ICollection<TDocument> documents)
		{
			await _collection.InsertManyAsync(documents);
		}

		public async Task ReplaceOneAsync(TDocument document)
		{
			if (document is null) throw new ArgumentNullException(nameof(document));
			await _collection.FindOneAndReplaceAsync(GetFilterById(document.Id), document);
		}

		public async Task DeleteOneAsync(Expression<Func<TDocument, bool>> filterExpression)
		{
			await _collection.FindOneAndDeleteAsync(filterExpression);
		}

		public async Task DeleteByIdAsync(string id)
		{
			var isParsed = ObjectId.TryParse(id, out var objectId);
			if (!isParsed) return;
			await _collection.FindOneAndDeleteAsync(GetFilterById(objectId));
		}

		public async Task DeleteManyAsync(Expression<Func<TDocument, bool>> filterExpression)
		{
			await _collection.DeleteManyAsync(filterExpression);
		}

		private protected static string GetCollectionName(Type documentType)
		{
			if (documentType is null) throw new ArgumentNullException(nameof(documentType));

			var collectionAttribute = documentType.GetCustomAttributes(typeof(BsonCollectionAttribute), true).FirstOrDefault();
			if (collectionAttribute == null) throw new BsonCollectionAttributeMissingException();

			return ((BsonCollectionAttribute)collectionAttribute).CollectionName;
		}

		private protected static FilterDefinition<TDocument> GetFilterById(ObjectId id) => Builders<TDocument>.Filter.Eq("_id", id);

		private protected static FilterDefinition<TDocument> GetEmptyFilter() => Builders<TDocument>.Filter.Empty;
	}
}
