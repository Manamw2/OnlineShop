using Microsoft.AspNetCore.Identity;

namespace Server.Models
{
    public class Role : IdentityRole
    {
        public List<RolePermission>? RolePermissions { get; set; }
    }
}
