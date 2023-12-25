using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Application.Common.Mappings;
using ResumeApp.Application.Common.Models;

namespace ResumeApp.Application.Experiences.Queries.GetExperiencesWithPagination;

public record GetExperiencesWithPaginationQuery : IRequest<PaginatedList<ExperienceDto>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetExperiencesWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
    : IRequestHandler<GetExperiencesWithPaginationQuery, PaginatedList<ExperienceDto>>
{
    public async Task<PaginatedList<ExperienceDto>> Handle(GetExperiencesWithPaginationQuery request, CancellationToken cancellationToken)
    {
        return await context.Experiences
            .OrderByDescending(x => x.StartDate)
            .ProjectTo<ExperienceDto>(mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
