using JetBrains.Annotations;
using ResumeApp.Application.Common.Models;
using ResumeApp.Application.Contacts.Commands.CreateContact;
using ResumeApp.Application.Contacts.Commands.DeleteContact;
using ResumeApp.Application.Contacts.Commands.UpdateContact;
using ResumeApp.Application.Contacts.Queries.GetContactsWithPagination;

namespace ResumeApp.Web.Endpoints;

[UsedImplicitly]
public class Contacts : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapGet(GetContactsWithPagination)
            .MapPost(CreateContact)
            .MapPut(UpdateContact, "{id}")
            .MapDelete(DeleteContact, "{id}");
    }

    private static async Task<PaginatedList<ContactDto>> GetContactsWithPagination(ISender sender, [AsParameters] GetContactsWithPaginationQuery query)
    {
        return await sender.Send(query);
    }

    private static async Task<Guid> CreateContact(ISender sender, CreateContactCommand command)
    {
        return await sender.Send(command);
    }

    private static async Task<IResult> UpdateContact(ISender sender, Guid id, UpdateContactCommand command)
    {
        if (id != command.Id) return Results.BadRequest();
        await sender.Send(command);
        return Results.NoContent();
    }

    private static async Task<IResult> DeleteContact(ISender sender, Guid id)
    {
        await sender.Send(new DeleteContactCommand(id));
        return Results.NoContent();
    }
}
