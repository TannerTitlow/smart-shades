using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;
using Abp.Authorization.Users;
using SmartShades;

namespace SmartShades.Shades.Dto
{
    [AutoMap(typeof(Domains.Shades.Shade))]
    public class ShadeDto : EntityDto
    {
        public int RoomId { get; set; }
        public string Name { get; set; }
        public int PercentClosed { get; set; }
        public bool IsActive { get; set; }
    }
}

