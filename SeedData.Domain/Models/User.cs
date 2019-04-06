using System.Collections.Generic;

namespace SeedData.Domain.Models
{
    public class User : IEntityWithId
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<UserPermission> UserPermissions { get; set; }
    }
}
