using Microsoft.EntityFrameworkCore;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Sql.Context;
using ResumeApp.DataAccess.Sql.Entities;
using System.Linq.Expressions;

namespace ResumeApp.DataAccess.Sql.Repositories
{
	public class EducationSqlRepository : IRepository<EducationSqlEntity>
	{
		private readonly ISqlDbContext _context;

		public EducationSqlRepository(ISqlDbContext context)
		{
			_context = context;
		}

		public async Task<bool> CheckIfItemExistsAsync(Guid id)
		{
			return await _context.Educations.AnyAsync(r => r.Id == id);
		}

		public async Task<IReadOnlyList<TProjected>> FilterByAsync<TProjected>(
			Expression<Func<EducationSqlEntity, bool>> filterExpression,
			Expression<Func<EducationSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Educations
				.Where(filterExpression)
				.Select(projectionExpression)
				.ToListAsync();
		}

		public async Task<TProjected> FindByIdAsync<TProjected>(
			Guid id,
			Expression<Func<EducationSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Educations
				.Where(r => r.Id == id)
				.Select(projectionExpression)
				.FirstOrDefaultAsync();
		}

		public async Task<TProjected> FindOneAsync<TProjected>(
			Expression<Func<EducationSqlEntity, bool>> filterExpression,
			Expression<Func<EducationSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Educations
				.Where(filterExpression)
				.Select(projectionExpression)
				.FirstOrDefaultAsync();
		}

		public async Task<IReadOnlyList<TProjected>> ProjectAsync<TProjected>(Expression<Func<EducationSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Educations.Select(projectionExpression).ToListAsync();
		}

		public async Task<EducationSqlEntity> InsertOneAsync(EducationSqlEntity entity)
		{
			_context.Educations.Add(entity);
			await _context.SaveChangesAsync();
			return entity;
		}

		public async Task InsertManyAsync(ICollection<EducationSqlEntity> entities)
		{
			_context.Educations.AddRange(entities);
			await _context.SaveChangesAsync();
		}

		public async Task ReplaceOneAsync(EducationSqlEntity entity)
		{
			_context.Educations.Update(entity);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteByIdAsync(Guid id)
		{
			var certification = await _context.Educations.FirstOrDefaultAsync(r => r.Id == id);
			_context.Educations.Remove(certification);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteManyAsync(Expression<Func<EducationSqlEntity, bool>> filterExpression)
		{
			var certifications = await _context.Educations.Where(filterExpression).ToListAsync();
			_context.Educations.RemoveRange(certifications);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteOneAsync(Expression<Func<EducationSqlEntity, bool>> filterExpression)
		{
			var certification = await _context.Educations.FirstOrDefaultAsync(filterExpression);
			_context.Educations.Remove(certification);
			await _context.SaveChangesAsync();
		}
	}
}
