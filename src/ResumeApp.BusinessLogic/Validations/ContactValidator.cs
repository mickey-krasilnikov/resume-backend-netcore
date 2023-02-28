using FluentValidation;
using ResumeApp.BusinessLogic.Constants;
using ResumeApp.Models;

namespace ResumeApp.BusinessLogic.Validations
{
	public class ContactValidator : AbstractValidator<ContactDto>
	{
		public ContactValidator()
		{
            RuleFor(x => x)
                .NotNull()
                .WithMessage(ValidationErrorCodes.CannotBeNullOrEmpty);

            RuleFor(x => x.Key)
                .NotEmpty()
                .Length(1, 250)
                .WithMessage(ValidationErrorCodes.CannotBeNullOrEmpty);

            RuleFor(x => x.Value)
                .NotEmpty()
                .Length(1, 250)
                .WithMessage(ValidationErrorCodes.CannotBeNullOrEmpty);
        }
	}
}