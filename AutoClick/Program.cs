using AutoClick.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace AutoClick
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {      
      var services = new ServiceCollection();

      services.AddAutoClickServices();
      services.AddScoped<AutoClickForm>();

      using(ServiceProvider sp = services.BuildServiceProvider())
      {
        ApplicationConfiguration.Initialize();
        var form2 = sp.GetRequiredService<AutoClickForm>();
        Application.Run(form2);
      }
    }
  }
}