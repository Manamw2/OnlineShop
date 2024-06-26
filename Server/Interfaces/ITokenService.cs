using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.Models;

namespace Server.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser appUser, string role);
    }
}