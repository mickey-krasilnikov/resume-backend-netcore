using Microsoft.EntityFrameworkCore;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Sql.Context;
using ResumeApp.DataAccess.Sql.Entities;
using System.Linq.Expressions;

namespace ResumeApp.DataAccess.Sql.Repositories
{
	public class ExperienceSqlRepository : IRepository<ExperienceSqlEntity>
	{
		private readonly ISqlDbContext _context;

		public ExperienceSqlRepository(ISqlDbContext context)
		{
			_context = context;
		}

		public async Task<bool> CheckIfItemExistsAsync(Guid id)
		{
			return await _context.Experiences.AnyAsync(r => r.Id == id);
		}

		public async Task<IReadOnlyList<TProjected>> FilterByAsync<TProjected>(
			Expression<Func<ExperienceSqlEntity, bool>> filterExpression,
			Expression<Func<ExperienceSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Experiences
				.Where(filterExpression)
				.Select(projectionExpression)
				.ToListAsync();
		}

		public async Task<TProjected> FindByIdAsync<TProjected>(
			Guid id,
			Expression<Func<ExperienceSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Experiences
				.Where(r => r.Id == id)
				.Select(projectionExpression)
				.FirstOrDefaultAsync();
		}

		public async Task<TProjected> FindOneAsync<TProjected>(
			Expression<Func<ExperienceSqlEntity, bool>> filterExpression,
			Expression<Func<ExperienceSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Experiences
				.Where(filterExpression)
				.Select(projectionExpression)
				.FirstOrDefaultAsync();
		}

		public async Task<IReadOnlyList<TProjected>> ProjectAsync<TProjected>(Expression<Func<ExperienceSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Experiences.Select(projectionExpression).ToListAsync();
		}

		public async Task<ExperienceSqlEntity> InsertOneAsync(ExperienceSqlEntity entity)
		{
			_context.Experiences.Add(entity);
			await _context.SaveChangesAsync();
			return entity;
		}

		public async Task InsertManyAsync(ICollection<ExperienceSqlEntity> entities)
		{
			_context.Experiences.AddRange(entities);
			await _context.SaveChangesAsync();
		}

		public async Task ReplaceOneAsync(ExperienceSqlEntity entity)
        {
            var entityToUpdate = await _context.Experiences.FirstOrDefaultAsync(c => c.Id == entity.Id);
            _context.Experiences.Entry(entityToUpdate).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
		}

		public async Task DeleteByIdAsync(Guid id)
		{
			var certification = await _context.Experiences.FirstOrDefaultAsync(r => r.Id == id);
			_context.Experiences.Remove(certification);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteManyAsync(Expression<Func<ExperienceSqlEntity, bool>> filterExpression)
		{
			var certifications = await _context.Experiences.Where(filterExpression).ToListAsync();
			_context.Experiences.RemoveRange(certifications);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteOneAsync(Expression<Func<ExperienceSqlEntity, bool>> filterExpression)
		{
			var certification = await _context.Experiences.FirstOrDefaultAsync(filterExpression);
			_context.Experiences.Remove(certification);
			await _context.SaveChangesAsync();
		}
	}
}
