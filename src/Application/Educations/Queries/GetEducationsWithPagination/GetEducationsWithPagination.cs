using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Application.Common.Mappings;
using ResumeApp.Application.Common.Models;

namespace ResumeApp.Application.Educations.Queries.GetEducationsWithPagination;

public record GetEducationsWithPaginationQuery : IRequest<PaginatedList<EducationDto>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetEducationsWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
    : IRequestHandler<GetEducationsWithPaginationQuery, PaginatedList<EducationDto>>
{
    public async Task<PaginatedList<EducationDto>> Handle(GetEducationsWithPaginationQuery request, CancellationToken cancellationToken)
    {
        return await context.Educations
            .OrderBy(x => x.Name)
            .ProjectTo<EducationDto>(mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
