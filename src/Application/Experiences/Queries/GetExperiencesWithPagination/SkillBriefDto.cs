using ResumeApp.Application.Skills.Queries.GetSkillsWithPagination;
using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.Experiences.Queries.GetExperiencesWithPagination;

public class SkillBriefDto
{
    public Guid Id { get; init; }
    
    public string Name { get; set; } = string.Empty;
    
    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Skill, SkillBriefDto>();
        }
    }
}
