using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.Skills.Queries.GetSkillsWithPagination;

public class SkillDto
{
    public Guid Id { get; init; }
    
    public string Name { get; set; } = string.Empty;

    public string SkillGroup { get; set; } = string.Empty;

    public int Priority { get; set; }

    public bool IsHighlighted { get; set; }
    
    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Skill, SkillDto>();
        }
    }
}
