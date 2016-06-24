using Abp.Application.Services;

namespace Shklyarova
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ShklyarovaAppServiceBase : ApplicationService
    {
        protected ShklyarovaAppServiceBase()
        {
            LocalizationSourceName = ShklyarovaConsts.LocalizationSourceName;
        }
    }
}