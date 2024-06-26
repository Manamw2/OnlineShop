﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces;

namespace Shared.Authorizaion
{
    public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;
        public PermissionAuthorizationHandler(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }
        
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {
            var user = context.User;

            if (user == null || !user.Identity.IsAuthenticated)
            {
                context.Fail();
                return;
            }

            using IServiceScope scope = _serviceScopeFactory.CreateScope();
            IRolePermissionService _rolePermissionService = scope.ServiceProvider.GetRequiredService<IRolePermissionService>();

            if (await _rolePermissionService.UserHasPermissionAsync(user, requirement.Permission))
            {
                context.Succeed(requirement);
            }
        }
    }
}