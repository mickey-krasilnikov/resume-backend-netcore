using FluentValidation;
using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.DataAccess.Abstractions;

namespace ResumeApp.BusinessLogic.Services
{
	public abstract class CrudService<TModel, TEntity> : ICrudService<TModel> 
		where TModel : class
		where TEntity : class
	{
		private readonly IRepository<TEntity> _repository;
		private readonly IValidator<TModel> _modelValidator;

		protected CrudService(
			IRepository<TEntity> repository,
			IValidator<TModel> fullCertificationValidator)
		{
			_repository = repository;
			_modelValidator = fullCertificationValidator;
		}

		public async Task<bool> CheckIfItemExistsAsync(Guid id)
		{
			return await _repository.CheckIfItemExistsAsync(id);
		}

		public async Task<TModel> CreateItemAsync(TModel item)
		{
			try
			{
				_modelValidator.Validate(item);
				var newItem = await _repository.InsertOneAsync(item.ToEntity<TModel, TEntity>());
				return newItem.ToDto<TModel, TEntity>();
			}
			catch (Exception ex)
			{
				var m = ex.Message;
				throw;
			}
		}

		public async Task<IReadOnlyList<TModel>> GetAllItemsAsync()
		{
			return await _repository.ProjectAsync(r => r.ToDto<TModel, TEntity>());
		}

		public async Task<TModel> GetItemByIdAsync(Guid id)
		{
			return await _repository.FindByIdAsync(id, r => r.ToDto<TModel, TEntity>());
		}

		public async Task UpdateItemAsync(TModel item)
		{
			_modelValidator.Validate(item);
			await _repository.ReplaceOneAsync(item.ToEntity<TModel, TEntity>());
		}

		public async Task DeleteItemAsync(Guid id)
		{
			await _repository.DeleteByIdAsync(id);
		}
	}
}