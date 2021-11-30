
namespace AutoClick.Notifications
{
  public interface ITimerPublisher
  {
    event EventHandler<TimerEventArgs> TimerEndedEvent;
    event EventHandler<TimerEventArgs> TimerStartedEvent;

    void TimerEnded();
    void TimerStarted();
  }
}