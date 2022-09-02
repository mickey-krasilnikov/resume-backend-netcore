using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Services
{
	public interface IResumeService
	{
		Task<IReadOnlyList<ConciseResume>> GetAllResumesAsync();

		Task<bool> CheckIfItemExistsAsync(string id);

		Task<FullResume> GetResumeByIdAsync(string id);

		Task CreateResumesAsync(FullResume fullResume);

		Task UpdateResumesAsync(FullResume fullResume);

		Task DeleteResumesAsync(string id);
	}
}