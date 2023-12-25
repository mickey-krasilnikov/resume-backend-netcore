using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Domain.Enums;

namespace ResumeApp.Application.Contacts.Commands.UpdateContact;

public record UpdateContactCommand(Guid Id, ContactType Type, string Key, string Value, string Link) : IRequest;

public class UpdateContactCommandHandler(IApplicationDbContext context) : IRequestHandler<UpdateContactCommand>
{
    public async Task Handle(UpdateContactCommand request, CancellationToken cancellationToken)
    {
        var entity = await context.Contacts.FindAsync([request.Id], cancellationToken);

        Guard.Against.NotFound(request.Id, entity);

        entity.Type = request.Type;
        entity.Key = request.Key;
        entity.Value = request.Value;
        entity.Link = request.Link;

        await context.SaveChangesAsync(cancellationToken);
    }
}
