using Xunit;

namespace PortGen.EntityFrameworkCore;

[CollectionDefinition(PortGenTestConsts.CollectionDefinitionName)]
public class PortGenEntityFrameworkCoreCollection : ICollectionFixture<PortGenEntityFrameworkCoreFixture>
{

}
