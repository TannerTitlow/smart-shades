using SmartShades.Rooms.Dto;
using System.Collections.Generic;

namespace SmartShades.Web.Models.Rooms
{
    public class RoomCardViewModel
    {
        //Constructors
        public RoomCardViewModel() { }

        public RoomCardViewModel(RoomDto room)
        {
            RoomType = room.RoomType.GetEnumDisplayName();
            Icon = IconMappings[room.RoomType];
        }

        //Properties
        public string RoomType { get; set; }
        public string Icon { get; set; }

        private Dictionary<Enums.RoomType, string> IconMappings = new Dictionary<Enums.RoomType, string>
        {
            { Enums.RoomType.Bedroom, "fa-bed" },
            { Enums.RoomType.Bathroom, "fa-bath" },
            { Enums.RoomType.Kitchen, "fa-utensils" },
            { Enums.RoomType.LivingRoom, "fa-couch" },
            { Enums.RoomType.DiningRoom, "fa-wine-glass-alt" },
            { Enums.RoomType.Office, "fa-laptop" },
            { Enums.RoomType.Garage, "fa-warehouse" }
        };
    }
}
