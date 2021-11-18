using AC.Framework.Models;
using AC.Utils.Interfaces;
using AutoClick.Models;

namespace AutoClick.Commands
{
  public class StartAutoClickCommand : ICommand
  {
    public ClickerConfiguration ClickerConfiguration { get; private set; }
    public ClickTimeFrame ClickTimeFrame { get; private set; }
    public StartAutoClickCommand(ClickTimeFrame clickTimeFrame,
      ClickerConfiguration clickerConfiguration)
    {
      this.ClickerConfiguration = clickerConfiguration;
      this.ClickTimeFrame = clickTimeFrame;
    }
  }
}
