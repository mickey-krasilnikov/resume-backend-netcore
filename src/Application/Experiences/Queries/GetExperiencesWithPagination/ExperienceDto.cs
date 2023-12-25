using ResumeApp.Application.Skills.Queries.GetSkillsWithPagination;
using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.Experiences.Queries.GetExperiencesWithPagination;

public class ExperienceDto
{
    public Guid Id { get; init; }
    
    public string Title { get; init; } = string.Empty;

    public string Company { get; init; } = string.Empty;

    public string Location { get; init; } = string.Empty;

    public string TaskPerformed { get; init; } = string.Empty;

    public DateOnly StartDate { get; init; }

    public DateOnly? EndDate { get; init; }

    public IList<SkillBriefDto> Skills { get; init; } = new List<SkillBriefDto>();
    
    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Experience, ExperienceDto>();
        }
    }
}
