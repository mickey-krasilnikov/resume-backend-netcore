using ResumeApp.Application.Common.Interfaces;

namespace ResumeApp.Application.Skills.Commands.DeleteSkill;

public record DeleteSkillCommand(Guid Id) : IRequest;

public class DeleteSkillCommandHandler(IApplicationDbContext context) : IRequestHandler<DeleteSkillCommand>
{
    public async Task Handle(DeleteSkillCommand request, CancellationToken cancellationToken)
    {
        var entity = await context.Skills.FindAsync([request.Id], cancellationToken);

        Guard.Against.NotFound(request.Id, entity);

        context.Skills.Remove(entity);
        await context.SaveChangesAsync(cancellationToken);
    }
}
