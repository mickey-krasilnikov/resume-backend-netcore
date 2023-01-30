using FluentValidation;
using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Services
{
    public class ExperienceService<TExperienceEntity> : ICrudService<Experience>
    {
        private readonly IRepository<TExperienceEntity> _repository;
        private readonly IValidator<Experience> _fullExperienceValidator;

        public ExperienceService(
            IRepository<TExperienceEntity> repository,
            IValidator<Experience> fullExperienceValidator)
        {
            _repository = repository;
            _fullExperienceValidator = fullExperienceValidator;
        }

        public async Task<bool> CheckIfItemExistsAsync(Guid id)
        {
            return await _repository.CheckIfItemExistsAsync(id);
        }

        public async Task CreateItemAsync(Experience Experience)
        {
            _fullExperienceValidator.Validate(Experience);
            await _repository.InsertOneAsync(Experience.ToEntity<TExperienceEntity>());
        }

        public async Task<IReadOnlyList<Experience>> GetAllItemsAsync()
        {
            return await _repository.ProjectAsync(r => r.ToDto());
        }

        public async Task<Experience> GetItemByIdAsync(Guid id)
        {
            return await _repository.FindByIdAsync(id, r => r.ToDto());
        }

        public async Task UpdateItemAsync(Experience Experience)
        {
            _fullExperienceValidator.Validate(Experience);
            await _repository.ReplaceOneAsync(Experience.ToEntity<TExperienceEntity>());
        }

        public async Task DeleteItemAsync(Guid id)
        {
            await _repository.DeleteByIdAsync(id);
        }
    }
}