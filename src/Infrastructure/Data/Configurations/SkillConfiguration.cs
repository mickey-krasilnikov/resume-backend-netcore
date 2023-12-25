using ResumeApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ResumeApp.Infrastructure.Data.Configurations;

public class SkillConfiguration : IEntityTypeConfiguration<Skill>
{
    public void Configure(EntityTypeBuilder<Skill> builder)
    {
        builder.Property(t => t.Name).HasMaxLength(200).IsRequired();
        builder.Property(t => t.SkillGroup).HasMaxLength(200).IsRequired();
    }
}
