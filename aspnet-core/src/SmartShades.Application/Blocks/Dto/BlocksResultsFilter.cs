using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShades.Blocks.Dto
{
    public class BlocksResultFilter
    {
        public BlocksResultFilter() { }

        public string Keyword { get; set; }
        public bool IsActive { get; set; }
        public int? ScheduleId { get; set; }
    }

}
