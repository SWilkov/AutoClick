
using AutoClick.Notifications;

namespace AutoClick.Interfaces
{
  public interface ITimerPublisher
  {
    event EventHandler<TimerEventArgs> TimerEndedEvent;
    event EventHandler<TimerEventArgs> TimerStartedEvent;
    event EventHandler<TimerEventArgs > TimerTickEvent;
    void TimerEnded();
    void TimerStarted();
    void TimerTick();
  }
}