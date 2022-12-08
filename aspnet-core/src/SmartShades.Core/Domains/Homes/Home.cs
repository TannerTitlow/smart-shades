using Abp.Auditing;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using SmartShades.Authorization.Users;
using SmartShades.Domains.Rooms;
using System;
using System.Collections.Generic;

namespace SmartShades.Domains.Homes
{
    [Audited]
    public class Home : FullAuditedEntity, IPassivable
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        // Navigational Properties
        public User User { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}

