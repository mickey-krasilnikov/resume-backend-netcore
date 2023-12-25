using ResumeApp.Application.Common.Interfaces;

namespace ResumeApp.Application.Educations.Commands.UpdateEducation;

public record UpdateEducationCommand(Guid Id, string Name, string Degree, string FieldOfStudy, Uri? Url, DateOnly StartDate, DateOnly? EndDate) : IRequest;

public class UpdateEducationCommandHandler(IApplicationDbContext context) : IRequestHandler<UpdateEducationCommand>
{
    public async Task Handle(UpdateEducationCommand request, CancellationToken cancellationToken)
    {
        var entity = await context.Educations.FindAsync([request.Id], cancellationToken);

        Guard.Against.NotFound(request.Id, entity);

        entity.Name = request.Name;
        entity.Degree = request.Degree;
        entity.FieldOfStudy = request.FieldOfStudy;
        entity.Url = request.Url;
        entity.StartDate = request.StartDate;
        entity.EndDate = request.EndDate;

        await context.SaveChangesAsync(cancellationToken);
    }
}
