using ResumeApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ResumeApp.Infrastructure.Data.Configurations;

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.Property(t => t.Value).HasMaxLength(200).IsRequired();
        builder.Property(t => t.Link).IsRequired();
        builder.Property(t => t.Type).IsRequired();
    }
}
