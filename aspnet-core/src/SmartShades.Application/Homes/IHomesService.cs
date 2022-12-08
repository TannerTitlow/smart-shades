using Abp.Application.Services;
using SmartShades.Homes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShades.Homes
{
    public interface IHomesService : IAsyncCrudAppService<HomeDto, int>
    {
        /// <summary>
        /// Gets the Table data for Homes page
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>List of Home Dtos</returns>
        List<HomesTableDto> GetForTableData(HomesResultFilter filter);

    }
}
