using SmartShades.Homes.Dto;

namespace SmartShades.Web.Models.Homes
{
    public class CreateEditViewModel
    {
        //Constructors
        public CreateEditViewModel()
        {

        }

        public CreateEditViewModel(HomeDto homeDto)
        {
            Id = homeDto.Id;
            UserId = homeDto.UserId;
            Name = homeDto.Name;
            IsActive = homeDto.IsActive;

        }

        //Properties
        public int Id { get; set; }
        public long UserId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        //Helper Methods
        public HomeDto CreateDto()
        {
            return new HomeDto
            {
                Id = Id,
                UserId = UserId,
                Name = Name,
                IsActive = IsActive
            };
        }
    }

}
