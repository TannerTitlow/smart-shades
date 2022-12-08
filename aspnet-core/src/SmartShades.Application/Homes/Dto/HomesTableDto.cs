using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;
using Abp.Authorization.Users;
using SmartShades;
using SmartShades.Domains.Homes;

namespace SmartShades.Homes.Dto
{
    public class HomesTableDto
    {
        public HomesTableDto()
        {
        }
        
        public HomesTableDto(Home home)
        {
            UserId = home.UserId;
            Name = home.Name;
            IsActive = home.IsActive;
        }

        public long UserId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}

