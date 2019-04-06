using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeedData.Domain.Enums;
using SeedData.Domain.Models;

namespace SeedData.DAL.Configuration
{
    public class TlkpPermissionConfiguration : IEntityTypeConfiguration<TlkpPermission>
    {
        public void Configure(EntityTypeBuilder<TlkpPermission> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .HasColumnName("TlkpPermissionId")
                .UseNpgsqlIdentityAlwaysColumn();

            builder.Property(e => e.Code)
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(e => e.Description)
                .HasMaxLength(255)
                .IsRequired();

            builder.HasMany(e => e.UserPermissions)
                .WithOne(e => e.Permission)
                .HasForeignKey(e => e.PermissionId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasEnumData(typeof(Permissions));
        }
    }
}
