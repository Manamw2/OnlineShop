﻿using System.Data;
using System.Security;

namespace Server.Models
{
    public class RolePermission
    {
        public string? RoleId { get; set; }
        public Role? Role { get; set; }
        public int PermissionId { get; set; }
        public Permission? Permission { get; set; }
    }
}