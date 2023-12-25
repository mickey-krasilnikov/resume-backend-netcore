namespace ResumeApp.Application.Experiences.Commands.CreateExperience;

public class CreateExperienceCommandValidator : AbstractValidator<CreateExperienceCommand>
{
    public CreateExperienceCommandValidator()
    {
        RuleFor(v => v.Title).MaximumLength(200).NotEmpty();
        RuleFor(v => v.Company).MaximumLength(200).NotEmpty();
        RuleFor(v => v.Location).MaximumLength(200).NotEmpty();
        RuleFor(v => v.TaskPerformed).NotEmpty();
        RuleFor(v => v.StartDate).GreaterThan(DateOnly.MinValue);
    }
}
