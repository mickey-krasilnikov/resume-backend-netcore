namespace ResumeApp.Application.Educations.Commands.CreateEducation;

public class CreateEducationCommandValidator : AbstractValidator<CreateEducationCommand>
{
    public CreateEducationCommandValidator()
    {
        RuleFor(v => v.Name).MaximumLength(200).NotEmpty();
        RuleFor(v => v.Degree).MaximumLength(200).NotEmpty();
        RuleFor(v => v.FieldOfStudy).MaximumLength(200).NotEmpty();
        RuleFor(v => v.StartDate).GreaterThan(DateOnly.MinValue);
    }
}
