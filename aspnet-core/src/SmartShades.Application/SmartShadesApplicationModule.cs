using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SmartShades.Authorization;

namespace SmartShades
{
    [DependsOn(
        typeof(SmartShadesCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SmartShadesApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SmartShadesAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SmartShadesApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
