using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.AuthenticationFilter
{
    public class AdminPolicyFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().RequireRole("Admin").Build();
            var authService = context.HttpContext.RequestServices.GetRequiredService<IAuthorizationService>();
            var authResult = authService.AuthorizeAsync(context.HttpContext.User, null, policy).Result;
            if (!authResult.Succeeded)
        {
            context.Result = new ForbidResult();
        }
        }
    }
}
