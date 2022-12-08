using Abp.Application.Services;
using SmartShades.Homes.Dto;
using SmartShades.Schedules.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShades.Schedules
{
    public interface ISchedulesService : IAsyncCrudAppService<ScheduleDto, int>
    {
        /// <summary>
        /// Gets the Table data for Schedules page
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>List of Schedule Dtos</returns>
        List<SchedulesTableDto> GetForTableData(SchedulesResultFilter filter);
    }
}
