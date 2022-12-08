using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;
using Abp.Authorization.Users;
using SmartShades;

namespace SmartShades.Homes.Dto
{
    [AutoMap(typeof(Domains.Homes.Home))]
    public class HomeDto : EntityDto
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}

