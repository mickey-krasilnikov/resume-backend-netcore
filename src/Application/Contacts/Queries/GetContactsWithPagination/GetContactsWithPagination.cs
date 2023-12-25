using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Application.Common.Mappings;
using ResumeApp.Application.Common.Models;

namespace ResumeApp.Application.Contacts.Queries.GetContactsWithPagination;

public record GetContactsWithPaginationQuery : IRequest<PaginatedList<ContactDto>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetContactsWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
    : IRequestHandler<GetContactsWithPaginationQuery, PaginatedList<ContactDto>>
{
    public async Task<PaginatedList<ContactDto>> Handle(GetContactsWithPaginationQuery request, CancellationToken cancellationToken)
    {
        return await context.Contacts
            .OrderBy(x => x.Key)
            .ProjectTo<ContactDto>(mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
