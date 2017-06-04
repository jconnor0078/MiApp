using Abp.Authorization;
using MiApp.Authorization.Roles;
using MiApp.MultiTenancy;
using MiApp.Users;

namespace MiApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
