using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TinyCRM.Domain.Entities;

namespace TinyCRM.Infrastructure.Configurations;

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired().HasMaxLength(20);

        builder.Property(x => x.Email)
            .IsRequired().HasMaxLength(20);

        builder.Property(x => x.Phone)
            .IsRequired().HasMaxLength(20);

        builder.HasOne<Account>(x => x.Account)
            .WithMany(x => x.Contacts)
            .HasForeignKey(x => x.AccountId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}