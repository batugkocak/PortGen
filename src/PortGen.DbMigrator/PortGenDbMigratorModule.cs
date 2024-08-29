using PortGen.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PortGen.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PortGenEntityFrameworkCoreModule),
    typeof(PortGenApplicationContractsModule)
)]
public class PortGenDbMigratorModule : AbpModule
{
}
