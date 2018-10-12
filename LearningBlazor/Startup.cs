using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LearningBlazor
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddTransient<BrowserState.StateManager, BrowserState.StateManager>();
    }

    public void Configure(IBlazorApplicationBuilder app)
    {
      app.AddComponent<App>("app");
    }
  }
}
