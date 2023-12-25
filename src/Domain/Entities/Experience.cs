namespace ResumeApp.Domain.Entities;

public class Experience : BaseAuditableEntity
{
    public string Title { get; set; } = string.Empty;

    public string Company { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public string TaskPerformed { get; set; } = string.Empty;

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public virtual IList<Skill> Skills { get; private set; } = new List<Skill>();
}
