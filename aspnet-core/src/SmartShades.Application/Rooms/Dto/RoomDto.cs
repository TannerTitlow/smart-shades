using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;
using Abp.Authorization.Users;
using SmartShades;

namespace SmartShades.Rooms.Dto
{
    [AutoMap(typeof(Domains.Rooms.Room))]
    public class RoomDto : EntityDto
    {
        public int HomeId { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Enums.RoomType RoomType { get; set; }
        public bool IsActive { get; set; }
    }
}

