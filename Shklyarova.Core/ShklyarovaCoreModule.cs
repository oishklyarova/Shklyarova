using System.Reflection;
using Abp.Modules;

namespace Shklyarova
{
    public class ShklyarovaCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
