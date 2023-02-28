using FluentValidation;
using ResumeApp.BusinessLogic.Constants;
using ResumeApp.Models;

namespace ResumeApp.BusinessLogic.Validations
{
	public class SkillValidator : AbstractValidator<SkillDto>
	{
		public SkillValidator()
		{
            RuleFor(x => x)
                .NotNull()
                .WithMessage(ValidationErrorCodes.CannotBeNullOrEmpty);

            RuleFor(x => x.Name)
                .NotEmpty()
                .Length(1, 250)
                .WithMessage(ValidationErrorCodes.CannotBeNullOrEmpty);

            RuleFor(x => x.SkillGroup)
                .NotEmpty()
                .Length(1, 250)
                .WithMessage(ValidationErrorCodes.CannotBeNullOrEmpty);
        }
	}
}