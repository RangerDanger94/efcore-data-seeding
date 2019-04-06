using System.Collections.Generic;

namespace SeedData.Domain.Models
{
    public class TlkpPermission : IEntityWithId, ILookupEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserPermission> UserPermissions { get; set; }
    }
}
