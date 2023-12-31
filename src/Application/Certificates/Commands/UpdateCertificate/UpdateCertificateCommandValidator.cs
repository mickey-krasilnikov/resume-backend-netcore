using ResumeApp.Application.Common.Interfaces;

namespace ResumeApp.Application.Certificates.Commands.UpdateCertificate;

public class UpdateCertificateCommandValidator : AbstractValidator<UpdateCertificateCommand>
{
    private readonly IApplicationDbContext _context;
    public UpdateCertificateCommandValidator(IApplicationDbContext context)
    {
        _context = context;
        RuleFor(v => v.Id).NotEqual(Guid.Empty);
        RuleFor(v => v.Name).NotEmpty().MaximumLength(200).MustAsync(BeUniqueCertificateName).WithMessage("'{PropertyName}' must be unique.").WithErrorCode("Unique");
        RuleFor(v => v.Issuer).MaximumLength(200).NotEmpty();
        RuleFor(v => v.IssueDate).GreaterThan(DateOnly.MinValue);
    }

    private async Task<bool> BeUniqueCertificateName(UpdateCertificateCommand model, string name, CancellationToken cancellationToken)
    {
        return await _context.Certificates
            .Where(l => l.Id != model.Id)
            .AllAsync(l => l.Name != name, cancellationToken);
    }
}
