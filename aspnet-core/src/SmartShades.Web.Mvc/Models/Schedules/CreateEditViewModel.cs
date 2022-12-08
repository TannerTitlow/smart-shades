using SmartShades.Domains.Shades;
using SmartShades.Homes.Dto;
using SmartShades.Schedules.Dto;
using SmartShades.Shades.Dto;

namespace SmartShades.Web.Models.Schedules
{
    public class CreateEditViewModel
    {
        //Constructors
        public CreateEditViewModel()
        {

        }

        public CreateEditViewModel(ScheduleDto scheduleDto)
        {
            Id = scheduleDto.Id;
            HomeId = scheduleDto.HomeId;
            Name = scheduleDto.Name;
            DailyFrequency = scheduleDto.DailyFrequency;
            WeeklyFrequency = scheduleDto.WeeklyFrequency;
            IsMonthly = scheduleDto.IsMonthly;
            IsActive = scheduleDto.IsActive;
        }

        //Properties
        public int Id { get; set; }
        public int HomeId { get; set; }
        public string Name { get; set; }
        public int DailyFrequency { get; set; }
        public int WeeklyFrequency { get; set; }
        public bool IsMonthly { get; set; }
        public bool IsActive { get; set; }

        //Helper Methods
        public ScheduleDto CreateDto()
        {
            return new ScheduleDto
{
                Id = Id,
                HomeId = HomeId,
                Name = Name,
                DailyFrequency = DailyFrequency,
                WeeklyFrequency = WeeklyFrequency,
                IsMonthly = IsMonthly,
                IsActive = IsActive
            };
        }
    }

}
