using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Domain.Entities;
using ResumeApp.Domain.Enums;

namespace ResumeApp.Application.Contacts.Commands.CreateContact;

public record CreateContactCommand(ContactType Type, string Key, string Value, string Link) : IRequest<Guid>;

public class CreateContactCommandHandler(IApplicationDbContext context)
    : IRequestHandler<CreateContactCommand, Guid>
{
    public async Task<Guid> Handle(CreateContactCommand request, CancellationToken cancellationToken)
    {
        var entity = new Contact
        {
            Type = request.Type,
            Key = request.Key,
            Value = request.Value,
            Link = request.Link,
        };

        context.Contacts.Add(entity);
        await context.SaveChangesAsync(cancellationToken);
        return entity.Id;
    }
}
