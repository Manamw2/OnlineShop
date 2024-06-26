using Shared.Dtos.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Account
{
    public class UserMeInfo
    {
        public string? Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string RoleName { get; set; } = string.Empty;
        public List<PermissionDto> Permissions { get; set;} = new List<PermissionDto>();
    }
}
