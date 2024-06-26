﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Interfaces;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolePermissoinController : ControllerBase
    {
        private readonly IRolePermissionService _rolePermissionService;
        public RolePermissoinController(IRolePermissionService rolePermissionService)
        {
            _rolePermissionService = rolePermissionService;
        }

        [HttpPost("updaterolepermissions/{roleName}")]
        public async Task<IActionResult> UpdateRolePermissions([FromRoute] string roleName, [FromBody] List<int> permissionIds)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            if(!await _rolePermissionService.UpdateRolePermissionsAsync(roleName, permissionIds))
                return NotFound();
            return Ok("Permissions has been updated successfully");
        }
    }
}