using InventoryManagementSystem.Samples;
using Xunit;

namespace InventoryManagementSystem.EntityFrameworkCore.Domains;

[Collection(InventoryManagementSystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<InventoryManagementSystemEntityFrameworkCoreTestModule>
{

}
