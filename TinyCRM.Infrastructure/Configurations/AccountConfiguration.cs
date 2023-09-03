using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TinyCRM.Domain.Entities;

namespace TinyCRM.Infrastructure.Configurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired().HasMaxLength(20);

        builder.Property(x => x.Email)
            .IsRequired().HasMaxLength(20);

        builder.Property(x => x.Phone)
            .IsRequired().HasMaxLength(20);

        builder.Property(x => x.Address)
            .HasMaxLength(50);

        builder.Property(x => x.TotalSales)
            .HasColumnType("decimal(18,2)");
    }
}