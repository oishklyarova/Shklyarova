using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Shklyarova.EntityFramework;

namespace Shklyarova
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(ShklyarovaCoreModule))]
    public class ShklyarovaDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<ShklyarovaDbContext>(null);
        }
    }
}
