using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace SmartShades.Web.Views
{
    public abstract class SmartShadesRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected SmartShadesRazorPage()
        {
            LocalizationSourceName = SmartShadesConsts.LocalizationSourceName;
        }
    }
}
