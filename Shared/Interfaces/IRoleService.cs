using Shared.Dtos.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IRoleService
    {
        Task AddRoleAsync(string roleName);
        Task<IEnumerable<RoleDto>> GetRolesAsync();
        Task<bool> DeleteRoleAsync(string roleName);
        Task<string?> EditRoleName(EditRoleDto roleName);
    }
}
