
using AutoClick.Notifications;

namespace AutoClick.Interfaces
{
  /// <summary>
  /// Publisher class to help with System.Windows.Forms.Timer actions
  /// </summary>
  public interface ITimerPublisher
  {
    /// <summary>
    /// The timer has completed event
    /// </summary>
    event EventHandler<TimerEventArgs> TimerEndedEvent;
    /// <summary>
    /// Timer has started event
    /// </summary>
    event EventHandler<TimerEventArgs> TimerStartedEvent;
    /// <summary>
    /// Timer has ticked event
    /// </summary>
    event EventHandler<TimerEventArgs > TimerTickEvent;
    void TimerEnded();
    void TimerStarted();
    void TimerTick();
  }
}