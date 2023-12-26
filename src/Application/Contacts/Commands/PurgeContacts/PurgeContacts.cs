using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Application.Common.Security;
using ResumeApp.Domain.Constants;

namespace ResumeApp.Application.Contacts.Commands.PurgeContacts;

[Authorize(Roles = Roles.Administrator)]
[Authorize(Policy = Policies.CanPurge)]
public record PurgeContactsCommand : IRequest;

public class PurgeContactsCommandHandler(IApplicationDbContext context) : IRequestHandler<PurgeContactsCommand>
{
    public async Task Handle(PurgeContactsCommand request, CancellationToken cancellationToken)
    {
        context.Contacts.RemoveRange(context.Contacts);
        await context.SaveChangesAsync(cancellationToken);
    }
}
