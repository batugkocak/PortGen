using PortGen.Localization;
using Volo.Abp.Application.Services;

namespace PortGen;

/* Inherit your application services from this class.
 */
public abstract class PortGenAppService : ApplicationService
{
    protected PortGenAppService()
    {
        LocalizationResource = typeof(PortGenResource);
    }
}
