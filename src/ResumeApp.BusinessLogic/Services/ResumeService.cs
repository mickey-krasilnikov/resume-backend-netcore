using FluentValidation;
using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Services
{
	public class ResumeService<TResumeEntity> : IResumeService
	{
		private readonly IRepository<TResumeEntity> _repository;
		private readonly IValidator<FullResume> _fullResumeValidator;

		public ResumeService(
			IRepository<TResumeEntity> repository, 
			IValidator<FullResume> fullResumeValidator)
		{
			_repository = repository;
			_fullResumeValidator = fullResumeValidator;
		}

		public async Task<IReadOnlyList<ShortResume>> GetAllResumesAsync()
		{
			//TODO: Add pagination, query, etc. 
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
			_fullResumeValidator.Validate(fullResume);
			await _repository.InsertOneAsync(fullResume.ToResumeEntity<TResumeEntity>());
		}

		public async Task UpdateResumesAsync(FullResume fullResume)
		{
			_fullResumeValidator.Validate(fullResume);
			await _repository.ReplaceOneAsync(fullResume.ToResumeEntity<TResumeEntity>());
		}
	}
}