using PortGen.Samples;
using Xunit;

namespace PortGen.EntityFrameworkCore.Applications;

[Collection(PortGenTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<PortGenEntityFrameworkCoreTestModule>
{

}
