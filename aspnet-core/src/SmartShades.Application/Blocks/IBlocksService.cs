using Abp.Application.Services;
using SmartShades.Blocks.Dto;
using SmartShades.Homes.Dto;
using SmartShades.Shades.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShades.Blocks
{
    public interface IBlocksService : IAsyncCrudAppService<BlockDto, int>
    {
        /// <summary>
        /// Gets the Table data for Blocks page
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>List of Block Dtos</returns>
        List<BlocksTableDto> GetForTableData(BlocksResultFilter filter);

    }
}
