using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SmartShades.Controllers;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using SmartShades.Authorization;
using SmartShades.Shades.Dto;
using System.Threading.Tasks;
using SmartShades.Web.Models.Shades;

namespace SmartShades.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ShadesController : SmartShadesControllerBase
    {

        #region Properties

        private readonly Shades.IShadesService _shadesService;

        #endregion

        #region Constructor

        public ShadesController(Shades.IShadesService shadesService)
        {
            _shadesService = shadesService;
        }

        #endregion

        #region Views

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AbpAuthorize(PermissionNames.Pages_Shades)]
        public async Task<PartialViewResult> Modal(int? id)
        {
            var model = id == null
                ? new CreateEditViewModel()
                : new CreateEditViewModel(await _shadesService.GetAsync(new EntityDto((int)id)));

            return PartialView("_Form", model);
        }

        #endregion

        #region Table Data

        [HttpPost]
        public ActionResult GetTableData(ShadesResultFilter filter)
        {
            var data = _shadesService.GetForTableData(filter);

            return Ok(data);
        }

        #endregion

        #region Posts

        [HttpPost]
        [AbpAuthorize(PermissionNames.Pages_Shades)]
        public async Task CreateUpdateAsync(CreateEditViewModel model)
        {
            var dtoModel = model.CreateDto();
            if (model.Id == 0)
            {
                await _shadesService.CreateAsync(dtoModel);
            }
            else
            {
                await _shadesService.UpdateAsync(dtoModel);
            }
        }

        [HttpPost]
        [AbpAuthorize(PermissionNames.Pages_Shades)]
        public async Task DeleteAsync(int id)
        {
            await _shadesService.DeleteAsync(new EntityDto<int> { Id = id });
        }

        #endregion
    }
}
