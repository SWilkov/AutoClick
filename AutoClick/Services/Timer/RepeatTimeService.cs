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
    private readonly ICommandHandler<TimerIntervalCommand> _intervalHandler;
    private readonly ICommandHandler<StopAutoClickCommand> _stopAutoClickHandler;
    private readonly IMouseActionService _mouseActionService;

    private int count = 0;


    public RepeatTimeService(
      ICommandHandler<TimerIntervalCommand> intervalHandler,
      ICommandHandler<StopAutoClickCommand> stopAutoClickHandler,
      IMouseActionService mouseActionService)
    {
      _intervalHandler = intervalHandler;
      _stopAutoClickHandler = stopAutoClickHandler;
      _mouseActionService = mouseActionService;

      AutoClickTimer.Instance.IntervalTimer.Tick += (sender, args) =>
      {
        if (count >= ClickerConfiguration.RepeatsFor)
        {
          _stopAutoClickHandler.Handle(new StopAutoClickCommand());
          count = 0;
        }
        else
        {
          //Left mouse button click
          _mouseActionService.LeftMouseButtonDown();
          _mouseActionService.LeftMouseButtonUp();
          ClickStats.Instance.Add();
          count++;
        }
      };
    }

    public void Run(ClickTimeFrame timeFrame)
    {
      if (timeFrame != ClickTimeFrame.Repeat) throw new ArgumentException($"Incorrect time frame detected: Expected Continous received {timeFrame.ToString()}");
      if (ClickerConfiguration.RepeatsFor < default(int)) throw new ArgumentException($"Setup indicates incorrect setup");

      if (AutoClickTimer.Instance.IntervalTimer.Enabled)
        _stopAutoClickHandler.Handle(new StopAutoClickCommand());

      AutoClickTimer.Instance.IntervalTimer.Interval = ClickerConfiguration.Interval;
      AutoClickTimer.Instance.IntervalTimer.Start();
    }
  }

  
}
