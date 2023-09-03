using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TinyCRM.Domain.Entities;

namespace TinyCRM.Infrastructure.Configurations;

public class DealConfiguration: IEntityTypeConfiguration<Deal>
{
    public void Configure(EntityTypeBuilder<Deal> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Description)
            .HasMaxLength(500);
        
        builder.Property(x => x.EstimatedRevenue);

        builder.Property(x => x.Status)
            .IsRequired()
            .HasConversion<string>();
        
        builder.Property(x => x.LeadId)
            .IsRequired();
        
        builder.HasOne(x => x.Lead)
            .WithOne(x => x.Deal)
            .HasForeignKey<Deal>(x=>x.LeadId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}