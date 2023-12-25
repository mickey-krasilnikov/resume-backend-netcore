using JetBrains.Annotations;
using ResumeApp.Application.Common.Models;
using ResumeApp.Application.Skills.Commands.CreateSkill;
using ResumeApp.Application.Skills.Commands.DeleteSkill;
using ResumeApp.Application.Skills.Commands.UpdateSkill;
using ResumeApp.Application.Skills.Queries.GetSkillsWithPagination;

namespace ResumeApp.Web.Endpoints;

[UsedImplicitly]
public class Skills : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapGet(GetSkillsWithPagination)
            .MapPost(CreateSkill)
            .MapPut(UpdateSkill, "{id}")
            .MapDelete(DeleteSkill, "{id}");
    }

    private static async Task<PaginatedList<SkillDto>> GetSkillsWithPagination(ISender sender, [AsParameters] GetSkillsWithPaginationQuery query)
    {
        return await sender.Send(query);
    }

    private static async Task<Guid> CreateSkill(ISender sender, CreateSkillCommand command)
    {
        return await sender.Send(command);
    }

    private static async Task<IResult> UpdateSkill(ISender sender, Guid id, UpdateSkillCommand command)
    {
        if (id != command.Id) return Results.BadRequest();
        await sender.Send(command);
        return Results.NoContent();
    }

    private static async Task<IResult> DeleteSkill(ISender sender, Guid id)
    {
        await sender.Send(new DeleteSkillCommand(id));
        return Results.NoContent();
    }
}
