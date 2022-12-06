using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SmartShades.Controllers
{
    public abstract class SmartShadesControllerBase: AbpController
    {
        protected SmartShadesControllerBase()
        {
            LocalizationSourceName = SmartShadesConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
