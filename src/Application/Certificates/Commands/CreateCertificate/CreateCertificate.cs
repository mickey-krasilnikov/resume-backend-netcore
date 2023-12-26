using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Application.Common.Security;
using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.Certificates.Commands.CreateCertificate;

[Authorize]
public record CreateCertificateCommand(
    string Name,
    string Issuer,
    Uri? VerificationUrl,
    DateOnly IssueDate,
    DateOnly? ExpirationDate) : IRequest<Guid>;

public class CreateCertificateCommandHandler(IApplicationDbContext context)
    : IRequestHandler<CreateCertificateCommand, Guid>
{
    public async Task<Guid> Handle(CreateCertificateCommand request, CancellationToken cancellationToken)
    {
        var entity = new Certificate
        {
            Name = request.Name,
            Issuer = request.Issuer,
            VerificationUrl = request.VerificationUrl,
            IssueDate = request.IssueDate,
            ExpirationDate = request.ExpirationDate,
        };

        context.Certificates.Add(entity);
        await context.SaveChangesAsync(cancellationToken);
        return entity.Id;
    }
}
