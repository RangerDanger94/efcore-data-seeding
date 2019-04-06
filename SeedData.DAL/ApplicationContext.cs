using Microsoft.EntityFrameworkCore;
using SeedData.Domain.Models;

namespace SeedData.DAL
{
    public class ApplicationContext : DbContext
    {
        public const int SystemUserId = 1;
        public DbSet<User> Users { get; set; }
        public DbSet<TlkpPermission> Permissions { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
    }
}
