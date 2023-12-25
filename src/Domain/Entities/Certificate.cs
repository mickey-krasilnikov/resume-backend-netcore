namespace ResumeApp.Domain.Entities;

public class Certificate : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public string Issuer { get; set; } = string.Empty;

    public Uri? VerificationUrl { get; set; }

    public DateOnly IssueDate { get; set; }

    public DateOnly? ExpirationDate { get; set; }
}
