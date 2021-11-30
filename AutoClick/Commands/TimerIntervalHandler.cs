using AC.Utils.Interfaces;

namespace AutoClick.Commands
{
  public class TimerIntervalHandler : ICommandHandler<TimerIntervalCommand>
  {
    public void Handle(TimerIntervalCommand command)
    {
      if (command == null) throw new ArgumentNullException(nameof(command));
      if (command.Interval == null) throw new ArgumentNullException(nameof(command.Interval));

      if (command.Interval.Milliseconds > default(int))
      {
        command.Milliseconds = Convert.ToInt32(command.Interval.Milliseconds);
        return;
      }

      var hoursInMilliseconds = command.Interval?.Hours > 0 ? TimeSpan.FromHours(Convert.ToInt32(command.Interval.Hours)).TotalMilliseconds : 0;
      var MinutesInMilliseconds = command.Interval?.Minutes > 0 ? TimeSpan.FromMinutes(Convert.ToInt32(command.Interval.Minutes)).TotalMilliseconds : 0;
      var secondsInMilliseconds = command.Interval?.Seconds > 0 ? TimeSpan.FromSeconds(Convert.ToInt32(command.Interval.Seconds)).TotalMilliseconds : 0;

      command.Milliseconds = Convert.ToInt32(hoursInMilliseconds + MinutesInMilliseconds + secondsInMilliseconds);
    }
  }
}
