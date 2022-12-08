using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;
using Abp.Authorization.Users;
using SmartShades;
using SmartShades.Domains.Homes;
using SmartShades.Domains.Rooms;

namespace SmartShades.Rooms.Dto
{
    public class RoomsTableDto
    {
        public RoomsTableDto()
        {
        }
        
        public RoomsTableDto(Room room)
        {
            HomeId = room.HomeId;
            Name = room.Name;
            RoomType = room.RoomType.GetEnumDisplayName();
            IsActive = room.IsActive;
        }

        public int HomeId { get; set; }
        public string Name { get; set; }
        public string RoomType { get; set; }
        public bool IsActive { get; set; }
    }
}

