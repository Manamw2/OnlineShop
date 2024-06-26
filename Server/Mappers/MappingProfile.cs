using AutoMapper;
using Server.Models;
using Shared.Dtos.Account;
using Shared.Dtos.Permissions;
using Shared.Dtos.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Mappers
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Role, RoleDto>();
            CreateMap<AppUser, UserInfoDto>();
            CreateMap<Permission, PermissionDto>();
        }
    }
}
