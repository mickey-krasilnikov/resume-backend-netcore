using FluentValidation;
using ResumeApp.Models;

namespace ResumeApp.BusinessLogic.Validations
{
	public class EducationValidator : AbstractValidator<EducationDto>
	{
		public EducationValidator()
		{
		}
	}
}