using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Application.Common.Security;
using ResumeApp.Domain.Constants;

namespace ResumeApp.Application.Experiences.Commands.PurgeExperiences;

[Authorize(Roles = Roles.Administrator)]
[Authorize(Policy = Policies.CanPurge)]
public record PurgeExperiencesCommand : IRequest;

public class PurgeExperiencesCommandHandler(IApplicationDbContext context) : IRequestHandler<PurgeExperiencesCommand>
{
    public async Task Handle(PurgeExperiencesCommand request, CancellationToken cancellationToken)
    {
        context.Experiences.RemoveRange(context.Experiences);
        await context.SaveChangesAsync(cancellationToken);
    }
}
