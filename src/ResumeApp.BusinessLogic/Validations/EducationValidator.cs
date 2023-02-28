using FluentValidation;
using ResumeApp.BusinessLogic.Constants;
using ResumeApp.Models;

namespace ResumeApp.BusinessLogic.Validations
{
	public class EducationValidator : AbstractValidator<EducationDto>
	{
		public EducationValidator()
		{
            RuleFor(x => x)
                .NotNull()
                .WithMessage(ValidationErrorCodes.CannotBeNullOrEmpty);

            RuleFor(x => x.Name)
                .NotEmpty()
                .Length(1, 250)
                .WithMessage(ValidationErrorCodes.CannotBeNullOrEmpty);

            RuleFor(x => x.Degree)
                .NotEmpty()
                .Length(1, 250)
                .WithMessage(ValidationErrorCodes.CannotBeNullOrEmpty);

            RuleFor(x => x.StartDate)
                .NotNull()
                .GreaterThan(DateOnly.MinValue)
                .LessThan(DateOnly.MaxValue)
                .WithMessage(ValidationErrorCodes.MustBeValidDateString);
        }
	}
}