using FluentValidation;
using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Services
{
    public class SkillsService<TSkillsEntity> : ICrudService<Skill>
    {
        private readonly IRepository<TSkillsEntity> _repository;
        private readonly IValidator<Skill> _fullSkillsValidator;

        public SkillsService(
            IRepository<TSkillsEntity> repository,
            IValidator<Skill> fullSkillsValidator)
        {
            _repository = repository;
            _fullSkillsValidator = fullSkillsValidator;
        }

        public async Task<bool> CheckIfItemExistsAsync(Guid id)
        {
            return await _repository.CheckIfItemExistsAsync(id);
        }

        public async Task CreateItemAsync(Skill Skills)
        {
            _fullSkillsValidator.Validate(Skills);
            await _repository.InsertOneAsync(Skills.ToEntity<TSkillsEntity>());
        }

        public async Task<IReadOnlyList<Skill>> GetAllItemsAsync()
        {
            return await _repository.ProjectAsync(r => r.ToDto());
        }

        public async Task<Skill> GetItemByIdAsync(Guid id)
        {
            return await _repository.FindByIdAsync(id, r => r.ToDto());
        }

        public async Task UpdateItemAsync(Skill Skills)
        {
            _fullSkillsValidator.Validate(Skills);
            await _repository.ReplaceOneAsync(Skills.ToEntity<TSkillsEntity>());
        }

        public async Task DeleteItemAsync(Guid id)
        {
            await _repository.DeleteByIdAsync(id);
        }
    }
}