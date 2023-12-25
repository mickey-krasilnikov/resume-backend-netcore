using ResumeApp.Application.Common.Interfaces;

namespace ResumeApp.Application.Certificates.Commands.CreateCertificate;

public class CreateCertificateCommandValidator : AbstractValidator<CreateCertificateCommand>
{
    private readonly IApplicationDbContext _context;

    public CreateCertificateCommandValidator(IApplicationDbContext context)
    {
        _context = context;
        RuleFor(v => v.Name).NotEmpty().MaximumLength(200).MustAsync(BeUniqueCertificate).WithMessage("'{PropertyName}' must be unique.").WithErrorCode("Unique");
        RuleFor(v => v.Issuer).MaximumLength(200).NotEmpty();
        RuleFor(v => v.IssueDate).GreaterThan(DateOnly.MinValue);
    }
    
    private async Task<bool> BeUniqueCertificate(string name, CancellationToken cancellationToken)
    {
        return await _context.Certificates.AllAsync(l => l.Name != name, cancellationToken);
    }
}
