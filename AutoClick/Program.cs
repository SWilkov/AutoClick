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
      services.AddScoped<formAutoClick>();

      using(ServiceProvider sp = services.BuildServiceProvider())
      {
        ApplicationConfiguration.Initialize();
        var form2 = sp.GetRequiredService<formAutoClick>();
        Application.Run(form2);

      }
    }
  }
}