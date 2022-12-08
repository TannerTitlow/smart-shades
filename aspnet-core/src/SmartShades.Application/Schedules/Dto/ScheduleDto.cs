using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;
using Abp.Authorization.Users;
using SmartShades;

namespace SmartShades.Schedules.Dto
{
    [AutoMap(typeof(Domains.Schedules.Schedule))]
    public class ScheduleDto : EntityDto
    {
        public int HomeId { get; set; }
        public string Name { get; set; }
        public int DailyFrequency { get; set; }
        public int WeeklyFrequency { get; set; }
        public bool IsMonthly { get; set; }
        public bool IsActive { get; set; }
    }
}

