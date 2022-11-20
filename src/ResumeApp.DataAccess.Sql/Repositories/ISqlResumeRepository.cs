using ResumeApp.DataAccess.Sql.Entities;
using System.Linq.Expressions;

namespace ResumeApp.DataAccess.Sql.Repositories
{
	public interface ISqlResumeRepository
	{
		Task<bool> CheckIfItemExistsAsync(long id);
		Task DeleteByIdAsync(long id);
		Task DeleteManyAsync(Expression<Func<ResumeSqlEntity, bool>> filterExpression);
		Task DeleteOneAsync(Expression<Func<ResumeSqlEntity, bool>> filterExpression);
		Task<IReadOnlyList<ResumeSqlEntity>> FilterByAsync(Expression<Func<ResumeSqlEntity, bool>> filterExpression);
		Task<IReadOnlyList<TProjected>> FilterByAsync<TProjected>(Expression<Func<ResumeSqlEntity, bool>> filterExpression, Expression<Func<ResumeSqlEntity, TProjected>> projectionExpression);
		Task<ResumeSqlEntity> FindByIdAsync(long id);
		Task<ResumeSqlEntity> FindOneAsync(Expression<Func<ResumeSqlEntity, bool>> filterExpression);
		Task InsertManyAsync(ICollection<ResumeSqlEntity> documents);
		Task InsertOneAsync(ResumeSqlEntity document);
		Task<IReadOnlyList<TProjected>> ProjectAsync<TProjected>(Expression<Func<ResumeSqlEntity, TProjected>> projectionExpression);
		Task ReplaceOneAsync(ResumeSqlEntity document);
	}
}