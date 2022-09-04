using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApi.Entities;

public class UniversityConfiguration : IEntityTypeConfiguration<University>
{
    public void Configure(EntityTypeBuilder<University> builder)
    {
        builder.HasKey(b=>b.Id);
        builder.Property(b=>b.Name).HasMaxLength(20).IsRequired(false);
        builder.Property(b=>b.Email).HasMaxLength(25).IsRequired(false);
        builder.Property(b=>b.Rooms).HasMaxLength(20).IsRequired(true);
        builder.Property(b=>b.Category).HasMaxLength(25).IsRequired();
        builder.Property(b=>b.AccountNumber).HasMaxLength(20).IsRequired();
        builder.Property(b=>b.Adres).HasMaxLength(40).IsRequired(true);
    }
}