using Abp.Web.Mvc.Controllers;

namespace Shklyarova.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class ShklyarovaControllerBase : AbpController
    {
        protected ShklyarovaControllerBase()
        {
            LocalizationSourceName = ShklyarovaConsts.LocalizationSourceName;
        }
    }
}