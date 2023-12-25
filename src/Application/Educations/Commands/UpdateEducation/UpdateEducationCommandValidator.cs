namespace ResumeApp.Application.Educations.Commands.UpdateEducation;

public class UpdateEducationCommandValidator : AbstractValidator<UpdateEducationCommand>
{
    public UpdateEducationCommandValidator()
    {
        RuleFor(v => v.Id).NotEqual(Guid.Empty);
        RuleFor(v => v.Name).MaximumLength(200).NotEmpty();
        RuleFor(v => v.Degree).MaximumLength(200).NotEmpty();
        RuleFor(v => v.FieldOfStudy).MaximumLength(200).NotEmpty();
        RuleFor(v => v.StartDate).GreaterThan(DateOnly.MinValue);
    }
}
