using PortGen.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace PortGen.Web.Pages;

public abstract class PortGenPageModel : AbpPageModel
{
    protected PortGenPageModel()
    {
        LocalizationResourceType = typeof(PortGenResource);
    }
}
