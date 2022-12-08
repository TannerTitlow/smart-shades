using SmartShades.Domains.Shades;
using SmartShades.Homes.Dto;
using SmartShades.Shades.Dto;

namespace SmartShades.Web.Models.Shades
{
    public class CreateEditViewModel
    {
        //Constructors
        public CreateEditViewModel()
        {

        }

        public CreateEditViewModel(ShadeDto roomDto)
        {
            Id = roomDto.Id;
            RoomId = roomDto.RoomId;
            Name = roomDto.Name;
            PercentClosed = roomDto.PercentClosed;
            IsActive = roomDto.IsActive;

        }

        //Properties
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string Name { get; set; }
        public int PercentClosed { get; set; }
        public bool IsActive { get; set; }

        //Helper Methods
        public ShadeDto CreateDto()
        {
            return new ShadeDto
{
                Id = Id,
                RoomId = RoomId,
                Name = Name,
                PercentClosed = PercentClosed,
                IsActive = IsActive
            };
        }
    }

}
