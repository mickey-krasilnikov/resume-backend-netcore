using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.Skills.Commands.CreateSkill;

public record CreateSkillCommand(string Name, string SkillGroup, int Priority, bool IsHighlighted) : IRequest<Guid>;

public class CreateSkillCommandHandler(IApplicationDbContext context)
    : IRequestHandler<CreateSkillCommand, Guid>
{
    public async Task<Guid> Handle(CreateSkillCommand request, CancellationToken cancellationToken)
    {
        var entity = new Skill
        {
            Name = request.Name,
            SkillGroup = request.SkillGroup,
            Priority = request.Priority,
            IsHighlighted = request.IsHighlighted,
        };

        context.Skills.Add(entity);
        await context.SaveChangesAsync(cancellationToken);
        return entity.Id;
    }
}
