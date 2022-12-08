using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShades.Schedules.Dto
{
    public class SchedulesResultFilter
    {
        public SchedulesResultFilter() { }

        public string Keyword { get; set; }
        public bool IsActive { get; set; }
        public int? HomeId { get; set; }
    }

}
