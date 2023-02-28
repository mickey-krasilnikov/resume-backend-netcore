using FluentValidation;
using ResumeApp.BusinessLogic.Constants;
using ResumeApp.Models;

namespace ResumeApp.BusinessLogic.Validations
{
	public class ExperienceValidator : AbstractValidator<ExperienceDto>
	{
		public ExperienceValidator()
        {
            RuleFor(x => x)
                .NotNull()
                .WithMessage(ValidationErrorCodes.CannotBeNullOrEmpty);

            RuleFor(x => x.Title)
                .NotEmpty()
                .Length(1, 250)
                .WithMessage(ValidationErrorCodes.CannotBeNullOrEmpty);

            RuleFor(x => x.Company)
                .NotEmpty()
                .Length(1, 250)
                .WithMessage(ValidationErrorCodes.CannotBeNullOrEmpty);

            RuleFor(x => x.Location)
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