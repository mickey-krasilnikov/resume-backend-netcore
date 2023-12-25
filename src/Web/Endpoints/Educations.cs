using JetBrains.Annotations;
using ResumeApp.Application.Common.Models;
using ResumeApp.Application.Educations.Commands.CreateEducation;
using ResumeApp.Application.Educations.Commands.DeleteEducation;
using ResumeApp.Application.Educations.Commands.UpdateEducation;
using ResumeApp.Application.Educations.Queries.GetEducationsWithPagination;

namespace ResumeApp.Web.Endpoints;

[UsedImplicitly]
public class Educations : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapGet(GetEducationsWithPagination)
            .MapPost(CreateEducation)
            .MapPut(UpdateEducation, "{id}")
            .MapDelete(DeleteEducation, "{id}");
    }

    private static async Task<PaginatedList<EducationDto>> GetEducationsWithPagination(ISender sender, [AsParameters] GetEducationsWithPaginationQuery query)
    {
        return await sender.Send(query);
    }

    private static async Task<Guid> CreateEducation(ISender sender, CreateEducationCommand command)
    {
        return await sender.Send(command);
    }

    private static async Task<IResult> UpdateEducation(ISender sender, Guid id, UpdateEducationCommand command)
    {
        if (id != command.Id) return Results.BadRequest();
        await sender.Send(command);
        return Results.NoContent();
    }

    private static async Task<IResult> DeleteEducation(ISender sender, Guid id)
    {
        await sender.Send(new DeleteEducationCommand(id));
        return Results.NoContent();
    }
}
