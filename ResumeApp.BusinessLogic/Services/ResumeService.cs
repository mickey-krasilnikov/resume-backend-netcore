//using ResumeApp.BusinessLogic.Mappers;
//using ResumeApp.DataAccess.Abstractions;
//using ResumeApp.Poco;

//namespace ResumeApp.BusinessLogic.Services
//{
//	public class ResumeService : IResumeService
//	{
//		private readonly IResumeRepository<ResumeMongoEntity> _resumeRepository;

//		public ResumeService(IResumeRepository<ResumeMongoEntity> resumeRepository)
//		{
//			_resumeRepository = resumeRepository;
//		}

//		public async Task<IReadOnlyList<ConciseResume>> GetAllResumesAsync()
//		{
//			return await _resumeRepository.ProjectAsync(r => r.ToConsiseResumeDto());
//		}

//		public async Task<bool> CheckIfItemExistsAsync(string id)
//		{
//			return await _resumeRepository.CheckIfItemExistsAsync(id);
//		}

//		public async Task<FullResume> GetResumeByIdAsync(string id)
//		{
//			var resume = await _resumeRepository.FindByIdAsync(id);
//			return resume.ToFullResumeDto();
//		}

//		public async Task CreateResumesAsync(FullResume fullResume)
//		{
//			await _resumeRepository.InsertOneAsync(fullResume.ToResumeEntity());
//		}

//		public async Task UpdateResumesAsync(FullResume fullResume)
//		{
//			await _resumeRepository.ReplaceOneAsync(fullResume.ToResumeEntity());
//		}

//		public async Task DeleteResumesAsync(string id)
//		{
//			await _resumeRepository.DeleteByIdAsync(id);
//		}
//	}
//}