using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TinyCRM.Domain.Entities;

namespace TinyCRM.Infrastructure.Configurations;

public class DealProductConfiguration : IEntityTypeConfiguration<DealProduct>
{
    public void Configure(EntityTypeBuilder<DealProduct> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Quantity)
            .IsRequired();

        builder.Property(x => x.PricePerUnit)
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.HasOne<Product>(x => x.Product)
            .WithMany(x => x.DealProducts)
            .HasForeignKey(x => x.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne<Deal>(x => x.Deal)
            .WithMany(x => x.DealProducts)
            .HasForeignKey(x => x.DealId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}