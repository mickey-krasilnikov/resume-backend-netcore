using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Abstractions.Entities;
using ResumeApp.DataAccess.Abstractions.Enums;
using ResumeApp.DataAccess.Abstractions.Options;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Services
{
	public class ResumeService : IResumeService
	{
		private readonly IRepository<IResumeEntity> _resumeRepository;
		private readonly SupportedDbType _dbType;

		public ResumeService(
			IRepository<IResumeEntity> resumeRepository,
			DbConnectionConfig dbConnectionOptions)
		{
			_resumeRepository = resumeRepository;
			_dbType = dbConnectionOptions.DbType;
		}

		public async Task<IReadOnlyList<ShortResume>> GetAllResumesAsync()
		{
			return await _resumeRepository.ProjectAsync(r => r.ToShortResumeDto());
		}

		public async Task<bool> CheckIfItemExistsAsync(Guid id)
		{
			return await _resumeRepository.CheckIfItemExistsAsync(id);
		}

		public async Task<FullResume> GetResumeByIdAsync(Guid id)
		{
			var resume = await _resumeRepository.FindByIdAsync(id);
			return resume.ToFullResumeDto();
		}

		public async Task DeleteResumesAsync(Guid id)
		{
			await _resumeRepository.DeleteByIdAsync(id);
		}

		public async Task CreateResumesAsync(FullResume fullResume)
		{
			await _resumeRepository.InsertOneAsync(fullResume.ToResumeEntity(_dbType));
		}

		public async Task UpdateResumesAsync(FullResume fullResume)
		{
			await _resumeRepository.ReplaceOneAsync(fullResume.ToResumeEntity(_dbType));
		}
	}
}