using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;
using Abp.Authorization.Users;
using SmartShades;

namespace SmartShades.Blocks.Dto
{
    [AutoMap(typeof(Domains.Blocks.Block))]
    public class BlockDto : EntityDto
    {
        public int ScheduleId { get; set; }
        public string Name { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public bool IsActive { get; set; }
    }
}

