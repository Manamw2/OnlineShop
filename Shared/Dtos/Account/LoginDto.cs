using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Dtos.Account
{
    public class LoginDto
    {
        [Required]
        public string UserNameOrEmail { get; set; }

        [Required]
        public string Password { get; set; }
    }
}