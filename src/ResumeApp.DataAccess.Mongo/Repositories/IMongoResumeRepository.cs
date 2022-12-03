using ResumeApp.DataAccess.Mongo.Entities;
using System.Linq.Expressions;

namespace ResumeApp.DataAccess.Mongo.Repositories
{
	public interface IMongoResumeRepository
	{
		Task<bool> CheckIfItemExistsAsync(Guid id);

		Task<IReadOnlyList<TProjected>> FilterByAsync<TProjected>(
			Expression<Func<ResumeMongoEntity, bool>> filterExpression,
			Expression<Func<ResumeMongoEntity, TProjected>> projectionExpression);

		Task<IReadOnlyList<TProjected>> ProjectAsync<TProjected>(
			Expression<Func<ResumeMongoEntity, TProjected>> projectionExpression);

		Task<TProjected> FindOneAsync<TProjected>(
			Expression<Func<ResumeMongoEntity, bool>> filterExpression,
			Expression<Func<ResumeMongoEntity, TProjected>> projectionExpression);

		Task<TProjected> FindByIdAsync<TProjected>(
			Guid id,
			Expression<Func<ResumeMongoEntity, TProjected>> projectionExpression);

		Task InsertOneAsync(ResumeMongoEntity entity);

		Task InsertManyAsync(ICollection<ResumeMongoEntity> documents);

		Task ReplaceOneAsync(ResumeMongoEntity entity);

		Task DeleteOneAsync(Expression<Func<ResumeMongoEntity, bool>> filterExpression);

		Task DeleteByIdAsync(Guid id);

		Task DeleteManyAsync(Expression<Func<ResumeMongoEntity, bool>> filterExpression);
	}
}