using System.Linq.Expressions;

namespace ResumeApp.DataAccess.Abstractions;

public interface IRepository<TEntity>
{
	Task<bool> CheckIfItemExistsAsync(Guid id);

	Task<IReadOnlyList<TProjected>> FilterByAsync<TProjected>(
		Expression<Func<TEntity, bool>> filterExpression,
		Expression<Func<TEntity, TProjected>> projectionExpression);

	Task<IReadOnlyList<TProjected>> ProjectAsync<TProjected>(
		Expression<Func<TEntity, TProjected>> projectionExpression);

	Task<TProjected> FindOneAsync<TProjected>(
		Expression<Func<TEntity, bool>> filterExpression,
		Expression<Func<TEntity, TProjected>> projectionExpression);

	Task<TProjected> FindByIdAsync<TProjected>(
		Guid id,
		Expression<Func<TEntity, TProjected>> projectionExpression);

	Task InsertOneAsync(TEntity entity);

	Task InsertManyAsync(ICollection<TEntity> documents);

	Task ReplaceOneAsync(TEntity entity);

	Task DeleteOneAsync(Expression<Func<TEntity, bool>> filterExpression);

	Task DeleteByIdAsync(Guid id);

	Task DeleteManyAsync(Expression<Func<TEntity, bool>> filterExpression);
}