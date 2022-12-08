using SmartShades.Domains.Rooms;
using SmartShades.Homes.Dto;
using SmartShades.Rooms.Dto;

namespace SmartShades.Web.Models.Rooms
{
    public class CreateEditViewModel
    {
        //Constructors
        public CreateEditViewModel()
        {

        }

        public CreateEditViewModel(RoomDto roomDto)
        {
            Id = roomDto.Id;
            HomeId = roomDto.HomeId;
            Name = roomDto.Name;
            RoomType = roomDto.RoomType;
            IsActive = roomDto.IsActive;

        }

        //Properties
        public int Id { get; set; }
        public int HomeId { get; set; }
        public string Name { get; set; }
        public Enums.RoomType RoomType { get; set; }
        public bool IsActive { get; set; }

        //Helper Methods
        public RoomDto CreateDto()
        {
            return new RoomDto
{
                Id = Id,
                HomeId = HomeId,
                Name = Name,
                RoomType = RoomType,
                IsActive = IsActive
            };
        }
    }

}
