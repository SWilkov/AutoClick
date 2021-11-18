using AC.Framework.Models;
using AC.Utils.Interfaces;
using AutoClick.Commands;
using AutoClick.Interfaces;
using AutoClick.Models;
using MouseSimulator.Interfaces;

namespace AutoClick.Services.Timer
{
  public class RepeatTimeService : ITimeService
  {
    private readonly AutoClickTimer _timer;
    private readonly ICommandHandler<TimerIntervalCommand> _intervalHandler;
    private readonly IMouseActionService _mouseActionService;

    public RepeatTimeService(AutoClickTimer timer,
      ICommandHandler<TimerIntervalCommand> intervalHandler,
      IMouseActionService mouseActionService)
    {
      _timer = timer;
      _intervalHandler = intervalHandler;
      _mouseActionService = mouseActionService;
    }

    public void Run(ClickTimeFrame timeFrame, ClickerConfiguration config)
    {
      if (config == null) throw new ArgumentNullException(nameof(config));
      if (timeFrame != ClickTimeFrame.Repeat) throw new ArgumentException($"Incorrect time frame detected: Expected Continous received {timeFrame.ToString()}");

      if (config.RepeatsFor < default(int)) throw new ArgumentException($"Setup indicates incorrect setup");
      if (_timer.IntervalTimer.Enabled)
        _timer.IntervalTimer.Stop();

      _timer.IntervalTimer.Interval = config.Interval;
      int count = 0;
      _timer.IntervalTimer.Tick += (sender, args) =>
      { 

        if (count == config.RepeatsFor)
          _timer.IntervalTimer.Stop();

        //Left mouse button click
        _mouseActionService.LeftMouseButtonDown();
        _mouseActionService.LeftMouseButtonUp();

        count++;
      };

      _timer.IntervalTimer.Start();
    }
  }
}
