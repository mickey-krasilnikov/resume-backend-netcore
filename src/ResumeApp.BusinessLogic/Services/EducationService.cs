using FluentValidation;
using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Services
{
    public class EducationService<TEducationEntity> : ICrudService<Education>
    {
        private readonly IRepository<TEducationEntity> _repository;
        private readonly IValidator<Education> _fullEducationValidator;

        public EducationService(
            IRepository<TEducationEntity> repository,
            IValidator<Education> fullEducationValidator)
        {
            _repository = repository;
            _fullEducationValidator = fullEducationValidator;
        }

        public async Task<bool> CheckIfItemExistsAsync(Guid id)
        {
            return await _repository.CheckIfItemExistsAsync(id);
        }

        public async Task CreateItemAsync(Education Education)
        {
            _fullEducationValidator.Validate(Education);
            await _repository.InsertOneAsync(Education.ToEntity<TEducationEntity>());
        }

        public async Task<IReadOnlyList<Education>> GetAllItemsAsync()
        {
            return await _repository.ProjectAsync(r => r.ToDto());
        }

        public async Task<Education> GetItemByIdAsync(Guid id)
        {
            return await _repository.FindByIdAsync(id, r => r.ToDto());
        }

        public async Task UpdateItemAsync(Education Education)
        {
            _fullEducationValidator.Validate(Education);
            await _repository.ReplaceOneAsync(Education.ToEntity<TEducationEntity>());
        }

        public async Task DeleteItemAsync(Guid id)
        {
            await _repository.DeleteByIdAsync(id);
        }
    }
}