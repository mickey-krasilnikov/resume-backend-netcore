using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Application.Common.Mappings;
using ResumeApp.Application.Common.Models;
using ResumeApp.Application.Common.Security;

namespace ResumeApp.Application.Certificates.Queries.GetCertificatesWithPagination;

public record GetCertificatesWithPaginationQuery : IRequest<PaginatedList<CertificateDto>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetCertificatesWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
    : IRequestHandler<GetCertificatesWithPaginationQuery, PaginatedList<CertificateDto>>
{
    public async Task<PaginatedList<CertificateDto>> Handle(GetCertificatesWithPaginationQuery request, CancellationToken cancellationToken)
    {
        return await context.Certificates
            .OrderBy(x => x.Name)
            .ProjectTo<CertificateDto>(mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
