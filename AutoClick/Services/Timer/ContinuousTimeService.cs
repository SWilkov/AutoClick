using AC.Framework.Models;
using AC.Utils.Interfaces;
using AutoClick.Commands;
using AutoClick.Interfaces;
using AutoClick.Models;
using AutoClick.Notifications;
using MouseSimulator.Interfaces;

namespace AutoClick.Services.Timer
{
  public class ContinuousTimeService : ITimeService
  {
    private System.Windows.Forms.Timer _timer;
    private readonly ICommandHandler<StopAutoClickCommand> _stopAutoClickHandler;
    private readonly IMouseActionService _mouseActionService;
    private readonly ITimerPublisher _timerPublisher;
    //private readonly IStatsService _statsService;
    public ContinuousTimeService(
      IMouseActionService mouseActionService,
      ICommandHandler<StopAutoClickCommand> stopAutoClickHandler,
      ITimerPublisher timerPublisher)
    {
      _timer = new System.Windows.Forms.Timer();
      _stopAutoClickHandler = stopAutoClickHandler;
      _mouseActionService = mouseActionService;
      _timerPublisher = timerPublisher;

      _timer.Tick += (s, e) =>
      {
        _mouseActionService.LeftMouseButtonDown();
        _mouseActionService.LeftMouseButtonUp();

        ClickStats.Instance.Add();
      };

      _timerPublisher.TimerEndedEvent += (s, e) =>
      {
        if (_timer.Enabled)
        {
          _timer.Stop();
          Dispose();
        }
      };
    }

    public bool Enabled => _timer != null && _timer.Enabled;

    public void Run(ClickTimeFrame timeFrame)
    {
      if (timeFrame != ClickTimeFrame.Continuous) throw new ArgumentException($"Incorrect time frame detected: Expected Continous received {timeFrame.ToString()}");
      if (AutoClickTimer.Instance.IntervalTimer.Enabled)
        _stopAutoClickHandler.Handle(new StopAutoClickCommand());

      _timer.Interval
        = ClickerConfiguration.Interval;
      _timer.Start();
    }

    public void Dispose()
    {
      if (_timer != null)
      {
        _timer.Tick -= (sender, args) => { };
        _timer.Dispose();
      }
    }
  }
}
