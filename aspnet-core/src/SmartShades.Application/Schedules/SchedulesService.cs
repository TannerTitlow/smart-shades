using Abp.Application.Services;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.ObjectMapping;
using SmartShades.Homes.Dto;
using SmartShades.Schedules.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShades.Schedules
{
    public class SchedulesService : AsyncCrudAppService<Domains.Schedules.Schedule, ScheduleDto, int>, ISchedulesService
    {
        #region Properties

        private readonly IObjectMapper _objectMapper;

        #endregion

        #region Constructor

        public SchedulesService(IRepository<Domains.Schedules.Schedule, int> repository, IObjectMapper objectMapper) : base(repository)
        {
            _objectMapper = objectMapper;
        }

        #endregion

        #region Methods

        public List<SchedulesTableDto> GetForTableData(SchedulesResultFilter filter)
        {
            //filter is active
            var data = Repository.GetAll().Where(x => x.IsActive == filter.IsActive)
                .WhereIf(filter.HomeId.HasValue, x => x.HomeId == filter.HomeId.Value)
                .WhereIf(!filter.Keyword.IsNullOrWhiteSpace(), x => x.Name.ToLower().Contains(filter.Keyword.ToLower()));
            var returnData = data.Select(x => new SchedulesTableDto(x)).ToList();

            return returnData;
        }


        #endregion

    }
}
