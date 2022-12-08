using Abp.Application.Services;
using SmartShades.Homes.Dto;
using SmartShades.Shades.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShades.Shades
{
    public interface IShadesService : IAsyncCrudAppService<ShadeDto, int>
    {
        /// <summary>
        /// Gets the Table data for Shades page
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>List of Shade Dtos</returns>
        List<ShadesTableDto> GetForTableData(ShadesResultFilter filter);
    }
}
