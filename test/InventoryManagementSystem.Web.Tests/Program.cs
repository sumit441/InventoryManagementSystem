using Microsoft.AspNetCore.Builder;
using InventoryManagementSystem;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("InventoryManagementSystem.Web.csproj"); 
await builder.RunAbpModuleAsync<InventoryManagementSystemWebTestModule>(applicationName: "InventoryManagementSystem.Web");

public partial class Program
{
}
