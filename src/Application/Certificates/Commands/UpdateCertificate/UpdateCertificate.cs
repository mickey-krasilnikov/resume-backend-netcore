using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Application.Common.Security;

namespace ResumeApp.Application.Certificates.Commands.UpdateCertificate;

[Authorize]
public record UpdateCertificateCommand(
    Guid Id,
    string Name,
    string Issuer,
    Uri? VerificationUrl,
    DateOnly IssueDate,
    DateOnly? ExpirationDate) : IRequest;

public class UpdateCertificateCommandHandler(IApplicationDbContext context) : IRequestHandler<UpdateCertificateCommand>
{
    public async Task Handle(UpdateCertificateCommand request, CancellationToken cancellationToken)
    {
        var entity = await context.Certificates.FindAsync([request.Id], cancellationToken);

        Guard.Against.NotFound(request.Id, entity);

        entity.Name = request.Name;
        entity.Issuer = request.Issuer;
        entity.VerificationUrl = request.VerificationUrl;
        entity.IssueDate = request.IssueDate;
        entity.ExpirationDate = request.ExpirationDate;

        await context.SaveChangesAsync(cancellationToken);
    }
}
