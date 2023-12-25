using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Application.Common.Mappings;
using ResumeApp.Application.Common.Models;

namespace ResumeApp.Application.Skills.Queries.GetSkillsWithPagination;

public record GetSkillsWithPaginationQuery : IRequest<PaginatedList<SkillDto>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetSkillsWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
    : IRequestHandler<GetSkillsWithPaginationQuery, PaginatedList<SkillDto>>
{
    public async Task<PaginatedList<SkillDto>> Handle(GetSkillsWithPaginationQuery request, CancellationToken cancellationToken)
    {
        return await context.Skills
            .OrderBy(x => x.Name)
            .ProjectTo<SkillDto>(mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
