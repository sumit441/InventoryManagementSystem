using InventoryManagementSystem.Samples;
using Xunit;

namespace InventoryManagementSystem.EntityFrameworkCore.Applications;

[Collection(InventoryManagementSystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<InventoryManagementSystemEntityFrameworkCoreTestModule>
{

}
