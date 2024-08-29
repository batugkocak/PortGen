using Volo.Abp.Modularity;

namespace PortGen;

/* Inherit from this class for your domain layer tests. */
public abstract class PortGenDomainTestBase<TStartupModule> : PortGenTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
