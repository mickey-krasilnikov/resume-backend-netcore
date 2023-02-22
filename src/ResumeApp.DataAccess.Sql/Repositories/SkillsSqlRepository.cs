using Microsoft.EntityFrameworkCore;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Sql.Context;
using ResumeApp.DataAccess.Sql.Entities;
using System.Linq.Expressions;

namespace ResumeApp.DataAccess.Sql.Repositories
{
	public class SkillsSqlRepository : IRepository<SkillSqlEntity>
	{
		private readonly ISqlDbContext _context;

		public SkillsSqlRepository(ISqlDbContext context)
		{
			_context = context;
		}

		public async Task<bool> CheckIfItemExistsAsync(Guid id)
		{
			return await _context.Skills.AnyAsync(r => r.Id == id);
		}

		public async Task<IReadOnlyList<TProjected>> FilterByAsync<TProjected>(
			Expression<Func<SkillSqlEntity, bool>> filterExpression,
			Expression<Func<SkillSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Skills
				.Where(filterExpression)
				.Select(projectionExpression)
				.ToListAsync();
		}

		public async Task<TProjected> FindByIdAsync<TProjected>(
			Guid id,
			Expression<Func<SkillSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Skills
				.Where(r => r.Id == id)
				.Select(projectionExpression)
				.FirstOrDefaultAsync();
		}

		public async Task<TProjected> FindOneAsync<TProjected>(
			Expression<Func<SkillSqlEntity, bool>> filterExpression,
			Expression<Func<SkillSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Skills
				.Where(filterExpression)
				.Select(projectionExpression)
				.FirstOrDefaultAsync();
		}

		public async Task<IReadOnlyList<TProjected>> ProjectAsync<TProjected>(Expression<Func<SkillSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Skills.Select(projectionExpression).ToListAsync();
		}

		public async Task<SkillSqlEntity> InsertOneAsync(SkillSqlEntity entity)
		{
			_context.Skills.Add(entity);
			await _context.SaveChangesAsync();
			return entity;
		}

		public async Task InsertManyAsync(ICollection<SkillSqlEntity> entities)
		{
			_context.Skills.AddRange(entities);
			await _context.SaveChangesAsync();
		}

		public async Task ReplaceOneAsync(SkillSqlEntity entity)
        {
            var entityToUpdate = await _context.Skills.FirstOrDefaultAsync(c => c.Id == entity.Id);
            _context.Skills.Entry(entityToUpdate).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
		}

		public async Task DeleteByIdAsync(Guid id)
		{
			var certification = await _context.Skills.FirstOrDefaultAsync(r => r.Id == id);
			_context.Skills.Remove(certification);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteManyAsync(Expression<Func<SkillSqlEntity, bool>> filterExpression)
		{
			var certifications = await _context.Skills.Where(filterExpression).ToListAsync();
			_context.Skills.RemoveRange(certifications);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteOneAsync(Expression<Func<SkillSqlEntity, bool>> filterExpression)
		{
			var certification = await _context.Skills.FirstOrDefaultAsync(filterExpression);
			_context.Skills.Remove(certification);
			await _context.SaveChangesAsync();
		}
	}
}
