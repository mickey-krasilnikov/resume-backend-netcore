namespace ResumeApp.Application.Skills.Commands.CreateSkill;

public class CreateSkillCommandValidator : AbstractValidator<CreateSkillCommand>
{
    public CreateSkillCommandValidator()
    {
        RuleFor(v => v.Name).MaximumLength(200).NotEmpty();
        RuleFor(v => v.SkillGroup).MaximumLength(200).NotEmpty();
    }
}
