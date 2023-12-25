using ResumeApp.Application.Skills.Commands.UpdateSkill;

namespace ResumeApp.Application.Experiences.Commands.AddSkillToExperience;

public class AddSkillToExperienceCommandValidator : AbstractValidator<UpdateSkillCommand>
{
    public AddSkillToExperienceCommandValidator()
    {
        RuleFor(v => v.Id).NotEqual(Guid.Empty);
        RuleFor(v => v.Name).MaximumLength(200).NotEmpty();
        RuleFor(v => v.SkillGroup).MaximumLength(200).NotEmpty();
    }
}
