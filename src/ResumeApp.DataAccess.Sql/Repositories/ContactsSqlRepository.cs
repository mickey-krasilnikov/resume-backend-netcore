using Microsoft.EntityFrameworkCore;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Sql.Context;
using ResumeApp.DataAccess.Sql.Entities;
using System.Linq.Expressions;

namespace ResumeApp.DataAccess.Sql.Repositories
{
	public class ContactsSqlRepository : IRepository<ContactSqlEntity>
	{
		private readonly ISqlDbContext _context;

		public ContactsSqlRepository(ISqlDbContext context)
		{
			_context = context;
		}

		public async Task<bool> CheckIfItemExistsAsync(Guid id)
		{
			return await _context.Contacts.AnyAsync(r => r.Id == id);
		}

		public async Task<IReadOnlyList<TProjected>> FilterByAsync<TProjected>(
			Expression<Func<ContactSqlEntity, bool>> filterExpression,
			Expression<Func<ContactSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Contacts
				.Where(filterExpression)
				.Select(projectionExpression)
				.ToListAsync();
		}

		public async Task<TProjected> FindByIdAsync<TProjected>(
			Guid id,
			Expression<Func<ContactSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Contacts
				.Where(r => r.Id == id)
				.Select(projectionExpression)
				.FirstOrDefaultAsync();
		}

		public async Task<TProjected> FindOneAsync<TProjected>(
			Expression<Func<ContactSqlEntity, bool>> filterExpression,
			Expression<Func<ContactSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Contacts
				.Where(filterExpression)
				.Select(projectionExpression)
				.FirstOrDefaultAsync();
		}

		public async Task<IReadOnlyList<TProjected>> ProjectAsync<TProjected>(Expression<Func<ContactSqlEntity, TProjected>> projectionExpression)
		{
			return await _context.Contacts.Select(projectionExpression).ToListAsync();
		}

		public async Task<ContactSqlEntity> InsertOneAsync(ContactSqlEntity entity)
		{
			_context.Contacts.Add(entity);
			await _context.SaveChangesAsync();
			return entity;
		}

		public async Task InsertManyAsync(ICollection<ContactSqlEntity> entities)
		{
			_context.Contacts.AddRange(entities);
			await _context.SaveChangesAsync();
		}

		public async Task ReplaceOneAsync(ContactSqlEntity entity)
        {
            var entityToUpdate = await _context.Contacts.FirstOrDefaultAsync(c => c.Id == entity.Id);
            _context.Contacts.Entry(entityToUpdate).CurrentValues.SetValues(entity);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteByIdAsync(Guid id)
		{
			var entity = await _context.Contacts.FirstOrDefaultAsync(r => r.Id == id);
			_context.Contacts.Remove(entity);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteManyAsync(Expression<Func<ContactSqlEntity, bool>> filterExpression)
		{
			var entities = await _context.Contacts.Where(filterExpression).ToListAsync();
			_context.Contacts.RemoveRange(entities);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteOneAsync(Expression<Func<ContactSqlEntity, bool>> filterExpression)
		{
			var entity = await _context.Contacts.FirstOrDefaultAsync(filterExpression);
			_context.Contacts.Remove(entity);
			await _context.SaveChangesAsync();
		}
	}
}
