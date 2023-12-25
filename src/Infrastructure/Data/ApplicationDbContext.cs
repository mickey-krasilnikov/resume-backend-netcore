using System.Reflection;
using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Domain.Entities;
using ResumeApp.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ResumeApp.Domain.Enums;

namespace ResumeApp.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options), IApplicationDbContext
{   
    public DbSet<Certificate> Certificates  => Set<Certificate>();
    
    public DbSet<Contact> Contacts  => Set<Contact>();
    
    public DbSet<Education> Educations => Set<Education>();
    
    public DbSet<Experience> Experiences  => Set<Experience>();
    
    public DbSet<Skill> Skills  => Set<Skill>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        builder.Entity<Contact>()
            .Property(e => e.Type)
            .HasConversion(
                v => v.ToString(),
                v => (ContactType)Enum.Parse(typeof(ContactType), v!));

        base.OnModelCreating(builder);
    }
}
