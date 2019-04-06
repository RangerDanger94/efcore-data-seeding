using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeedData.Domain.Models;

namespace SeedData.DAL.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .HasColumnName("UserId")
                .UseNpgsqlIdentityAlwaysColumn();

            builder.HasIndex(e => e.Username)
                .IsUnique();
            builder.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasIndex(e => e.Email)
                .IsUnique();
            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(e => e.Password)
                .HasMaxLength(255);

            builder.Property(e => e.PhoneNumber)
                .HasMaxLength(20);

            builder.HasMany(e => e.UserPermissions)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new User[]
            {
                new User { Id = ApplicationContext.SystemUserId, Username = "System User", Email = "mail@jmartin.me" }
            });
        }
    }
}
