using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Navigation;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc;

namespace SmartShades.Web.Views.Shared.Components.SideBarMenu
{
    public class SideBarMenuViewComponent : SmartShadesViewComponent
    {
        private readonly IUserNavigationManager _userNavigationManager;
        private readonly IAbpSession _abpSession;
        private readonly Sessions.ISessionAppService _sessionsService;

        private List<string> RolesList = new List<string>() { "Admin", "User" };

        public SideBarMenuViewComponent(
            IUserNavigationManager userNavigationManager,
            IAbpSession abpSession,
            Sessions.ISessionAppService sessionsService)
        {
            _userNavigationManager = userNavigationManager;
            _abpSession = abpSession;
            _sessionsService = sessionsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string userRole = "Main";
            foreach (var role in RolesList)
            {
                if (await _sessionsService.IsCurrentUserInRole(role))
                {
                    userRole = role;
                    break;
                }
            }

            var model = new SideBarMenuViewModel
            {
                MainMenu = await _userNavigationManager.GetMenuAsync(userRole + "Menu", _abpSession.ToUserIdentifier())
            };

            return View(model);
        }
    }
}
