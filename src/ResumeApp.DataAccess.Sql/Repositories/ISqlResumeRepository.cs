using ResumeApp.DataAccess.Sql.Entities;
using System.Linq.Expressions;

namespace ResumeApp.DataAccess.Sql.Repositories
{
	public interface ISqlResumeRepository
	{
		Task<bool> CheckIfItemExistsAsync(Guid id);

		Task<IReadOnlyList<TProjected>> FilterByAsync<TProjected>(
			Expression<Func<ResumeSqlEntity, bool>> filterExpression,
			Expression<Func<ResumeSqlEntity, TProjected>> projectionExpression);

		Task<IReadOnlyList<TProjected>> ProjectAsync<TProjected>(
			Expression<Func<ResumeSqlEntity, TProjected>> projectionExpression);

		Task<TProjected> FindOneAsync<TProjected>(
			Expression<Func<ResumeSqlEntity, bool>> filterExpression,
			Expression<Func<ResumeSqlEntity, TProjected>> projectionExpression);

		Task<TProjected> FindByIdAsync<TProjected>(
			Guid id,
			Expression<Func<ResumeSqlEntity, TProjected>> projectionExpression);

		Task InsertOneAsync(ResumeSqlEntity entity);

		Task InsertManyAsync(ICollection<ResumeSqlEntity> documents);

		Task ReplaceOneAsync(ResumeSqlEntity entity);

		Task DeleteOneAsync(Expression<Func<ResumeSqlEntity, bool>> filterExpression);

		Task DeleteByIdAsync(Guid id);

		Task DeleteManyAsync(Expression<Func<ResumeSqlEntity, bool>> filterExpression);
	}
}