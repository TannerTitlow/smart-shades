using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShades.Shades.Dto
{
    public class ShadesResultFilter
    {
        public ShadesResultFilter() { }

        public string Keyword { get; set; }
        public bool IsActive { get; set; }
        public int? RoomId { get; set; }
    }

}
