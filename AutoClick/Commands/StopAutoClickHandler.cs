using AC.Utils.Interfaces;
using AutoClick.Interfaces;
using AutoClick.Models;
using AutoClick.Notifications;

namespace AutoClick.Commands
{
  public class StopAutoClickHandler : ICommandHandler<StopAutoClickCommand>
  {
    private readonly ITimerPublisher _timerPublisher;

    public StopAutoClickHandler(ITimerPublisher timerPublisher)
    {
      _timerPublisher = timerPublisher;
    }

    public void Handle(StopAutoClickCommand command)
    {
      if (command == null) throw new ArgumentNullException(nameof(command));

      if (AutoClickTimer.Instance == null || AutoClickTimer.Instance.IntervalTimer == null || AutoClickTimer.Instance.IntervalTimer.Enabled)
      {
        command.Message = "Timer is null or not running!";
        return;
      }

      AutoClickTimer.Instance.IntervalTimer.Stop();
      AutoClickTimer.Instance.DisposeEvents();
      command.StoppedAt = DateTime.Now;

      _timerPublisher.TimerEnded();
    }
  }
}
