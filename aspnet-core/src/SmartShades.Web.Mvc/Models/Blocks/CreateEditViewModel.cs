using SmartShades.Blocks.Dto;
using SmartShades.Domains.Rooms;
using SmartShades.Homes.Dto;
using SmartShades.Rooms.Dto;
using System;

namespace SmartShades.Web.Models.Blocks
{
    public class CreateEditViewModel
    {
        //Constructors
        public CreateEditViewModel()
        {

        }

        public CreateEditViewModel(BlockDto blockDto)
        {
            Id = blockDto.Id;
            ScheduleId = blockDto.ScheduleId;
            Name = blockDto.Name;
            OpenTime = blockDto.OpenTime;
            CloseTime = blockDto.CloseTime;
            IsActive = blockDto.IsActive;

        }

        //Properties
        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public string Name { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public bool IsActive { get; set; }

        //Helper Methods
        public BlockDto CreateDto()
        {
            return new BlockDto
{
                Id = Id,
                ScheduleId = ScheduleId,
                Name = Name,
                OpenTime = OpenTime,
                CloseTime = CloseTime,
                IsActive = IsActive
            };
        }
    }

}
