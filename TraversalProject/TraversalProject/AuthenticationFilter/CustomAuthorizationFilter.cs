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
    public class CustomAuthorizationFilter : IAuthorizationFilter
    {
        private readonly string _policyName;

        public CustomAuthorizationFilter(string policyName)
        {
            _policyName = policyName;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var authService = context.HttpContext.RequestServices.GetRequiredService<IAuthorizationService>();
            var authResult = authService.AuthorizeAsync(context.HttpContext.User, null, _policyName).Result;

            if (!authResult.Succeeded)
            {
                context.Result = new ForbidResult();
            }
        }
    }
}
