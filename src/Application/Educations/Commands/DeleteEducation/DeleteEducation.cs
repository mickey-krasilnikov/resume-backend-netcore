using ResumeApp.Application.Common.Interfaces;

namespace ResumeApp.Application.Educations.Commands.DeleteEducation;

public record DeleteEducationCommand(Guid Id) : IRequest;

public class DeleteEducationCommandHandler(IApplicationDbContext context) : IRequestHandler<DeleteEducationCommand>
{
    public async Task Handle(DeleteEducationCommand request, CancellationToken cancellationToken)
    {
        var entity = await context.Educations.FindAsync([request.Id], cancellationToken);

        Guard.Against.NotFound(request.Id, entity);

        context.Educations.Remove(entity);
        await context.SaveChangesAsync(cancellationToken);
    }
}
