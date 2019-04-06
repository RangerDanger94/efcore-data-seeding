using System.ComponentModel;

namespace SeedData.Domain.Enums
{
    /// <summary>
    /// Basic CRUD permissions
    /// </summary>
    public enum Permissions
    {
        [Description("User can create additional user accounts")]
        UserCanCreate = 1,
        [Description("User can view other user accounts")]
        UserCanRead,
        [Description("User can update other user accounts")]
        UserCanUpdate,
        [Description("User can delete other user accounts")]
        UserCanDelete
    }
}
