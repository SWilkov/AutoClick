using AC.Framework.Models;
using AC.Utils.Interfaces;
using AutoClick.Commands;
using AutoClick.Interfaces;
using AutoClick.Models;
using AutoClick.Notifications;
using MouseSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClick.Services.Timer
{
  public class RepeaterTimeService : ITimeService
  {
    private System.Windows.Forms.Timer _intervalTimer;
    private readonly ICommandHandler<TimerIntervalCommand> _intervalHandler;
    private readonly IMouseActionService _mouseActionService;
    private readonly ITimerPublisher _timerPublisher;
    private int count = 0;

    //private readonly IStatsService _statsService;

    public RepeaterTimeService(//AutoClickTimer timer,
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

          _timerPublisher.TimerTick();
          //_statsService.AddToClicks();
          ClickStats.Instance.Add();
          count++;
        }
      };

      _timerPublisher.TimerEndedEvent += (s, e) =>
      {
        if (_intervalTimer.Enabled)
        {
          _intervalTimer.Stop();
          Dispose();
        }
      };
    }

    public bool Enabled => _intervalTimer != null && _intervalTimer.Enabled;

    public void Run(ClickTimeFrame timeFrame)
    {
      if (ClickerConfiguration.RepeatsFor < default(int) && timeFrame == ClickTimeFrame.Repeat)
        throw new ArgumentException($"Setup indicates incorrect setup");
      if (_intervalTimer.Enabled)
        _intervalTimer.Stop();

      _intervalTimer.Interval = ClickerConfiguration.Interval;
      _intervalTimer.Start();
      _timerPublisher.TimerStarted();
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
