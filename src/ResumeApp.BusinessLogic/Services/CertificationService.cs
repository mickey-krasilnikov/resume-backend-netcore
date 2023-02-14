using FluentValidation;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.Models;

namespace ResumeApp.BusinessLogic.Services
{
	public class CertificationService<TEntity> : CrudService<CertificationDto, TEntity> where TEntity : class
    {
        public CertificationService(
            IRepository<TEntity> repository,
            IValidator<CertificationDto> validator) : base(repository, validator) { }
    }
}