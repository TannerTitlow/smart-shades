using Abp.Auditing;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using SmartShades.Authorization.Users;
using SmartShades.Domains.Homes;
using SmartShades.Domains.Rooms;
using System;

namespace SmartShades.Domains.Shades
{
    [Audited]
    public class Shade : FullAuditedEntity, IPassivable
    {
        public int RoomId { get; set; }
        public int? BlockId { get; set; }
        public string Name { get; set; }
        public int PercentClosed { get; set; }
        public bool IsActive { get; set; }

        // Navigational Properties
        public Room Room { get; set; }
    }
}

