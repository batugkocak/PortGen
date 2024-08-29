using System.Threading.Tasks;

namespace PortGen.Data;

public interface IPortGenDbSchemaMigrator
{
    Task MigrateAsync();
}
