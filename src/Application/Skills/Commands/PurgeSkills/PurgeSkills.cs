using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Application.Common.Security;
using ResumeApp.Domain.Constants;

namespace ResumeApp.Application.Skills.Commands.PurgeSkills;

[Authorize(Roles = Roles.Administrator)]
[Authorize(Policy = Policies.CanPurge)]
public record PurgeSkillsCommand : IRequest;

public class PurgeSkillsCommandHandler(IApplicationDbContext context) : IRequestHandler<PurgeSkillsCommand>
{
    public async Task Handle(PurgeSkillsCommand request, CancellationToken cancellationToken)
    {
        context.Contacts.RemoveRange(context.Contacts);
        await context.SaveChangesAsync(cancellationToken);
    }
}
