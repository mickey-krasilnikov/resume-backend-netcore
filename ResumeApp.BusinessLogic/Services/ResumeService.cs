using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.DataAccess;
using ResumeApp.DataAccess.MongoDb.Entities;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Services
{
	public class ResumeService : IResumeService
	{
		private readonly IResumeRepository<ResumeEntity> _resumeRepository;

		public ResumeService(IResumeRepository<ResumeEntity> resumeRepository)
		{
			_resumeRepository = resumeRepository;
		}

		public async Task<IReadOnlyList<ConciseResume>> GetAllResumesAsync()
		{
			return await _resumeRepository.ProjectAsync(r => r.ToConsiseResumeDto());
		}

		public async Task<bool> CheckIfItemExistsAsync(string id)
		{
			return await _resumeRepository.CheckIfItemExistsAsync(id);
		}

		public async Task<FullResume> GetResumeByIdAsync(string id)
		{
			var resume = await _resumeRepository.FindByIdAsync(id);
			return resume.ToFullResumeDto();
		}
	}
}