using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Dtos.Account
{
    public class UserLogInInfo
    {
        public string UserName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Token { get; set; } = "";
        public string Role { get; set; } = "";
    }
}