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
          //{
          //  ClickTimeFrame.Continous,
          //  new Services.Timer.ContinousTimeService(sp.GetRequiredService<AutoClickTimer>(),
          //  sp.GetRequiredService<IMouseActionService>())
          //},
          {
            ClickTimeFrame.Repeat,
            new Services.Timer.RepeatTimeService(
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
      //services.AddSingleton<IStatsService, StatsService>();
      #endregion

      services.AddSingleton<AutoClickTimer>((sp) =>
      {
        return new AutoClickTimer();
      });
            
      #region Validators
      services.AddScoped<IValidator<Setup>, Validators.SetupValidator>();
      services.AddScoped<IValidator<Time>, Validators.TimeIntervalValidator>();
      #endregion

      services.AddSingleton<ITimerPublisher, TimerPublisher>();
    }
  }
}
