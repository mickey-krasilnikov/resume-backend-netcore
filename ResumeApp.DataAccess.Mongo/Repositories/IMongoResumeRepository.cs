using ResumeApp.DataAccess.Mongo.Entities;
using System.Linq.Expressions;

namespace ResumeApp.DataAccess.Mongo.Repositories
{
	public interface IMongoResumeRepository
	{
		Task<bool> CheckIfItemExistsAsync(Guid id);
		Task DeleteByIdAsync(Guid id);
		Task DeleteManyAsync(Expression<Func<ResumeMongoEntity, bool>> filterExpression);
		Task DeleteOneAsync(Expression<Func<ResumeMongoEntity, bool>> filterExpression);
		Task<IReadOnlyList<ResumeMongoEntity>> FilterByAsync(Expression<Func<ResumeMongoEntity, bool>> filterExpression);
		Task<IReadOnlyList<TProjected>> FilterByAsync<TProjected>(Expression<Func<ResumeMongoEntity, bool>> filterExpression, Expression<Func<ResumeMongoEntity, TProjected>> projectionExpression);
		Task<ResumeMongoEntity> FindByIdAsync(Guid id);
		Task<ResumeMongoEntity> FindOneAsync(Expression<Func<ResumeMongoEntity, bool>> filterExpression);
		Task InsertManyAsync(ICollection<ResumeMongoEntity> documents);
		Task InsertOneAsync(ResumeMongoEntity document);
		Task<IReadOnlyList<TProjected>> ProjectAsync<TProjected>(Expression<Func<ResumeMongoEntity, TProjected>> projectionExpression);
		Task ReplaceOneAsync(ResumeMongoEntity document);
	}
}