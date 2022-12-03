using ResumeApp.BusinessLogic.Configs;
using ResumeApp.BusinessLogic.Enums;
using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.DataAccess.Mongo.Repositories;
using ResumeApp.DataAccess.Sql.Repositories;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Services
{
	public class ResumeService : IResumeService
	{
		private readonly SupportedDbType _dbType;
		private readonly ISqlResumeRepository _sqlResumeRepository;
		private readonly IMongoResumeRepository _mongoResumeRepository;

		public ResumeService(
			ISqlResumeRepository sqlResumeRepository,
			IMongoResumeRepository mongoResumeRepository)
		{
			_dbType = dbConnectionOptions.DbType;
			_sqlResumeRepository = sqlResumeRepository;
			_mongoResumeRepository = mongoResumeRepository;
		}

		public async Task<IReadOnlyList<ShortResume>> GetAllResumesAsync()
		{
			return _dbType switch
			{
				SupportedDbType.Mongo => await _sqlResumeRepository.ProjectAsync(r => r.ToShortResumeDto()),
				SupportedDbType.MsSql => await _mongoResumeRepository.ProjectAsync(r => r.ToShortResumeDto()),
				_ => throw new NotSupportedException($"{_dbType} DB type is not supported"),
			};
		}

		public async Task<bool> CheckIfItemExistsAsync(Guid id)
		{
			return _dbType switch
			{
				SupportedDbType.Mongo => await _sqlResumeRepository.CheckIfItemExistsAsync(id),
				SupportedDbType.MsSql => await _mongoResumeRepository.CheckIfItemExistsAsync(id),
				_ => throw new NotSupportedException($"{_dbType} DB type is not supported"),
			};
		}

		public async Task<FullResume> GetResumeByIdAsync(Guid id)
		{
			return _dbType switch
			{
				SupportedDbType.Mongo => await _sqlResumeRepository.FindByIdAsync(id, r => r.ToFullResumeDto()),
				SupportedDbType.MsSql => await _mongoResumeRepository.FindByIdAsync(id, r => r.ToFullResumeDto()),
				_ => throw new NotSupportedException($"{_dbType} DB type is not supported"),
			};
		}

		public async Task DeleteResumesAsync(Guid id)
		{
			switch (_dbType)
			{
				case SupportedDbType.Mongo: await _sqlResumeRepository.DeleteByIdAsync(id); break;
				case SupportedDbType.MsSql: await _mongoResumeRepository.DeleteByIdAsync(id); break;
				default: throw new NotSupportedException($"{_dbType} DB type is not supported");
			}
		}

		public async Task CreateResumesAsync(FullResume fullResume)
		{
			switch (_dbType)
			{
				case SupportedDbType.Mongo: await _sqlResumeRepository.InsertOneAsync(fullResume.ToResumeSqlEntity()); break;
				case SupportedDbType.MsSql: await _mongoResumeRepository.InsertOneAsync(fullResume.ToResumeMongoEntity()); break;
				default: throw new NotSupportedException($"{_dbType} DB type is not supported");
			}
		}

		public async Task UpdateResumesAsync(FullResume fullResume)
		{
			switch (_dbType)
			{
				case SupportedDbType.Mongo: await _sqlResumeRepository.ReplaceOneAsync(fullResume.ToResumeSqlEntity()); break;
				case SupportedDbType.MsSql: await _mongoResumeRepository.ReplaceOneAsync(fullResume.ToResumeMongoEntity()); break;
				default: throw new NotSupportedException($"{_dbType} DB type is not supported");
			}
		}
	}
}