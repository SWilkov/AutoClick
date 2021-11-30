using AC.Framework.Models;
using AC.Utils.Interfaces;
using AutoClick.Commands;
using AutoClick.Interfaces;
using AutoClick.Models;
using AutoClick.Services;
using Microsoft.Extensions.DependencyInjection;
using MouseSimulator;
using MouseSimulator.Interfaces;
using MediatR;
using System.Reflection;
using AutoClick.Notifications;
using AutoClick.Services.Timer;

namespace AutoClick.Extensions
{
  public static class ServiceCollectionExtensions
  {
    public static void AddAutoClickServices(this IServiceCollection services)
    {
      #region Commands
      services.AddScoped<ICommandHandler<StartAutoClickCommand>, Commands.StartAutoClickHandler>();
      services.AddScoped<ICommandHandler<StopAutoClickCommand>, Commands.StopAutoClickHandler>();
      services.AddScoped<ICommandHandler<TimerIntervalCommand>, Commands.TimerIntervalHandler>();
      #endregion

      #region Composites
      services.AddSingleton<IMousePositionService>((sp) =>
      {
        var dict = new Dictionary<bool, IMousePositionService>
        {
          {
            true,
            new Services.SetCurrentMousePositionService()
          },
          {
            false,
            new Services.SetInputMousePositionService()
          }
        };

        return new Composites.MousePositionComposite(dict);
      });
      services.AddSingleton<ITimeService>(sp =>
      {
        var dict = new Dictionary<ClickTimeFrame, ITimeService>
        {
          {
            ClickTimeFrame.Continuous,
            new Services.Timer.ContinuousTimeService(
              sp.GetRequiredService<IMouseActionService>(),
              sp.GetRequiredService<ICommandHandler<StopAutoClickCommand>>(),
              sp.GetRequiredService<ITimerPublisher>())
          },
          {
            ClickTimeFrame.Repeat,
            new Services.Timer.TimeService(
              sp.GetRequiredService<ICommandHandler<TimerIntervalCommand>>(),              
              sp.GetRequiredService<IMouseActionService>(),
              sp.GetRequiredService<ITimerPublisher>())
          },
          //{
          //  ClickTimeFrame.TimePeriod,
          //  new Services.Timer.TimePeriodTimeService(sp.GetRequiredService<AutoClickTimer>(),
          //    sp.GetRequiredService<ICommandHandler<TimerIntervalCommand>>(),
          //    sp.GetRequiredService<IMouseActionService>(),
          //    sp.GetRequiredService<IValidator<Time>>())
          //}
        };

        return new Composites.TimeServiceComposite(dict);
      });

      #endregion

      #region Factories
      services.AddScoped<ITimeFrameFactory, Factories.TimeFrameFactory>();
      services.AddMediatR(Assembly.GetExecutingAssembly());
      #endregion

      #region Services
      services.AddSingleton<IMouseActionService, MouseActionService>();
      services.AddScoped<IUserSettingsService, UserSettingsService>();
      services.AddScoped<IHotKeyService, HotKeyService>();
      //services.AddSingleton<IStatsService, StatsService>();
      //services.AddScoped<ITimeService, TimeService>();
      #endregion      
            
      #region Validators
      services.AddScoped<IValidator<Setup>, Validators.SetupValidator>();
      services.AddScoped<IValidator<Time>, Validators.TimeIntervalValidator>();
      #endregion

      services.AddSingleton<ITimerPublisher, TimerPublisher>();
    }
  }
}
