using ResumeApp.Application.Common.Interfaces;

namespace ResumeApp.Application.Experiences.Commands.AddSkillToExperience;

public record AddSkillToExperienceCommand(Guid SkillId, Guid ExperienceId) : IRequest;

public class AddSkillToExperienceCommandHandler(IApplicationDbContext context) : IRequestHandler<AddSkillToExperienceCommand>
{
    public async Task Handle(AddSkillToExperienceCommand request, CancellationToken cancellationToken)
    {
        var skillEntity = await context.Skills.FindAsync([request.SkillId], cancellationToken);
        Guard.Against.NotFound(request.SkillId, skillEntity);
        
        var experienceEntity = await context.Experiences.FindAsync([request.ExperienceId], cancellationToken);
        Guard.Against.NotFound(request.SkillId, experienceEntity);

        skillEntity.Experiences.Add(experienceEntity);
        await context.SaveChangesAsync(cancellationToken);
    }
}
