using Microsoft.EntityFrameworkCore;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Sql.Context;
using ResumeApp.DataAccess.Sql.Entities;
using System;
using System.Linq.Expressions;

namespace ResumeApp.DataAccess.Sql.Repositories
{
	public class CertificationSqlRepository : IRepository<CertificationSqlEntity>
	{
		private readonly ISqlDbContext _context;

		public CertificationSqlRepository(ISqlDbContext context)
		{
			_context = context;
		}

		public async Task<bool> CheckIfItemExistsAsync(Guid id)
		{
			return await _context.Certifications.AnyAsync(r => r.Id == id);
		}

		public async Task<IReadOnlyList<TProjected>> FilterByAsync<TProjected>(
			Expression<Func<CertificationSqlEntity, bool>> filterExpression,
			Expression<Func<CertificationSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Certifications
				.Where(filterExpression)
				.Select(projectionExpression)
				.ToListAsync();
		}

		public async Task<TProjected> FindByIdAsync<TProjected>(
			Guid id,
			Expression<Func<CertificationSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Certifications
				.Where(r => r.Id == id)
				.Select(projectionExpression)
				.FirstOrDefaultAsync();
		}

		public async Task<TProjected> FindOneAsync<TProjected>(
			Expression<Func<CertificationSqlEntity, bool>> filterExpression,
			Expression<Func<CertificationSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Certifications
				.Where(filterExpression)
				.Select(projectionExpression)
				.FirstOrDefaultAsync();
		}

		public async Task<IReadOnlyList<TProjected>> ProjectAsync<TProjected>(Expression<Func<CertificationSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Certifications.Select(projectionExpression).ToListAsync();
		}

		public async Task<CertificationSqlEntity> InsertOneAsync(CertificationSqlEntity entity)
		{
			_context.Certifications.Add(entity);
			await _context.SaveChangesAsync();
			return entity;
		}

		public async Task InsertManyAsync(ICollection<CertificationSqlEntity> entities)
		{
			_context.Certifications.AddRange(entities);
			await _context.SaveChangesAsync();
		}

		public async Task ReplaceOneAsync(CertificationSqlEntity entity)
		{
			var entityToUpdate = await _context.Certifications.FirstOrDefaultAsync(c => c.Id == entity.Id);
            _context.Certifications.Entry(entityToUpdate).CurrentValues.SetValues(entity);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteByIdAsync(Guid id)
		{
			var entity = await _context.Certifications.FirstOrDefaultAsync(r => r.Id == id);
			_context.Certifications.Remove(entity);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteManyAsync(Expression<Func<CertificationSqlEntity, bool>> filterExpression)
		{
			var entities = await _context.Certifications.Where(filterExpression).ToListAsync();
			_context.Certifications.RemoveRange(entities);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteOneAsync(Expression<Func<CertificationSqlEntity, bool>> filterExpression)
		{
			var entity = await _context.Certifications.FirstOrDefaultAsync(filterExpression);
			_context.Certifications.Remove(entity);
			await _context.SaveChangesAsync();
		}
	}
}
