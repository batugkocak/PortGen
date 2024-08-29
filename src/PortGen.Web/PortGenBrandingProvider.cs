using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using PortGen.Localization;

namespace PortGen.Web;

[Dependency(ReplaceServices = true)]
public class PortGenBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<PortGenResource> _localizer;

    public PortGenBrandingProvider(IStringLocalizer<PortGenResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
