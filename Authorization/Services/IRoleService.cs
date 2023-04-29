namespace Authorization.Services;

public interface IRoleService
{
    bool UserHasRole(string userId, string role);
}
