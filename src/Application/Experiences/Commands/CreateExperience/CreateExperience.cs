using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.Experiences.Commands.CreateExperience;

public record CreateExperienceCommand(string Title, string Company, string Location, string TaskPerformed, DateOnly StartDate, DateOnly? EndDate) : IRequest<Guid>;

public class CreateExperienceCommandHandler(IApplicationDbContext context) : IRequestHandler<CreateExperienceCommand, Guid>
{
    public async Task<Guid> Handle(CreateExperienceCommand request, CancellationToken cancellationToken)
    {
        var entity = new Experience
        {
            Title = request.Title,
            Company = request.Company,
            Location = request.Location,
            TaskPerformed = request.TaskPerformed,
            StartDate = request.StartDate,
            EndDate = request.EndDate,
        };
        
        context.Experiences.Add(entity);
        await context.SaveChangesAsync(cancellationToken);
        return entity.Id;
    }
}
