using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.Educations.Queries.GetEducationsWithPagination;

public class EducationDto
{
    public Guid Id { get; init; }
    
    public string Name { get; init; } = string.Empty;

    public string Degree { get; init; } = string.Empty;

    public string FieldOfStudy { get; init; } = string.Empty;

    public Uri? Url { get; init; }

    public DateOnly StartDate { get; init; }

    public DateOnly? EndDate { get; init; }
    
    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Education, EducationDto>();
        }
    }
}
