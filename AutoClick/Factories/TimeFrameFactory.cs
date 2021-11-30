using AC.Framework.Models;
using AutoClick.Interfaces;
using AutoClick.Models;

namespace AutoClick.Factories
{
  public class TimeFrameFactory : ITimeFrameFactory
  {
    public ClickTimeFrame Get(Repeater repeaterSetup)
    {
      if (repeaterSetup == null) throw new ArgumentNullException(nameof(repeaterSetup));

      return repeaterSetup.Repeats ? ClickTimeFrame.Repeat : ClickTimeFrame.Continuous;
    }
  }
}
