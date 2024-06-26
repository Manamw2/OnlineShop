using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Server.Models;
using Shared.Dtos.Role;
using Shared.Interfaces;
using System.Linq;

namespace Server.Services
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly IMapper _mapper;
        public RoleService(RoleManager<Role> roleManager, IMapper mapper)
        {
            _roleManager = roleManager;
            _mapper = mapper;
        }
        public async Task AddRoleAsync(string roleName)
        {
            if (roleName == null)
            {
                throw new ArgumentNullException(nameof(roleName));
            }
            await _roleManager.CreateAsync(new Role { Name = roleName, NormalizedName = roleName.ToUpper() });
        }

        public async Task<bool> DeleteRoleAsync(string roleName)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role == null)
            {
                return false;
            }
            await _roleManager.DeleteAsync(role);
            return true;
        }

        public async Task<string?> EditRoleName(EditRoleDto editRoleDto)
        {
            var role = await _roleManager.FindByNameAsync(editRoleDto.CurrentRoleName);
            if (role == null)
            {
                return null;
            }
            role.Name = editRoleDto.NewRoleName;
            await _roleManager.UpdateAsync(role);
            return role.Name;
        }

        public async Task<IEnumerable<RoleDto>> GetRolesAsync()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            var roleDtos = _mapper.Map<IEnumerable<RoleDto>>(roles);
            return roleDtos;
        }
    }
}
