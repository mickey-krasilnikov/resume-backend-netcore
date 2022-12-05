using MongoDB.Driver;

namespace ResumeApp.DataAccess.Mongo.Context
{
	public interface IMongoDbContext<TMongoCollection> where TMongoCollection : class
	{
		IMongoCollection<TMongoCollection> Collection { get; }
		FilterDefinition<TMongoCollection> GetEmptyFilter();
		FilterDefinition<TMongoCollection> GetFilterById(Guid id);
	}
}