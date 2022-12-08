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
using SmartShades.Domains.Blocks;

namespace SmartShades.Blocks.Dto
{
    public class BlocksTableDto
    {
        public BlocksTableDto()
        {
        }
        
        public BlocksTableDto(Block block)
        {
            Id = block.Id;
            ScheduleId = block.ScheduleId;
            Name = block.Name;
            OpenTime = block.OpenTime;
            CloseTime = block.CloseTime;
            IsActive = block.IsActive;
        }

        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public string Name { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public bool IsActive { get; set; }
    }
}

