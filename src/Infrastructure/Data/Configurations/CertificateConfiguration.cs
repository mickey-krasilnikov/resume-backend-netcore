using ResumeApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ResumeApp.Infrastructure.Data.Configurations;

public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
{
    public void Configure(EntityTypeBuilder<Certificate> builder)
    {
        builder.Property(t => t.Name).HasMaxLength(200).IsRequired();
        builder.Property(t => t.Issuer).HasMaxLength(200).IsRequired();
        builder.Property(t => t.VerificationUrl).IsRequired();
        builder.Property(t => t.IssueDate).IsRequired();
    }
}
