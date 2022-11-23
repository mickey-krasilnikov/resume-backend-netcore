using System.Linq.Expressions;

namespace ResumeApp.DataAccess.Abstractions
{
	public interface IRepository<TEntity>
	{
		Task<bool> CheckIfItemExistsAsync(Guid id);

		Task<IReadOnlyList<TEntity>> FilterByAsync(Expression<Func<TEntity, bool>> filterExpression);

		Task<IReadOnlyList<TProjected>> FilterByAsync<TProjected>(
			Expression<Func<TEntity, bool>> filterExpression,
			Expression<Func<TEntity, TProjected>> projectionExpression);

		Task<IReadOnlyList<TProjected>> ProjectAsync<TProjected>(
			Expression<Func<TEntity, TProjected>> projectionExpression);

		Task<TEntity> FindOneAsync(Expression<Func<TEntity, bool>> filterExpression);

		Task<TEntity> FindByIdAsync(Guid id);

		Task InsertOneAsync(TEntity document);

		Task InsertManyAsync(ICollection<TEntity> documents);

		Task ReplaceOneAsync(TEntity document);

		Task DeleteOneAsync(Expression<Func<TEntity, bool>> filterExpression);

		Task DeleteByIdAsync(Guid id);

		Task DeleteManyAsync(Expression<Func<TEntity, bool>> filterExpression);
	}
}
