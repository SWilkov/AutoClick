using AC.Framework.Models;
using AC.Utils.Interfaces;
using AutoClick.Commands;
using AutoClick.Interfaces;
using AutoClick.Models;
using MouseSimulator.Interfaces;

namespace AutoClick.Services.Timer
{
  public class TimePeriodTimeService : ITimeService
  {
    private readonly AutoClickTimer _timer;
    private readonly ICommandHandler<TimerIntervalCommand> _intervalHandler;
    private readonly IMouseActionService _mouseActionService;
    private readonly IValidator<Time> _timeValidator;

    public TimePeriodTimeService(AutoClickTimer timer,
      ICommandHandler<TimerIntervalCommand> intervalHandler,
      IMouseActionService mouseActionService,
      IValidator<Time> timeValidator)
    {
      _timer = timer;
      _intervalHandler = intervalHandler;
      _mouseActionService = mouseActionService;
      _timeValidator = timeValidator;
    }

    public void Run(ClickTimeFrame timeFrame, ClickerConfiguration config)
    {
      if (config == null) throw new ArgumentNullException(nameof(config));
      if (timeFrame != ClickTimeFrame.TimePeriod) throw new ArgumentException($"Incorrect time frame detected: Expected TimePeriod received {timeFrame.ToString()}");

      var validation = _timeValidator.Validate(config.RunningTime);
      if (validation.Result == AC.Utils.Models.ValidationResult.Invalid)
      {
        //TODO log somewhere
        return;
      }
            
      if (_timer.IntervalTimer.Enabled)
        _timer.IntervalTimer.Stop();
      if (_timer.TimePeriodTimer.Enabled)
        _timer.TimePeriodTimer.Stop();

      _timer.IntervalTimer.Interval = config.Interval;
      _timer.IntervalTimer.Tick += (sender, args) =>
      {
        _mouseActionService.LeftMouseButtonDown();
        _mouseActionService.LeftMouseButtonUp();
      };

      _timer.TimePeriodTimer.Tick += (sender, args) =>
      {
        _timer.IntervalTimer.Stop();
      };

      _timer.IntervalTimer.Start();
      _timer.TimePeriodTimer.Start();
    }
  }
}
