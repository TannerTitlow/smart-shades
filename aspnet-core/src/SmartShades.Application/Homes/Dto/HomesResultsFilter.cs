using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShades.Homes.Dto
{
    public class HomesResultFilter
    {
        public HomesResultFilter() { }

        public string Keyword { get; set; }
        public bool IsActive { get; set; }
        public long UserId { get; set; }
    }

}
