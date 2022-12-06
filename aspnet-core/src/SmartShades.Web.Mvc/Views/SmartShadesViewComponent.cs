using Abp.AspNetCore.Mvc.ViewComponents;

namespace SmartShades.Web.Views
{
    public abstract class SmartShadesViewComponent : AbpViewComponent
    {
        protected SmartShadesViewComponent()
        {
            LocalizationSourceName = SmartShadesConsts.LocalizationSourceName;
        }
    }
}
