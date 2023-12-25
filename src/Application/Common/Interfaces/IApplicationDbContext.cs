using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.Common.Interfaces;

public interface IApplicationDbContext
{   
    DbSet<Certificate> Certificates { get; }
    
    DbSet<Contact> Contacts  { get; }
    
    DbSet<Education> Educations { get; }
    
    DbSet<Experience> Experiences { get; }
    
    DbSet<Skill> Skills { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
