using Microsoft.EntityFrameworkCore;
using ResumeApp.DataAccess.Sql.Context;
using ResumeApp.DataAccess.Sql.Entities;
using System.Linq.Expressions;

namespace ResumeApp.DataAccess.Sql.Repositories
{
	public class SqlResumeRepository : ISqlResumeRepository
	{
		private readonly ResumeDbContext _context;

		public SqlResumeRepository(ResumeDbContext context)
		{
			_context = context;
		}

		public async Task<bool> CheckIfItemExistsAsync(Guid id)
		{
			return await _context.Resumes.AnyAsync(r => r.Id == id);
		}

		public async Task<IReadOnlyList<ResumeSqlEntity>> FilterByAsync(
			Expression<Func<ResumeSqlEntity, bool>> filterExpression)
		{
			return await _context.Resumes.Where(filterExpression).ToListAsync();
		}

		public async Task<IReadOnlyList<TProjected>> FilterByAsync<TProjected>(
			Expression<Func<ResumeSqlEntity, bool>> filterExpression,
			Expression<Func<ResumeSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Resumes
				.Where(filterExpression)
				.Select(projectionExpression)
				.ToListAsync();
		}

		public async Task<ResumeSqlEntity> FindByIdAsync(Guid id)
		{
			return await _context.Resumes.FirstOrDefaultAsync(r => r.Id == id);
		}

		public async Task<ResumeSqlEntity> FindOneAsync(Expression<Func<ResumeSqlEntity, bool>> filterExpression)
		{
			return await _context.Resumes.FirstOrDefaultAsync(filterExpression);
		}

		public async Task<IReadOnlyList<TProjected>> ProjectAsync<TProjected>(Expression<Func<ResumeSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Resumes.Select(projectionExpression).ToListAsync();
		}

		public async Task InsertOneAsync(ResumeSqlEntity entity)
		{
			_context.Resumes.Add(entity);
			await _context.SaveChangesAsync();
		}

		public async Task InsertManyAsync(ICollection<ResumeSqlEntity> documents)
		{
			_context.Resumes.AddRange(documents);
			await _context.SaveChangesAsync();
		}

		public async Task ReplaceOneAsync(ResumeSqlEntity entity)
		{
			_context.Resumes.Update(entity);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteByIdAsync(Guid id)
		{
			var resume = await _context.Resumes.FirstOrDefaultAsync(r => r.Id == id);
			_context.Resumes.Remove(resume);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteManyAsync(Expression<Func<ResumeSqlEntity, bool>> filterExpression)
		{
			var resumes = await _context.Resumes.Where(filterExpression).ToListAsync();
			_context.Resumes.RemoveRange(resumes);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteOneAsync(Expression<Func<ResumeSqlEntity, bool>> filterExpression)
		{
			var resume = await _context.Resumes.FirstOrDefaultAsync(filterExpression);
			_context.Resumes.Remove(resume);
			await _context.SaveChangesAsync();
		}
	}
}
