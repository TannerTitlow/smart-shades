using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SmartShades.Controllers;
using SmartShades.Web.Models.Home;
using SmartShades.Rooms.Dto;
using System.Collections.Generic;
using SmartShades.Web.Models.Rooms;

namespace SmartShades.Web.Controllers
{
[AbpMvcAuthorize]
public class HomeController : SmartShadesControllerBase
{
        public ActionResult Index()
        {
            var model = new DashboardViewModel();

            var room1 = new RoomDto()
            {
                HomeId = 1,
                RoomType = Enums.RoomType.Bedroom,
                Name = "Bedroom",
                IsActive = true
            };
            var room2 = new RoomDto()
            {
                HomeId = 1,
                RoomType = Enums.RoomType.LivingRoom,
                Name = "Den",
                IsActive = true
            };
            var room3 = new RoomDto()
            {
                HomeId = 1,
                RoomType = Enums.RoomType.Kitchen,
                Name = "Kitchen",
                IsActive = true
            };

            model.Rooms = new List<RoomCardViewModel>()
            {
                new RoomCardViewModel(room1),
                new RoomCardViewModel(room2),
                new RoomCardViewModel(room3)
            };

            return View(model);
        }
    }
}
