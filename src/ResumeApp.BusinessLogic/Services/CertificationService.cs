using FluentValidation;
using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Services
{
    public class CertificationService<TModel, TEntity> : ICrudService<TModel>
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IValidator<TModel> _fullCertificationValidator;

        public CertificationService(
            IRepository<TEntity> repository,
            IValidator<TModel> fullCertificationValidator)
        {
            _repository = repository;
            _fullCertificationValidator = fullCertificationValidator;
        }

        public async Task<bool> CheckIfItemExistsAsync(Guid id)
        {
            return await _repository.CheckIfItemExistsAsync(id);
        }

        public async Task<TModel> CreateItemAsync(TModel item)
        {
            _fullCertificationValidator.Validate(item);
            await _repository.InsertOneAsync(item.ToEntity<TEntity>());
        }

        public async Task<IReadOnlyList<TModel>> GetAllItemsAsync()
        {
            return await _repository.ProjectAsync(r => r.ToDto());
        }

        public async Task<TModel> GetItemByIdAsync(Guid id)
        {
            return await _repository.FindByIdAsync(id, r => r.ToDto());
        }

        public async Task UpdateItemAsync(TModel item)
        {
            _fullCertificationValidator.Validate(item);
            await _repository.ReplaceOneAsync(item.ToEntity<TEntity>());
        }

        public async Task DeleteItemAsync(Guid id)
        {
            await _repository.DeleteByIdAsync(id);
        }
    }
}