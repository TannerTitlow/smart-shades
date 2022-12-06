using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SmartShades.Controllers;

namespace SmartShades.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SmartShadesControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
