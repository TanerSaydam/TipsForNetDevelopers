using Authorization.Services;
using DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Authorization.Attributes;

public sealed class RoleAttribute : Attribute, IAuthorizationFilter
{
    private readonly string _role;   
    private readonly IRoleService _roleService;
    public RoleAttribute(string role, IRoleService roleService)
    {
        _role = role;
        _roleService = roleService;
    }
    public void OnAuthorization(AuthorizationFilterContext context)
    {        
        var userIdClaim = context.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
        if (userIdClaim == null)
        {
            context.Result = new UnauthorizedResult();
            return;
        }

        var userHasRole = _roleService.UserHasRole(userIdClaim.Value, _role);
            
        if (!userHasRole) 
        {
            context.Result = new UnauthorizedResult();
            return;
        }
    }
}
