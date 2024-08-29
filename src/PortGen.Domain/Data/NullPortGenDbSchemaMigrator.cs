using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PortGen.Data;

/* This is used if database provider does't define
 * IPortGenDbSchemaMigrator implementation.
 */
public class NullPortGenDbSchemaMigrator : IPortGenDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
