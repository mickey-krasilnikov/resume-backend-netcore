using ResumeApp.Application.Common.Interfaces;

namespace ResumeApp.Application.Experiences.Commands.DeleteExperience;

public record DeleteExperienceCommand(Guid Id) : IRequest;

public class DeleteExperienceCommandHandler(IApplicationDbContext context) : IRequestHandler<DeleteExperienceCommand>
{
    public async Task Handle(DeleteExperienceCommand request, CancellationToken cancellationToken)
    {
        var entity = await context.Experiences
            .Where(l => l.Id == request.Id)
            .SingleOrDefaultAsync(cancellationToken);

        Guard.Against.NotFound(request.Id, entity);

        context.Experiences.Remove(entity);

        await context.SaveChangesAsync(cancellationToken);
    }
}
