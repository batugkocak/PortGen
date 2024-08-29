using Volo.Abp.Modularity;

namespace PortGen;

[DependsOn(
    typeof(PortGenApplicationModule),
    typeof(PortGenDomainTestModule)
)]
public class PortGenApplicationTestModule : AbpModule
{

}
