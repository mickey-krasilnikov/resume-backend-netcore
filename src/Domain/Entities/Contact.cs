namespace ResumeApp.Domain.Entities;

public class Contact : BaseAuditableEntity
{
    public ContactType Type { get; set; } = ContactType.Undefined;

    public string Key { get; set; } = string.Empty;
    
    public string Value { get; set; } = string.Empty;

    public string Link { get; set; } = string.Empty;
}
