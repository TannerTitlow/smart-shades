using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SmartShades.Controllers;
using Abp.Authorization;
using SmartShades.Authorization;
using System.Threading.Tasks;
using SmartShades.Web.Models.Rooms;
using Abp.Application.Services.Dto;
using SmartShades.Rooms.Dto;

namespace SmartShades.Web.Controllers
{
    [AbpMvcAuthorize]
    public class RoomsController : SmartShadesControllerBase
    {

        #region Properties

        private readonly Rooms.IRoomsService _roomsService;

        #endregion

        #region Constructor

        public RoomsController(Rooms.IRoomsService roomsService)
        {
            _roomsService = roomsService;
        }

        #endregion

        #region Views

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AbpAuthorize(PermissionNames.Pages_Rooms)]
        public async Task<PartialViewResult> Modal(int? id)
        {
            var model = id == null
                ? new CreateEditViewModel()
                : new CreateEditViewModel(await _roomsService.GetAsync(new EntityDto((int)id)));

            return PartialView("_Form", model);
        }

        #endregion

        #region Table Data

        [HttpPost]
        public ActionResult GetTableData(RoomsResultFilter filter)
        {
            var data = _roomsService.GetForTableData(filter);

            return Ok(data);
        }

        #endregion

        #region Posts

        [HttpPost]
        [AbpAuthorize(PermissionNames.Pages_Rooms)]
        public async Task CreateUpdateAsync(CreateEditViewModel model)
        {
            var dtoModel = model.CreateDto();
            if (model.Id == 0)
            {
                await _roomsService.CreateAsync(dtoModel);
            }
            else
            {
                await _roomsService.UpdateAsync(dtoModel);
            }
        }

        [HttpPost]
        [AbpAuthorize(PermissionNames.Pages_Rooms)]
        public async Task DeleteAsync(int id)
        {
            await _roomsService.DeleteAsync(new EntityDto<int> { Id = id });
        }

        #endregion
    }
}
