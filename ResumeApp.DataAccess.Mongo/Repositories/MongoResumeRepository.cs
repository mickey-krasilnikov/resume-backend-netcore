using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using ResumeApp.DataAccess.Mongo.Attributes;
using ResumeApp.DataAccess.Mongo.Configs;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Mongo.Exceptions;
using System.Linq.Expressions;
namespace ResumeApp.DataAccess.Mongo.Repositories
{
	public class MongoResumeRepository : IMongoResumeRepository
	{
		private readonly IMongoCollection<ResumeMongoEntity> _collection;

		public MongoResumeRepository(MongoDbConfig settings)
		{
			if (settings is null) throw new ArgumentNullException(nameof(settings));

			var conventionPack = new ConventionPack { new CamelCaseElementNameConvention() };
			ConventionRegistry.Register("camelCase", conventionPack, _ => true);

			var database = new MongoClient(settings.ConnectionString).GetDatabase(settings.DatabaseName);
			_collection = database.GetCollection<ResumeMongoEntity>(GetCollectionName(typeof(ResumeMongoEntity)));
		}

		public async Task<IReadOnlyList<ResumeMongoEntity>> FilterByAsync(
			Expression<Func<ResumeMongoEntity, bool>> filterExpression)
		{
			return await _collection.Find(filterExpression).ToListAsync();
		}

		public async Task<IReadOnlyList<TProjected>> FilterByAsync<TProjected>(
			Expression<Func<ResumeMongoEntity, bool>> filterExpression,
			Expression<Func<ResumeMongoEntity, TProjected>> projectionExpression)
		{
			return await _collection.Find(filterExpression).Project(projectionExpression).ToListAsync();
		}

		public async Task<IReadOnlyList<TProjected>> ProjectAsync<TProjected>(Expression<Func<ResumeMongoEntity, TProjected>> projectionExpression)
		{
			return await _collection.Find(GetEmptyFilter()).Project(projectionExpression).ToListAsync();
		}

		public async Task<ResumeMongoEntity> FindOneAsync(Expression<Func<ResumeMongoEntity, bool>> filterExpression)
		{
			return await _collection.Find(filterExpression).FirstOrDefaultAsync();
		}

		public async Task<bool> CheckIfItemExistsAsync(Guid id)
		{
			var count = await _collection.CountDocumentsAsync(GetFilterById(id));
			return count == 1;
		}

		public async Task<ResumeMongoEntity> FindByIdAsync(Guid id)
		{
			return await _collection.Find(GetFilterById(id)).SingleOrDefaultAsync();
		}

		public Task InsertOneAsync(ResumeMongoEntity document)
		{
			return Task.Run(() => _collection.InsertOneAsync(document));
		}

		public async Task InsertManyAsync(ICollection<ResumeMongoEntity> documents)
		{
			await _collection.InsertManyAsync(documents);
		}

		public async Task ReplaceOneAsync(ResumeMongoEntity document)
		{
			if (document is null) throw new ArgumentNullException(nameof(document));
			await _collection.FindOneAndReplaceAsync(GetFilterById(document.Id), document);
		}

		public async Task DeleteOneAsync(Expression<Func<ResumeMongoEntity, bool>> filterExpression)
		{
			await _collection.FindOneAndDeleteAsync(filterExpression);
		}

		public async Task DeleteByIdAsync(Guid id)
		{
			await _collection.FindOneAndDeleteAsync(GetFilterById(id));
		}

		public async Task DeleteManyAsync(Expression<Func<ResumeMongoEntity, bool>> filterExpression)
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

		private protected static FilterDefinition<ResumeMongoEntity> GetFilterById(Guid id) => Builders<ResumeMongoEntity>.Filter.Eq("_id", id);

		private protected static FilterDefinition<ResumeMongoEntity> GetEmptyFilter() => Builders<ResumeMongoEntity>.Filter.Empty;
	}
}
