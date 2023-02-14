using FluentValidation;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.Models;

namespace ResumeApp.BusinessLogic.Services
{
	public class ExperienceService<TEntity> : CrudService<ExperienceDto, TEntity> where TEntity : class
	{
		public ExperienceService(
			IRepository<TEntity> repository,
			IValidator<ExperienceDto> validator) : base(repository, validator) { }
	}
}