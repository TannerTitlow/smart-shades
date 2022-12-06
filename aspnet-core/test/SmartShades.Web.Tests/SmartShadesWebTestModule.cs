using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SmartShades.EntityFrameworkCore;
using SmartShades.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace SmartShades.Web.Tests
{
    [DependsOn(
        typeof(SmartShadesWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SmartShadesWebTestModule : AbpModule
    {
        public SmartShadesWebTestModule(SmartShadesEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SmartShadesWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SmartShadesWebMvcModule).Assembly);
        }
    }
}