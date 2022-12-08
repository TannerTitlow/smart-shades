using Abp.Auditing;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using SmartShades.Authorization.Users;
using SmartShades;
using SmartShades.Domains.Homes;
using SmartShades.Domains.Shades;
using System;
using System.Collections.Generic;

namespace SmartShades.Domains.Rooms
{
    [Audited]
    public class Room : FullAuditedEntity, IPassivable
    {
        public int HomeId { get; set; }
        public string Name { get; set; }
        public Enums.RoomType RoomType { get; set; }
        public bool IsActive { get; set; }

        // Navigational Properties
        public Home Home { get; set; }
        public virtual ICollection<Shade> Shades { get; set; }
    }
}

