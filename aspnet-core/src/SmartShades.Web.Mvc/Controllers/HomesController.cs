using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SmartShades.Controllers;
using Abp.Authorization;
using SmartShades.Authorization;
using System.Threading.Tasks;
using SmartShades.Web.Models.Homes;
using Abp.Application.Services.Dto;
using SmartShades.Homes.Dto;
using SmartShades.Web.Models.Home;
using SmartShades.Web.Models.Rooms;
using System.Collections.Generic;
using SmartShades.Rooms.Dto;
using CreateEditViewModel = SmartShades.Web.Models.Homes.CreateEditViewModel;

namespace SmartShades.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomesController : SmartShadesControllerBase
    {
        #region Properties

        private readonly Homes.IHomesService _homesService;

        #endregion

        #region Constructor

        public HomesController(Homes.IHomesService homesService)
        {
            _homesService = homesService;
        }

        #endregion

        #region Views

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AbpAuthorize(PermissionNames.Pages_Homes)]
        public async Task<PartialViewResult> Modal(int? id)
        {
            var model = id == null
                ? new CreateEditViewModel()
                : new CreateEditViewModel(await _homesService.GetAsync(new EntityDto((int)id)));

            return PartialView("_Form", model);
        }

        #endregion

        #region Table Data

        [HttpPost]
        public ActionResult GetTableData(HomesResultFilter filter)
        {
            var data = _homesService.GetForTableData(filter);

            return Ok(data);
        }

        #endregion

        #region Posts

        [HttpPost]
        [AbpAuthorize(PermissionNames.Pages_Homes)]
        public async Task CreateUpdateAsync(CreateEditViewModel model)
        {
            var dtoModel = model.CreateDto();
            if (model.Id == 0)
            {
                await _homesService.CreateAsync(dtoModel);
            }
            else
            {
                await _homesService.UpdateAsync(dtoModel);
            }
        }

        [HttpPost]
        [AbpAuthorize(PermissionNames.Pages_Homes)]
        public async Task DeleteAsync(int id)
        {
            await _homesService.DeleteAsync(new EntityDto<int> { Id = id });
        }

        #endregion

    }
}
