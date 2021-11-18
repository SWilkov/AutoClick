using AC.Utils.Interfaces;
using AutoClick.Models;

namespace AutoClick.Commands
{
  public class StopAutoClickHandler : ICommandHandler<StopAutoClickCommand>
  {
    private readonly AutoClickTimer _timer;
    public StopAutoClickHandler(AutoClickTimer timer)
    {
      _timer = timer;
    }

    public void Handle(StopAutoClickCommand command)
    {
      if (command == null) throw new ArgumentNullException(nameof(command));

      if (_timer == null || _timer.IntervalTimer == null || !_timer.IntervalTimer.Enabled)
      {
        command.Message = "Timer is null or not running!";
        return;
      }

      _timer.IntervalTimer.Stop();
      command.StoppedAt = DateTime.Now;
    }
  }
}
