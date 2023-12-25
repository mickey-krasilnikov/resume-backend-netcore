namespace ResumeApp.Domain.Entities;

public class Skill : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public string SkillGroup { get; set; } = string.Empty;

    public int Priority { get; set; }

    public bool IsHighlighted { get; set; }
    
    public virtual IList<Experience> Experiences { get; private set; } = new List<Experience>();
}
