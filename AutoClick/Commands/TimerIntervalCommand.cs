using AC.Framework.Models;
using AC.Utils.Interfaces;

namespace AutoClick.Commands
{
  public class TimerIntervalCommand : ICommand
  {
    public Time? Interval { get; private set; }
    public int Milliseconds { get; set; } //always set milliseconds
    public TimerIntervalCommand(Time? interval)
    {
      this.Interval = interval;
    }
  }
}
