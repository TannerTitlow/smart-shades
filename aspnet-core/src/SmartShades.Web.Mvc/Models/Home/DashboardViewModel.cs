using SmartShades.Web.Models.Rooms;
using System.Collections.Generic;

namespace SmartShades.Web.Models.Home
{
    public class DashboardViewModel
    {
        public DashboardViewModel()
        {
        }

        public long UserId { get; set; }
        public List<RoomCardViewModel> Rooms { get; set; }
    }
}
