using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace PortGen.Pages;

[Collection(PortGenTestConsts.CollectionDefinitionName)]
public class Index_Tests : PortGenWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
