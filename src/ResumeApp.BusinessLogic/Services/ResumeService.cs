using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Services
{
	public class ResumeService : IResumeService
	{
		private readonly IRepository<ResumeSqlEntity> _repository;

		public ResumeService(IRepository<ResumeSqlEntity> repository)
		{
			_repository = repository;
		}

		public async Task<IReadOnlyList<ShortResume>> GetAllResumesAsync()
		{
			return await _repository.ProjectAsync(r => r.ToShortResumeDto());
		}

		public async Task<bool> CheckIfItemExistsAsync(Guid id)
		{
			return await _repository.CheckIfItemExistsAsync(id);
		}

		public async Task<FullResume> GetResumeByIdAsync(Guid id)
		{
			return await _repository.FindByIdAsync(id, r => r.ToFullResumeDto());
		}

		public async Task DeleteResumesAsync(Guid id)
		{
			await _repository.DeleteByIdAsync(id);
		}

		public async Task CreateResumesAsync(FullResume fullResume)
		{
			await _repository.InsertOneAsync(fullResume.ToResumeSqlEntity());
		}

		public async Task UpdateResumesAsync(FullResume fullResume)
		{
			await _repository.ReplaceOneAsync(fullResume.ToResumeSqlEntity());
		}
	}
}