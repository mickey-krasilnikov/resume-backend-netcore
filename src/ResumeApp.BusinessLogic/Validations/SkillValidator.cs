using FluentValidation;
using ResumeApp.Models;

namespace ResumeApp.BusinessLogic.Validations
{
	public class SkillValidator : AbstractValidator<SkillDto>
	{
		public SkillValidator()
		{
		}
	}
}