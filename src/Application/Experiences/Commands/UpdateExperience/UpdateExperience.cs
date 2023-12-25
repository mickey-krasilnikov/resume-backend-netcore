using ResumeApp.Application.Common.Interfaces;

namespace ResumeApp.Application.Experiences.Commands.UpdateExperience;

public record UpdateExperienceCommand(Guid Id, string Title, string Company, string Location, string TaskPerformed, DateOnly StartDate, DateOnly? EndDate) : IRequest;

public class UpdateExperienceCommandHandler(IApplicationDbContext context) : IRequestHandler<UpdateExperienceCommand>
{
    public async Task Handle(UpdateExperienceCommand request, CancellationToken cancellationToken)
    {
        var entity = await context.Experiences
            .FindAsync([request.Id], cancellationToken);

        Guard.Against.NotFound(request.Id, entity);

        entity.Title = request.Title;
        entity.Company = request.Company;
        entity.Location = request.Location;
        entity.TaskPerformed = request.TaskPerformed;
        entity.StartDate = request.StartDate;
        entity.EndDate = request.EndDate;

        await context.SaveChangesAsync(cancellationToken);

    }
}
