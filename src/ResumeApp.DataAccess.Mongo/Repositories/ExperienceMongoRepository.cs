﻿using MongoDB.Driver;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Mongo.Context;
using ResumeApp.DataAccess.Mongo.Entities;
using System.Linq.Expressions;
namespace ResumeApp.DataAccess.Mongo.Repositories
{
	public class ExperienceMongoRepository : IRepository<ExperienceMongoEntity>
	{
		private readonly IMongoDbContext<ExperienceMongoEntity> _context;

		public ExperienceMongoRepository(IMongoDbContext<ExperienceMongoEntity> context)
		{
			_context = context;
		}

		public async Task<IReadOnlyList<TProjected>> FilterByAsync<TProjected>(
			Expression<Func<ExperienceMongoEntity, bool>> filterExpression,
			Expression<Func<ExperienceMongoEntity, TProjected>> projectionExpression)
		{
			return await _context.Collection.Find(filterExpression).Project(projectionExpression).ToListAsync();
		}

		public async Task<IReadOnlyList<TProjected>> ProjectAsync<TProjected>(
			Expression<Func<ExperienceMongoEntity, TProjected>> projectionExpression)
		{
			return await _context.Collection.Find(_context.GetEmptyFilter()).Project(projectionExpression).ToListAsync();
		}

		public async Task<TProjected> FindOneAsync<TProjected>(
			Expression<Func<ExperienceMongoEntity, bool>> filterExpression,
			Expression<Func<ExperienceMongoEntity, TProjected>> projectionExpression)
		{
			return await _context.Collection.Find(filterExpression).Project(projectionExpression).FirstOrDefaultAsync();
		}

		public async Task<bool> CheckIfItemExistsAsync(Guid id)
		{
			var count = await _context.Collection.CountDocumentsAsync(_context.GetFilterById(id));
			return count == 1;
		}

		public async Task<TProjected> FindByIdAsync<TProjected>(
			Guid id			,
			Expression<Func<ExperienceMongoEntity, TProjected>> projectionExpression)
		{
			return await _context.Collection.Find(_context.GetFilterById(id)).Project(projectionExpression).SingleOrDefaultAsync();
		}

		public async Task<ExperienceMongoEntity> InsertOneAsync(ExperienceMongoEntity entity)
		{
			await _context.Collection.InsertOneAsync(entity);
			return entity;
		}

		public async Task InsertManyAsync(ICollection<ExperienceMongoEntity> documents)
		{
			await _context.Collection.InsertManyAsync(documents);
		}

		public async Task ReplaceOneAsync(ExperienceMongoEntity entity)
		{
			await _context.Collection.FindOneAndReplaceAsync(_context.GetFilterById(entity.Id), entity);
		}

		public async Task DeleteOneAsync(Expression<Func<ExperienceMongoEntity, bool>> filterExpression)
		{
			await _context.Collection.FindOneAndDeleteAsync(filterExpression);
		}

		public async Task DeleteByIdAsync(Guid id)
		{
			await _context.Collection.FindOneAndDeleteAsync(_context.GetFilterById(id));
		}

		public async Task DeleteManyAsync(Expression<Func<ExperienceMongoEntity, bool>> filterExpression)
		{
			await _context.Collection.DeleteManyAsync(filterExpression);
		}
	}
}
