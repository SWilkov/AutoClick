using AC.Utils.Models;

namespace AutoClick.Notifications
{
  public class TimerEventArgs : EventArgs
  {
    public TimerEventArgs()
    {

    }
  }
  public class IntervalChangedEventArgs : EventArgs
  {
    public ValidationResult Result { get; private set; }
    public IntervalChangedEventArgs(ValidationResult result)
    {
      this.Result = result;
    }
  }

  public class TimerPublisher : ITimerPublisher
  {

    public event EventHandler<TimerEventArgs> TimerStartedEvent;
    public event EventHandler<TimerEventArgs> TimerEndedEvent;

    public void TimerStarted()
    {
      OnTimerStarted(new TimerEventArgs());
    }

    public void TimerEnded()
    {
      OnTimerEnded(new TimerEventArgs());
    }

   
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

    
  }
}
