using Abp.AspNetCore.Mvc.ViewComponents;

namespace SMS.ALL.Web.Views
{
    public abstract class ALLViewComponent : AbpViewComponent
    {
        protected ALLViewComponent()
        {
            LocalizationSourceName = ALLConsts.LocalizationSourceName;
        }
    }
}
