using AC.Framework.Models;
using AC.Utils.Interfaces;
using AutoClick.Commands;
using AutoClick.Interfaces;
using AutoClick.Models;
using AutoClick.Notifications;
using MouseSimulator.Interfaces;

namespace AutoClick.Services.Timer
{
  public class RepeatTimeService : ITimeService
  {
    //private readonly AutoClickTimer _timer;
    private System.Windows.Forms.Timer _intervalTimer;
    private readonly ICommandHandler<TimerIntervalCommand> _intervalHandler;
    private readonly IMouseActionService _mouseActionService;
    private readonly ITimerPublisher _timerPublisher;
    private int count = 0;

    //private readonly IStatsService _statsService;

    public RepeatTimeService(//AutoClickTimer timer,
      ICommandHandler<TimerIntervalCommand> intervalHandler,
      IMouseActionService mouseActionService,
      ITimerPublisher timerPublisher)
    {
      //_timer = timer;
      _intervalTimer = new System.Windows.Forms.Timer();
      _intervalHandler = intervalHandler;
      _mouseActionService = mouseActionService;
      _timerPublisher = timerPublisher;

      _intervalTimer.Tick += (sender, args) =>
      {

        if (count >= ClickerConfiguration.RepeatsFor)
        {
          _intervalTimer.Stop();
          _timerPublisher.TimerEnded();
          count = 0;
          Dispose();
        }
        else
        {

          //Left mouse button click
          _mouseActionService.LeftMouseButtonDown();
          _mouseActionService.LeftMouseButtonUp();
          //_statsService.AddToClicks();
          ClickStats.Instance.Add();
          count++;
        }
      };
    }

    public void Run(ClickTimeFrame timeFrame, int interval, int repeatsFor)
    {
      //if (config == null) throw new ArgumentNullException(nameof(config));
      if (timeFrame != ClickTimeFrame.Repeat) throw new ArgumentException($"Incorrect time frame detected: Expected Continous received {timeFrame.ToString()}");

      if (repeatsFor < default(int)) throw new ArgumentException($"Setup indicates incorrect setup");
      if (_intervalTimer.Enabled)
        _intervalTimer.Stop();

      _intervalTimer.Interval = ClickerConfiguration.Interval;      
      _intervalTimer.Start();
    }

    public void Dispose()
    {
      if (_intervalTimer != null)
      {
        _intervalTimer.Tick -= (sender, args) => { };
        _intervalTimer.Dispose();
      }
    }
  }

  
}
