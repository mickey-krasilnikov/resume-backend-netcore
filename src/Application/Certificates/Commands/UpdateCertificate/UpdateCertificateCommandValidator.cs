namespace ResumeApp.Application.Certificates.Commands.UpdateCertificate;

public class UpdateCertificateCommandValidator : AbstractValidator<UpdateCertificateCommand>
{
    public UpdateCertificateCommandValidator()
    {
        RuleFor(v => v.Id).NotEqual(Guid.Empty);
        RuleFor(v => v.Name).MaximumLength(200).NotEmpty();
        RuleFor(v => v.Issuer).MaximumLength(200).NotEmpty();
        RuleFor(v => v.IssueDate).GreaterThan(DateOnly.MinValue);
    }
}
