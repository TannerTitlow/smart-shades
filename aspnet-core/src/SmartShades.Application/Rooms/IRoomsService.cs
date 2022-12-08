using Abp.Application.Services;
using SmartShades.Homes.Dto;
using SmartShades.Rooms.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShades.Rooms
{
    public interface IRoomsService : IAsyncCrudAppService<RoomDto, int>
    {
        /// <summary>
        /// Gets the Table data for Rooms page
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>List of Room Dtos</returns>
        List<RoomsTableDto> GetForTableData(RoomsResultFilter filter);
    }
}
