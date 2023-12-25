using ResumeApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ResumeApp.Infrastructure.Data.Configurations;

public class EducationConfiguration : IEntityTypeConfiguration<Education>
{
    public void Configure(EntityTypeBuilder<Education> builder)
    {
        builder.Property(t => t.Name).HasMaxLength(200).IsRequired();
        builder.Property(t => t.Degree).HasMaxLength(200).IsRequired();
        builder.Property(t => t.FieldOfStudy).HasMaxLength(200).IsRequired();
        builder.Property(t => t.StartDate).IsRequired();
    }
}
