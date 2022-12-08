using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SmartShades.Controllers;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using SmartShades.Authorization;
using SmartShades.Shades.Dto;
using System.Threading.Tasks;
using SmartShades.Web.Models.Schedules;
using SmartShades.Schedules.Dto;

namespace SmartShades.Web.Controllers
{
    [AbpMvcAuthorize]
    public class SchedulesController : SmartShadesControllerBase
    {

        #region Properties

        private readonly Schedules.ISchedulesService _schedulesService;

        #endregion

        #region Constructor

        public SchedulesController(Schedules.ISchedulesService schedulesService)
        {
            _schedulesService = schedulesService;
        }

        #endregion

        #region Views

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AbpAuthorize(PermissionNames.Pages_Schedules)]
        public async Task<PartialViewResult> Modal(int? id)
        {
            var model = id == null
                ? new CreateEditViewModel()
                : new CreateEditViewModel(await _schedulesService.GetAsync(new EntityDto((int)id)));

            return PartialView("_Form", model);
        }

        #endregion

        #region Table Data

        [HttpPost]
        public ActionResult GetTableData(SchedulesResultFilter filter)
        {
            var data = _schedulesService.GetForTableData(filter);

            return Ok(data);
        }

        #endregion

        #region Posts

        [HttpPost]
        [AbpAuthorize(PermissionNames.Pages_Schedules)]
        public async Task CreateUpdateAsync(CreateEditViewModel model)
        {
            var dtoModel = model.CreateDto();
            if (model.Id == 0)
            {
                await _schedulesService.CreateAsync(dtoModel);
            }
            else
            {
                await _schedulesService.UpdateAsync(dtoModel);
            }
        }

        [HttpPost]
        [AbpAuthorize(PermissionNames.Pages_Schedules)]
        public async Task DeleteAsync(int id)
        {
            await _schedulesService.DeleteAsync(new EntityDto<int> { Id = id });
        }

        #endregion
    }
}
