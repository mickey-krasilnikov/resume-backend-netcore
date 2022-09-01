using FluentValidation;

namespace ResumeApp.BusinessLogic.Validations
{
	public class ResumeValidator : AbstractValidator<Poco.Resume>
	{
		public ResumeValidator()
		{
		}
	}
}