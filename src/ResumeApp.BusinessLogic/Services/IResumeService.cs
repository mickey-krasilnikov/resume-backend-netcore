using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Services
{
	public interface IResumeService
	{
		Task<IReadOnlyList<ShortResume>> GetAllResumesAsync();

		Task<bool> CheckIfItemExistsAsync(Guid id);

		Task<FullResume> GetResumeByIdAsync(Guid id);

		//Task CreateResumesAsync(FullResume fullResume);

		//Task UpdateResumesAsync(FullResume fullResume);

		Task DeleteResumesAsync(Guid id);
	}
}