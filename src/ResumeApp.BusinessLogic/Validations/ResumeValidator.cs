using FluentValidation;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Validations
{
	public class ResumeValidator : AbstractValidator<FullResume>
	{
		public ResumeValidator()
		{
		}
	}
}