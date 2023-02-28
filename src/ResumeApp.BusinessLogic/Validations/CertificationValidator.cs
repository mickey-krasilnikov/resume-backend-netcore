using FluentValidation;
using ResumeApp.BusinessLogic.Constants;
using ResumeApp.Models;

namespace ResumeApp.BusinessLogic.Validations
{
	public class CertificationValidator : AbstractValidator<CertificationDto>
	{
		public CertificationValidator()
		{
			RuleFor(x => x)
				.NotNull()
				.WithMessage(ValidationErrorCodes.CannotBeNullOrEmpty);

			RuleFor(x => x.Name)
				.NotEmpty()
				.Length(1, 250)
				.WithMessage(ValidationErrorCodes.MustBeValidName);

			RuleFor(x => x.Issuer)
				.NotEmpty()
				.Length(1, 250)
				.WithMessage(ValidationErrorCodes.CannotBeNullOrEmpty);

            RuleFor(x => x.IssueDate)
                .NotNull()
				.GreaterThan(DateOnly.MinValue)
				.LessThan(DateOnly.MaxValue)
                .WithMessage(ValidationErrorCodes.MustBeValidDateString);
        }
	}
}