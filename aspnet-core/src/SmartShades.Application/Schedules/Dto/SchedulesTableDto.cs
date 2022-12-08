using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;
using Abp.Authorization.Users;
using SmartShades;
using SmartShades.Domains.Homes;
using SmartShades.Domains.Shades;
using SmartShades.Domains.Schedules;

namespace SmartShades.Schedules.Dto
{
    public class SchedulesTableDto
    {
        public SchedulesTableDto()
        {
        }
        
        public SchedulesTableDto(Schedule schedule)
        {
            Id = schedule.Id;
            HomeId = schedule.HomeId;
            Name = schedule.Name;
            DailyFrequency = schedule.DailyFrequency;
            WeeklyFrequency = schedule.WeeklyFrequency;
            IsMonthly = schedule.IsMonthly;
            IsActive = schedule.IsActive;
        }

        public int Id { get; set; }
        public int HomeId { get; set; }
        public string Name { get; set; }
        public int DailyFrequency { get; set; }
        public int WeeklyFrequency { get; set; }
        public bool IsMonthly { get; set; }
        public bool IsActive { get; set; }
    }
}

