using Volo.Abp.Modularity;

namespace PortGen;

public abstract class PortGenApplicationTestBase<TStartupModule> : PortGenTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
