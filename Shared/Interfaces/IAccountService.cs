using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Shared.Dtos.Account;

namespace Shared.Interfaces
{
    public interface IAccountService
    {
        Task<bool> Login(LoginDto loginDto);
        Task<bool> Register(RegisterDto registerDto);
        //Task<bool> UserHasPermissionAsync(ClaimsPrincipal user, string permissionName);
    }
}