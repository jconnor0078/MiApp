using Abp.Web.Mvc.Views;

namespace MiApp.Web.Views
{
    public abstract class MiAppWebViewPageBase : MiAppWebViewPageBase<dynamic>
    {

    }

    public abstract class MiAppWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MiAppWebViewPageBase()
        {
            LocalizationSourceName = MiAppConsts.LocalizationSourceName;
        }
    }
}