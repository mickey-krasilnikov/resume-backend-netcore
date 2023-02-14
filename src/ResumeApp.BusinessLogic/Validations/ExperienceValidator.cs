using FluentValidation;
using ResumeApp.Models;

namespace ResumeApp.BusinessLogic.Validations
{
	public class ExperienceValidator : AbstractValidator<ExperienceDto>
	{
		public ExperienceValidator()
		{
		}
	}
}