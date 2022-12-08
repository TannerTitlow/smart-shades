using Abp.Application.Services;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.ObjectMapping;
using SmartShades.Homes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShades.Homes
{
    public class HomesService : AsyncCrudAppService<Domains.Homes.Home, HomeDto, int>, IHomesService
    {
        #region Properties

        private readonly IObjectMapper _objectMapper;

        #endregion

        #region Constructor

        public HomesService(IRepository<Domains.Homes.Home, int> repository, IObjectMapper objectMapper) : base(repository)
        {
            _objectMapper = objectMapper;
        }

        #endregion

        #region Methods

        public List<HomesTableDto> GetForTableData(HomesResultFilter filter)
        {
            //filter is active
            var data = Repository.GetAll().Where(x => x.IsActive == filter.IsActive && x.UserId == filter.UserId)
                .WhereIf(!filter.Keyword.IsNullOrWhiteSpace(), x => x.Name.ToLower().Contains(filter.Keyword.ToLower()));
            var returnData = data.Select(x => new HomesTableDto(x)).ToList();

            return returnData;
        }


        #endregion
    }
}
