using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace InventoryManagementSystem.Pages;

[Collection(InventoryManagementSystemTestConsts.CollectionDefinitionName)]
public class Index_Tests : InventoryManagementSystemWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
