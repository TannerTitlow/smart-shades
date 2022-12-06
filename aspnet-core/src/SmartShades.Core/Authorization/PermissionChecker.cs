using Abp.Authorization;
using SmartShades.Authorization.Roles;
using SmartShades.Authorization.Users;

namespace SmartShades.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
