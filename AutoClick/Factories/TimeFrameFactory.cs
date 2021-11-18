using AC.Framework.Models;
using AutoClick.Interfaces;
using AutoClick.Models;

namespace AutoClick.Factories
{
  public class TimeFrameFactory : ITimeFrameFactory
  {
    public ClickTimeFrame Get(Setup setup)
    {
      if (setup == null) throw new ArgumentNullException(nameof(setup));

      if (setup.Repeats)
        return ClickTimeFrame.Repeat;

      if (setup.RunningTime.Enabled)
        return ClickTimeFrame.TimePeriod;

      return ClickTimeFrame.Continous;
    }
  }
}
