using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SmartShades.Controllers;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using SmartShades.Authorization;
using SmartShades.Web.Models.Blocks;
using SmartShades.Shades.Dto;
using System.Threading.Tasks;
using SmartShades.Blocks.Dto;

namespace SmartShades.Web.Controllers
{
    [AbpMvcAuthorize]
    public class BlocksController : SmartShadesControllerBase
    {

        #region Properties

        private readonly Blocks.IBlocksService _blocksService;

        #endregion

        #region Constructor

        public BlocksController(Blocks.IBlocksService blocksService)
        {
            _blocksService = blocksService;
        }

        #endregion

        #region Views

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AbpAuthorize(PermissionNames.Pages_Blocks)]
        public async Task<PartialViewResult> Modal(int? id)
        {
            var model = id == null
                ? new CreateEditViewModel()
                : new CreateEditViewModel(await _blocksService.GetAsync(new EntityDto((int)id)));

            return PartialView("_Form", model);
        }

        #endregion

        #region Table Data

        [HttpPost]
        public ActionResult GetTableData(BlocksResultFilter filter)
        {
            var data = _blocksService.GetForTableData(filter);

            return Ok(data);
        }

        #endregion

        #region Posts

        [HttpPost]
        [AbpAuthorize(PermissionNames.Pages_Blocks)]
        public async Task CreateUpdateAsync(CreateEditViewModel model)
        {
            var dtoModel = model.CreateDto();
            if (model.Id == 0)
            {
                await _blocksService.CreateAsync(dtoModel);
            }
            else
            {
                await _blocksService.UpdateAsync(dtoModel);
            }
        }

        [HttpPost]
        [AbpAuthorize(PermissionNames.Pages_Blocks)]
        public async Task DeleteAsync(int id)
        {
            await _blocksService.DeleteAsync(new EntityDto<int> { Id = id });
        }

        #endregion
    }
}
