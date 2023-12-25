using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.Certificates.Queries.GetCertificatesWithPagination;

public class CertificateDto
{
    public Guid Id { get; init; }
    
    public string Name { get; init; } = string.Empty;

    public string Issuer { get; init; } = string.Empty;

    public Uri? VerificationUrl { get; init; }

    public DateOnly IssueDate { get; init; }

    public DateOnly? ExpirationDate { get; init; }
    
    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Certificate, CertificateDto>();
        }
    }
}
