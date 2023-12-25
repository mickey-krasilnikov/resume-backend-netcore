using ResumeApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ResumeApp.Infrastructure.Data.Configurations;

public class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
{
    public void Configure(EntityTypeBuilder<Experience> builder)
    {
        builder.Property(t => t.Title).HasMaxLength(200).IsRequired();
        builder.Property(t => t.Company).HasMaxLength(200).IsRequired();
        builder.Property(t => t.Location).HasMaxLength(200).IsRequired();
        builder.Property(t => t.StartDate).IsRequired();
    }
}
