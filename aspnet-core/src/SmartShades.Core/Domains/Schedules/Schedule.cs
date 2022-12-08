using Abp.Auditing;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using SmartShades.Authorization.Users;
using SmartShades.Domains.Blocks;
using SmartShades.Domains.Homes;
using SmartShades.Domains.Rooms;
using SmartShades.Domains.Shades;
using System;
using System.Collections.Generic;

namespace SmartShades.Domains.Schedules
{
    [Audited]
    public class Schedule : FullAuditedEntity, IPassivable
    {
        public int HomeId { get; set; }
        public string Name { get; set; }
        public int DailyFrequency { get; set; }
        public int WeeklyFrequency { get; set; }
        public bool IsMonthly { get; set; }
        public bool IsActive { get; set; }

        // Navigational Properties
        public Home Home { get; set; }
        public virtual ICollection<Block> TimeBlocks { get; set; }
    }
}

