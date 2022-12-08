using Abp.Application.Navigation;
using Abp.Authorization;
using Abp.Localization;
using SmartShades.Authorization;

namespace SmartShades.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class SmartShadesNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            var AdminMenu = new MenuDefinition("AdminMenu", L("AdminMenu"));
            var UserMenu = new MenuDefinition("UserMenu", L("UserMenu"));

            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("Dashboard"),
                        url: "",
                        icon: "fas fa-house-user",
                        requiresAuthentication: true
                    )
                );

            AdminMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("Dashboard"),
                        url: "",
                        icon: "fas fa-house-user",
                        requiresAuthentication: true
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Users,
                        L("Users"),
                        url: "Users",
                        icon: "fas fa-users",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Users)
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Roles,
                        L("Roles"),
                        url: "Roles",
                        icon: "fas fa-theater-masks",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Roles)
                    )
                );

            UserMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("Dashboard"),
                        url: "",
                        icon: "fas fa-house-user",
                        requiresAuthentication: true
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Homes,
                        L("Homes"),
                        url: "Homes",
                        icon: "fas fa-home",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Homes)
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Rooms,
                        L("Rooms"),
                        url: "Rooms",
                        icon: "fas fa-door-open",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Rooms)
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Shades,
                        L("Shades"),
                        url: "Shades",
                        icon: "fas fa-water",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Shades)
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Schedules,
                        L("Schedules"),
                        url: "Schedules",
                        icon: "fas fa-calendar-day",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Schedules)
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Blocks,
                        L("Blocks"),
                        url: "Blocks",
                        icon: "fas fa-stopwatch",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Blocks)
                    )
                );

            context.Manager.Menus.Add("AdminMenu", AdminMenu);
            context.Manager.Menus.Add("UserMenu", UserMenu);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, SmartShadesConsts.LocalizationSourceName);
        }
    }
}