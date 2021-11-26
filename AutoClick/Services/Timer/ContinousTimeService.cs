using AC.Framework.Models;
using AC.Utils.Interfaces;
using AutoClick.Commands;
using AutoClick.Interfaces;
using AutoClick.Models;
using MouseSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClick.Services.Timer
{
  public class ContinousTimeService : ITimeService
  {
    private readonly AutoClickTimer _timer;
    private readonly IMouseActionService _mouseActionService;
    //private readonly IStatsService _statsService;
    public ContinousTimeService(AutoClickTimer timer,
      IMouseActionService mouseActionService)
    {
      _timer = timer;
      _mouseActionService = mouseActionService;
    }

    public void Run(ClickTimeFrame timeFrame)
    {
      if (config == null) throw new ArgumentNullException(nameof(config));
      if (timeFrame != ClickTimeFrame.Continous) throw new ArgumentException($"Incorrect time frame detected: Expected Continous received {timeFrame.ToString()}");
      if (_timer.IntervalTimer.Enabled)
        _timer.IntervalTimer.Stop();     

      _timer.IntervalTimer.Interval = config.Interval;
      _timer.IntervalTimer.Tick += (sender, args) =>
      {
        _mouseActionService.LeftMouseButtonDown();
        _mouseActionService.LeftMouseButtonUp();

        //_statsService.AddToClicks();
      };

      _timer.IntervalTimer.Start();
    }
  }
}
