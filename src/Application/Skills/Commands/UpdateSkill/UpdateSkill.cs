using ResumeApp.Application.Common.Interfaces;

namespace ResumeApp.Application.Skills.Commands.UpdateSkill;

public record UpdateSkillCommand(Guid Id, string Name, string SkillGroup, int Priority, bool IsHighlighted) : IRequest;

public class UpdateSkillCommandHandler(IApplicationDbContext context) : IRequestHandler<UpdateSkillCommand>
{
    public async Task Handle(UpdateSkillCommand request, CancellationToken cancellationToken)
    {
        var entity = await context.Skills.FindAsync([request.Id], cancellationToken);

        Guard.Against.NotFound(request.Id, entity);

        entity.Name = request.Name;
        entity.SkillGroup = request.SkillGroup;
        entity.Priority = request.Priority;
        entity.IsHighlighted = request.IsHighlighted;

        await context.SaveChangesAsync(cancellationToken);
    }
}
