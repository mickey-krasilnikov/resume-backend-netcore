using FluentValidation;
using ResumeApp.Models;

namespace ResumeApp.BusinessLogic.Validations
{
	public class ContactValidator : AbstractValidator<ContactDto>
	{
		public ContactValidator()
		{
		}
	}
}