using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShades.Rooms.Dto
{
    public class RoomsResultFilter
    {
        public RoomsResultFilter() { }

        public string Keyword { get; set; }
        public bool IsActive { get; set; }
        public int? HomeId { get; set; }
    }

}
