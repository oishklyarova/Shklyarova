using System.Reflection;
using Abp.Modules;

namespace Shklyarova
{
    [DependsOn(typeof(ShklyarovaCoreModule))]
    public class ShklyarovaApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
