using System.Linq.Expressions;

namespace ResumeApp.DataAccess
{
	public interface IResumeRepository<TDocument> where TDocument : IEntity
	{
		Task<IReadOnlyList<TDocument>> FilterByAsync(Expression<Func<TDocument, bool>> filterExpression);

		Task<IReadOnlyList<TProjected>> FilterByAsync<TProjected>(
			Expression<Func<TDocument, bool>> filterExpression,
			Expression<Func<TDocument, TProjected>> projectionExpression);

		Task<IReadOnlyList<TProjected>> ProjectAsync<TProjected>(
			Expression<Func<TDocument, TProjected>> projectionExpression);

		Task<TDocument> FindOneAsync(Expression<Func<TDocument, bool>> filterExpression);

		Task<bool> CheckIfItemExistsAsync(string id);

		Task<TDocument> FindByIdAsync(string id);

		Task InsertOneAsync(TDocument document);

		Task InsertManyAsync(ICollection<TDocument> documents);

		Task ReplaceOneAsync(TDocument document);

		Task DeleteOneAsync(Expression<Func<TDocument, bool>> filterExpression);

		Task DeleteByIdAsync(string id);

		Task DeleteManyAsync(Expression<Func<TDocument, bool>> filterExpression);
	}
}
