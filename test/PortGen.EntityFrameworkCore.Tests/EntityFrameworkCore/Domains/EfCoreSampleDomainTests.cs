using PortGen.Samples;
using Xunit;

namespace PortGen.EntityFrameworkCore.Domains;

[Collection(PortGenTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<PortGenEntityFrameworkCoreTestModule>
{

}
