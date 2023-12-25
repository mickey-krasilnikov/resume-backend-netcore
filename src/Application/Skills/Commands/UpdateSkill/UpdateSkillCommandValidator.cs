namespace ResumeApp.Application.Skills.Commands.UpdateSkill;

public class UpdateSkillCommandValidator : AbstractValidator<UpdateSkillCommand>
{
    public UpdateSkillCommandValidator()
    {
        RuleFor(v => v.Id).NotEqual(Guid.Empty);
        RuleFor(v => v.Name).MaximumLength(200).NotEmpty();
        RuleFor(v => v.SkillGroup).MaximumLength(200).NotEmpty();
    }
}
