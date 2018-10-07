using Abp.Web.Mvc.Views;

namespace Moon.FrameWork.Web.Views
{
    public abstract class FrameWorkWebViewPageBase : FrameWorkWebViewPageBase<dynamic>
    {

    }

    public abstract class FrameWorkWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected FrameWorkWebViewPageBase()
        {
            LocalizationSourceName = FrameWorkConsts.LocalizationSourceName;
        }
    }
}