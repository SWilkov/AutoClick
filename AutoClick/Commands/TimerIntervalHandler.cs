using AC.Utils.Interfaces;

namespace AutoClick.Commands
{
  public class TimerIntervalHandler : ICommandHandler<TimerIntervalCommand>
  {
    public void Handle(TimerIntervalCommand command)
    {
      if (command == null) throw new ArgumentNullException(nameof(command));
      if (command.Setup == null) throw new ArgumentNullException(nameof(command.Setup));

      if (command.Setup.Interval.Milliseconds > default(int))
      {
        command.Interval = command.Setup.Interval.Milliseconds;
        return;
      }

      var hoursInMilliseconds = command.Setup?.Interval.Hours > 0 ? TimeSpan.FromHours(command.Setup.Interval.Hours).TotalMilliseconds : 0;
      var MinutesInMilliseconds = command.Setup?.Interval.Minutes > 0 ? TimeSpan.FromMinutes(command.Setup.Interval.Minutes).TotalMilliseconds : 0;
      var secondsInMilliseconds = command.Setup?.Interval.Seconds > 0 ? TimeSpan.FromSeconds(command.Setup.Interval.Seconds).TotalMilliseconds : 0;

      command.Interval = Convert.ToInt32(hoursInMilliseconds + MinutesInMilliseconds + secondsInMilliseconds);
    }
  }
}
