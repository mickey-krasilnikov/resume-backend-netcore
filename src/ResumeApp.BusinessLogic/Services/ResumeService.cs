using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Abstractions.Entities;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Services
{
	public class ResumeService : IResumeService
	{
		private readonly IRepository<IResumeEntity> _resumeRepository;

		public ResumeService(IRepository<IResumeEntity> resumeRepository)
		{
			_resumeRepository = resumeRepository;
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

		//public async Task CreateResumesAsync(FullResume fullResume)
		//{
		//	await _resumeRepository.InsertOneAsync(fullResume.ToResumeEntity());
		//}

		//public async Task UpdateResumesAsync(FullResume fullResume)
		//{
		//	await _resumeRepository.ReplaceOneAsync(fullResume.ToResumeEntity());
		//}

		public async Task DeleteResumesAsync(Guid id)
		{
			await _resumeRepository.DeleteByIdAsync(id);
		}
	}
}