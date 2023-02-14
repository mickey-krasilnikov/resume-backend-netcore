using FluentValidation;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.Models;

namespace ResumeApp.BusinessLogic.Services
{
	public class ContactsService<TEntity> : CrudService<ContactDto, TEntity> where TEntity : class
    {
        public ContactsService(
            IRepository<TEntity> repository,
            IValidator<ContactDto> validator) : base(repository, validator) { }
    }
}