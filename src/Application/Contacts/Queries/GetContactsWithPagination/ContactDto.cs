using ResumeApp.Domain.Entities;
using ResumeApp.Domain.Enums;

namespace ResumeApp.Application.Contacts.Queries.GetContactsWithPagination;

public class ContactDto
{
    public Guid Id { get; init; }
    
    public ContactType Type { get; init; } = ContactType.Undefined;

    public string Key { get; init; } = string.Empty;
    
    public string Value { get; init; } = string.Empty;

    public string Link { get; init; } = string.Empty;
    
    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Contact, ContactDto>();
        }
    }
}
