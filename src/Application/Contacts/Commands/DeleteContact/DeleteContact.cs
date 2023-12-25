using ResumeApp.Application.Common.Interfaces;

namespace ResumeApp.Application.Contacts.Commands.DeleteContact;

public record DeleteContactCommand(Guid Id) : IRequest;

public class DeleteContactCommandHandler(IApplicationDbContext context) : IRequestHandler<DeleteContactCommand>
{
    public async Task Handle(DeleteContactCommand request, CancellationToken cancellationToken)
    {
        var entity = await context.Contacts.FindAsync([request.Id], cancellationToken);

        Guard.Against.NotFound(request.Id, entity);

        context.Contacts.Remove(entity);
        await context.SaveChangesAsync(cancellationToken);
    }
}
