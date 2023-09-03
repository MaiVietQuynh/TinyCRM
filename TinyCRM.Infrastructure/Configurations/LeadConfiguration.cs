using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TinyCRM.Domain.Entities;

namespace TinyCRM.Infrastructure.Configurations;

public class LeadConfiguration : IEntityTypeConfiguration<Lead>
{
    public void Configure(EntityTypeBuilder<Lead> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.EstimatedRevenue)
            .HasColumnType("decimal(18,2)");

        builder.Property(x => x.Description)
            .HasMaxLength(500);

        builder.Property(x => x.Status)
            .IsRequired()
            .HasConversion<string>();
        
        builder.Property(x => x.Source)
            .HasConversion<string>();
        
        builder.Property(x => x.Disqualification)
            .HasConversion<string>();

        builder.Property(x => x.DisqualificationDescription)
            .HasMaxLength(500);
        
        builder.Property(x => x.CustomerId)
            .IsRequired();

        builder.HasOne<Account>(x => x.Customer)
            .WithMany(x => x.Leads)
            .HasForeignKey(x => x.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}