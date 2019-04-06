namespace SeedData.Domain.Models
{
    public class UserPermission
    {
        public int UserId { get; set; }
        public int PermissionId { get; set; }

        public virtual User User { get; set; }
        public virtual TlkpPermission Permission { get; set; }
    }
}
