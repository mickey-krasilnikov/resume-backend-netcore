using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.Educations.Commands.CreateEducation;

public record CreateEducationCommand(string Name, string Degree, string FieldOfStudy, Uri? Url, DateOnly StartDate, DateOnly? EndDate) : IRequest<Guid>;

public class CreateEducationCommandHandler(IApplicationDbContext context)
    : IRequestHandler<CreateEducationCommand, Guid>
{
    public async Task<Guid> Handle(CreateEducationCommand request, CancellationToken cancellationToken)
    {
        var entity = new Education
        {
            Name = request.Name,
            Degree = request.Degree,
            FieldOfStudy = request.FieldOfStudy,
            Url = request.Url,
            StartDate = request.StartDate,
            EndDate = request.EndDate,
        };

        context.Educations.Add(entity);
        await context.SaveChangesAsync(cancellationToken);
        return entity.Id;
    }
}
