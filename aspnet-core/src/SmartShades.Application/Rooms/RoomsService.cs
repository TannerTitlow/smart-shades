using Abp.Application.Services;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.ObjectMapping;
using SmartShades.Rooms.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShades.Rooms
{
    public class RoomsService : AsyncCrudAppService<Domains.Rooms.Room, RoomDto, int>, IRoomsService
    {
        #region Properties

        private readonly IObjectMapper _objectMapper;

        #endregion

        #region Constructor

        public RoomsService(IRepository<Domains.Rooms.Room, int> repository, IObjectMapper objectMapper) : base(repository)
        {
            _objectMapper = objectMapper;
        }

        #endregion

        #region Methods

        public List<RoomsTableDto> GetForTableData(RoomsResultFilter filter)
        {
            //filter is active
            var data = Repository.GetAll().Where(x => x.IsActive == filter.IsActive)
                .WhereIf(filter.HomeId.HasValue, x => x.HomeId == filter.HomeId.Value)
                .WhereIf(!filter.Keyword.IsNullOrWhiteSpace(), x => x.Name.ToLower().Contains(filter.Keyword.ToLower())
                || x.RoomType.GetEnumDisplayName().ToLower().Contains(filter.Keyword.ToLower()));
            var returnData = data.Select(x => new RoomsTableDto(x)).ToList();

            return returnData;
        }


        #endregion

    }
}
