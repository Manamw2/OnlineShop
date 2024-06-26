using Shared.Dtos.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IRolePermissionService
    {
        Task AddPermissionToRoleAsync(int permmissionId, string roleId);
        Task<bool> DeletePermissionToRoleAsync(int permmissionId, string roleId);
        Task<bool> UpdateRolePermissionsAsync(string roleName, IEnumerable<int> permissionIds);
        Task<bool> UserHasPermissionAsync(ClaimsPrincipal user, string permissionName);
        Task<List<PermissionDto>> GetRolePermissionsAsync(string roleId);
    }
}
