using AC.Framework.Models;
using AC.Utils.Interfaces;

namespace AutoClick.Commands
{
  public class TimerIntervalCommand : ICommand
  {
    public Setup Setup { get; private set; }
    public int Interval { get; set; } //always milliseconds
    public TimerIntervalCommand(Setup setup)
    {
      this.Setup = setup;
    }
  }
}
