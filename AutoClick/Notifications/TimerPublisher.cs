using AC.Utils.Models;
using AutoClick.Interfaces;

namespace AutoClick.Notifications
{
  public class TimerPublisher : ITimerPublisher
  {

    public event EventHandler<TimerEventArgs> TimerStartedEvent;
    public event EventHandler<TimerEventArgs> TimerEndedEvent;
    public event EventHandler<TimerEventArgs> TimerTickEvent;

    public void TimerStarted() => OnTimerStarted(new TimerEventArgs());
    public void TimerEnded() => OnTimerEnded(new TimerEventArgs());
    public void TimerTick() => OnTimerTick(new TimerEventArgs());
   
    protected virtual void OnTimerStarted(TimerEventArgs e)
    {
      var timerStartedEvent = TimerStartedEvent;

      if (timerStartedEvent != null)
      {

        timerStartedEvent(this, e);
      }
    }

    protected virtual void OnTimerEnded(TimerEventArgs e)
    {
      var timerEndedEvent = TimerEndedEvent;

      if (timerEndedEvent != null)
      {

        timerEndedEvent(this, e);
      }
    }

    protected virtual void OnTimerTick(TimerEventArgs e)
    {
      var timerTickEvent = TimerTickEvent;
      if (timerTickEvent != null)
        timerTickEvent(this, e);
    }
  }
}
