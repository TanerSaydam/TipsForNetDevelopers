using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace Authorization.Services;

public sealed class RoleService : IRoleService
{
    public bool UserHasRole(string userId, string role)
    {
        AppDbContext context = new();

        var userHasRole =
        context.UserRoles
        .Where(p => p.UserId == Convert.ToInt32(userId))
        .Include(p => p.Role)
        .Any(p => p.Role.Name == role);

        return userHasRole;
    }
}
