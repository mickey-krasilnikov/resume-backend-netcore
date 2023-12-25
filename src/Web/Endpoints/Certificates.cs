using JetBrains.Annotations;
using ResumeApp.Application.Certificates.Commands.CreateCertificate;
using ResumeApp.Application.Certificates.Commands.DeleteCertificate;
using ResumeApp.Application.Certificates.Commands.UpdateCertificate;
using ResumeApp.Application.Common.Models;
using ResumeApp.Application.Certificates.Queries.GetCertificatesWithPagination;

namespace ResumeApp.Web.Endpoints;

[UsedImplicitly]
public class Certificates : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapGet(GetCertificatesWithPagination)
            .MapPost(CreateCertificate)
            .MapPut(UpdateCertificate, "{id}")
            .MapDelete(DeleteCertificate, "{id}");
    }

    private static async Task<PaginatedList<CertificateDto>> GetCertificatesWithPagination(ISender sender, [AsParameters] GetCertificatesWithPaginationQuery query)
    {
        return await sender.Send(query);
    }

    private static async Task<Guid> CreateCertificate(ISender sender, CreateCertificateCommand command)
    {
        return await sender.Send(command);
    }

    private static async Task<IResult> UpdateCertificate(ISender sender, Guid id, UpdateCertificateCommand command)
    {
        if (id != command.Id) return Results.BadRequest();
        await sender.Send(command);
        return Results.NoContent();
    }

    private static async Task<IResult> DeleteCertificate(ISender sender, Guid id)
    {
        await sender.Send(new DeleteCertificateCommand(id));
        return Results.NoContent();
    }
}
