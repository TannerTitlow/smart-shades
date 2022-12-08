using Abp.Auditing;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using SmartShades.Domains.Schedules;
using SmartShades.Domains.Shades;
using System;
using System.Collections.Generic;

namespace SmartShades.Domains.Blocks
{
    [Audited]
    public class Block : FullAuditedEntity, IPassivable
    {
        public int ScheduleId { get; set; }
        public string Name { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public bool IsActive { get; set; }

        // Navigational Properties
        public Schedule Schedule { get; set; }
        public virtual ICollection<Shade> Shades { get; set; }
    }
}

