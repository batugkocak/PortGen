using PortGen.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PortGen.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PortGenController : AbpControllerBase
{
    protected PortGenController()
    {
        LocalizationResource = typeof(PortGenResource);
    }
}
