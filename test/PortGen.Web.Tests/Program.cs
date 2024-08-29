using Microsoft.AspNetCore.Builder;
using PortGen;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<PortGenWebTestModule>();

public partial class Program
{
}
