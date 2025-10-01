using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using SecureWebApp.Entities;

//C# language has concept of Attributes
// Attributes are use to add metadata to code (class, metho)
namespace SecureWebApp.Helpers;
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]

public class AuthorizeAttribute : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var user = (User)context.HttpContext.Items["User"];
        if (user == null)
        {
            context.Result = new JsonResult(new { message = "unauthorized" }) {StatusCode = StatusCode.Status401Unauthorized};
        }
    }
}