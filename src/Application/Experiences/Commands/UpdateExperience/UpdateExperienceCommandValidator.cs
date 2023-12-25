namespace ResumeApp.Application.Experiences.Commands.UpdateExperience;

public class UpdateExperienceCommandValidator : AbstractValidator<UpdateExperienceCommand>
{

    public UpdateExperienceCommandValidator()
    {
        RuleFor(v => v.Id).NotEqual(Guid.Empty);
        RuleFor(v => v.Title).MaximumLength(200).NotEmpty();
        RuleFor(v => v.Company).MaximumLength(200).NotEmpty();
        RuleFor(v => v.Location).MaximumLength(200).NotEmpty();
        RuleFor(v => v.TaskPerformed).NotEmpty();
        RuleFor(v => v.StartDate).GreaterThan(DateOnly.MinValue);
    }
}
