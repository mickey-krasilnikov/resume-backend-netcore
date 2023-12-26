using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Application.Common.Security;
using ResumeApp.Domain.Constants;

namespace ResumeApp.Application.Certificates.Commands.PurgeCertificates;

[Authorize(Roles = Roles.Administrator)]
[Authorize(Policy = Policies.CanPurge)]
public record PurgeCertificatesCommand : IRequest;

public class PurgeCertificatesCommandHandler(IApplicationDbContext context) : IRequestHandler<PurgeCertificatesCommand>
{
    public async Task Handle(PurgeCertificatesCommand request, CancellationToken cancellationToken)
    {
        context.Certificates.RemoveRange(context.Certificates);
        await context.SaveChangesAsync(cancellationToken);
    }
}
