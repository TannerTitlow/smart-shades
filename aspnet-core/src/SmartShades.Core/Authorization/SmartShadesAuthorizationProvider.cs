using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace SmartShades.Authorization
{
    public class SmartShadesAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            context.CreatePermission(PermissionNames.Pages_Homes, L("Homes"));
            context.CreatePermission(PermissionNames.Pages_Rooms, L("Rooms"));
            context.CreatePermission(PermissionNames.Pages_Shades, L("Shades"));
            context.CreatePermission(PermissionNames.Pages_Schedules, L("Schedules"));
            context.CreatePermission(PermissionNames.Pages_Blocks, L("Blocks"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, SmartShadesConsts.LocalizationSourceName);
        }
    }
}
