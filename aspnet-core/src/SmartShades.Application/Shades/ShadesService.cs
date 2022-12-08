using Abp.Application.Services;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.ObjectMapping;
using SmartShades.Homes.Dto;
using SmartShades.Shades.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShades.Shades
{
    public class ShadesService : AsyncCrudAppService<Domains.Shades.Shade, ShadeDto, int>, IShadesService
    {
        #region Properties

        private readonly IObjectMapper _objectMapper;

        #endregion

        #region Constructor

        public ShadesService(IRepository<Domains.Shades.Shade, int> repository, IObjectMapper objectMapper) : base(repository)
        {
            _objectMapper = objectMapper;
        }

        #endregion

        #region Methods

        public List<ShadesTableDto> GetForTableData(ShadesResultFilter filter)
        {
            //filter is active
            var data = Repository.GetAll().Where(x => x.IsActive == filter.IsActive)
                .WhereIf(filter.RoomId.HasValue, x => x.RoomId == filter.RoomId.Value)
                .WhereIf(!filter.Keyword.IsNullOrWhiteSpace(), x => x.Name.ToLower().Contains(filter.Keyword.ToLower()));
            var returnData = data.Select(x => new ShadesTableDto(x)).ToList();

            return returnData;
        }


        #endregion

    }
}
