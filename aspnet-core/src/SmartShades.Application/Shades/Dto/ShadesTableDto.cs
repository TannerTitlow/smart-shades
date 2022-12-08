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

namespace SmartShades.Shades.Dto
{
    public class ShadesTableDto
    {
        public ShadesTableDto()
        {
        }
        
        public ShadesTableDto(Shade shade)
        {
            RoomId = shade.RoomId;
            Name = shade.Name;
            PercentClosed = shade.PercentClosed;
            IsActive = shade.IsActive;
        }

        public int RoomId { get; set; }
        public string Name { get; set; }
        public int PercentClosed { get; set; }
        public bool IsActive { get; set; }
    }
}

