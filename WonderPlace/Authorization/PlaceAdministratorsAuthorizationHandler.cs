using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WonderPlace.Models;

namespace WonderPlace.Authorization
{
    public class PlaceAdministratorsAuthorizationHandler
        : AuthorizationHandler<OperationAuthorizationRequirement, Place>
    {
        protected override Task HandleRequirementAsync(
                                            AuthorizationHandlerContext context,
                                  OperationAuthorizationRequirement requirement,
                                   Place resource)
        {
            if (context.User == null)
            {
                return Task.CompletedTask;
            }

            // Administrators can do anything.
            if (context.User.IsInRole(Constants.ContactAdministratorsRole))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
