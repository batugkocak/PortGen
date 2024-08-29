using Volo.Abp.Modularity;

namespace PortGen;

[DependsOn(
    typeof(PortGenDomainModule),
    typeof(PortGenTestBaseModule)
)]
public class PortGenDomainTestModule : AbpModule
{

}
