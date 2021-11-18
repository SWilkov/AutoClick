using AC.Utils.Interfaces;

namespace AutoClick.Commands
{
  public class StopAutoClickCommand : ICommand
  {
    public DateTime StoppedAt { get; set; }
    public string Message { get; set; } = "";
    public StopAutoClickCommand()
    {
      
    }
  }
}
