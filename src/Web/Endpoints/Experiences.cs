using JetBrains.Annotations;
using ResumeApp.Application.Common.Models;
using ResumeApp.Application.Experiences.Commands.AddSkillToExperience;
using ResumeApp.Application.Experiences.Commands.CreateExperience;
using ResumeApp.Application.Experiences.Commands.DeleteExperience;
using ResumeApp.Application.Experiences.Commands.UpdateExperience;
using ResumeApp.Application.Experiences.Queries.GetExperiencesWithPagination;

namespace ResumeApp.Web.Endpoints;

[UsedImplicitly]
public class Experiences : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapGet(GetExperiencesWithPagination)
            .MapPost(CreateExperience)
            .MapPut(UpdateExperience, "{id}")
            .MapPut(AddSkillToExperience, "{id}/AddSkill")
            .MapDelete(DeleteExperience, "{id}");
    }

    private static async Task<PaginatedList<ExperienceDto>> GetExperiencesWithPagination(ISender sender, [AsParameters] GetExperiencesWithPaginationQuery query)
    {
        return await sender.Send(query);
    }

    private static async Task<Guid> CreateExperience(ISender sender, CreateExperienceCommand command)
    {
        return await sender.Send(command);
    }

    private static async Task<IResult> UpdateExperience(ISender sender, Guid id, UpdateExperienceCommand command)
    {
        if (id != command.Id) return Results.BadRequest();
        await sender.Send(command);
        return Results.NoContent();
    }

    private static async Task<IResult> AddSkillToExperience(ISender sender, Guid id, AddSkillToExperienceCommand command)
    {
        if (id != command.ExperienceId) return Results.BadRequest();
        await sender.Send(command);
        return Results.NoContent();
    }

    private static async Task<IResult> DeleteExperience(ISender sender, Guid id)
    {
        await sender.Send(new DeleteExperienceCommand(id));
        return Results.NoContent();
    }
}
