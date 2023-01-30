using FluentValidation;
using ResumeApp.BusinessLogic.Constants;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Validations
{
	public class CertificationValidator : AbstractValidator<Certification>
	{
		public CertificationValidator()
		{
			//RuleFor(x => x)
			//	.NotNull()
			//	.WithMessage(ValidationErrorCodes.CannotBeNullOrEmpty);

			//RuleFor(x => x.FirstName)
			//	.NotEmpty()
			//	.Length(1, 250)
			//	.WithMessage(ValidationErrorCodes.MustBeValidFirstName);

			//RuleFor(x => x.LastName)
			//	.NotEmpty()
			//	.Length(1, 250)
			//	.WithMessage(ValidationErrorCodes.MustBeValidLastName);

			//RuleFor(x => x.Title)
			//	.NotEmpty()
			//	.Length(1, 250)
			//	.WithMessage(ValidationErrorCodes.CannotBeNullOrEmpty);
		}
	}
}