using Server.Models;
using Shared.Dtos.Account;
using Shared.Dtos.Permissions;

namespace Server.Mappers
{
    public static class AccountMapper
    {
       public static UserMeInfo UserToUserMeInfo(this AppUser user, string roleName, List<PermissionDto> permissions )
        {
            return new UserMeInfo
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                RoleName = roleName,
                Permissions = permissions
            };
        }
    }
}
