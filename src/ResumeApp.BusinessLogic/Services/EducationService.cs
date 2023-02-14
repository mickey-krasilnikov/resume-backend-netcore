using FluentValidation;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.Models;

namespace ResumeApp.BusinessLogic.Services
{
	public class EducationService<TEntity> : CrudService<EducationDto, TEntity> where TEntity : class
	{
		public EducationService(
			IRepository<TEntity> repository,
			IValidator<EducationDto> validator) : base(repository, validator) { }
	}
}