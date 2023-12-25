namespace ResumeApp.Domain.Entities;

public class Education : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public string Degree { get; set; } = string.Empty;

    public string FieldOfStudy { get; set; } = string.Empty;

    public Uri? Url { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }
}
