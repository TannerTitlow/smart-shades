using Abp.Application.Services;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.ObjectMapping;
using SmartShades.Homes.Dto;
using SmartShades.Blocks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartShades.Domains.Blocks;

namespace SmartShades.Blocks
{
    public class BlocksService : AsyncCrudAppService<Block, BlockDto, int>, IBlocksService
    {
        private readonly IObjectMapper _objectMapper;

        public BlocksService(IRepository<Domains.Blocks.Block, int> repository, IObjectMapper objectMapper) : base(repository)
        {
            _objectMapper = objectMapper;
        }

        public List<BlocksTableDto> GetForTableData(BlocksResultFilter filter)
        {
            //filter is active
            var data = Repository.GetAll().Where(x => x.IsActive == filter.IsActive)
                .WhereIf(!filter.Keyword.IsNullOrWhiteSpace(), x => x.Name.ToLower().Contains(filter.Keyword.ToLower()));
            var returnData = data.Select(x => new BlocksTableDto(x)).ToList();

            return returnData;
        }
    }
}
