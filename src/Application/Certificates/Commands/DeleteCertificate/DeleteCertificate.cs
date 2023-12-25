using ResumeApp.Application.Common.Interfaces;

namespace ResumeApp.Application.Certificates.Commands.DeleteCertificate;

public record DeleteCertificateCommand(Guid Id) : IRequest;

public class DeleteCertificateCommandHandler(IApplicationDbContext context) : IRequestHandler<DeleteCertificateCommand>
{
    public async Task Handle(DeleteCertificateCommand request, CancellationToken cancellationToken)
    {
        var entity = await context.Certificates.FindAsync([request.Id], cancellationToken);

        Guard.Against.NotFound(request.Id, entity);

        context.Certificates.Remove(entity);
        await context.SaveChangesAsync(cancellationToken);
    }
}
