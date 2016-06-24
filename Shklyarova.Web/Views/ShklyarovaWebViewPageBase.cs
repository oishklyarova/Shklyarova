using Abp.Web.Mvc.Views;

namespace Shklyarova.Web.Views
{
    public abstract class ShklyarovaWebViewPageBase : ShklyarovaWebViewPageBase<dynamic>
    {

    }

    public abstract class ShklyarovaWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ShklyarovaWebViewPageBase()
        {
            LocalizationSourceName = ShklyarovaConsts.LocalizationSourceName;
        }
    }
}