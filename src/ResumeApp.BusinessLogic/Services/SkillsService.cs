using FluentValidation;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.Models;

namespace ResumeApp.BusinessLogic.Services
{
	public class SkillsService<TEntity> : CrudService<SkillDto, TEntity> where TEntity : class
	{
		public SkillsService(
			IRepository<TEntity> repository,
			IValidator<SkillDto> validator) : base(repository, validator) { }
	}
}