using AC.Framework.Models;
using AutoClick.Interfaces;
using AutoClick.Models;

namespace AutoClick.Composites
{
  public class TimeServiceComposite : ITimeService
  {
    private readonly Dictionary<ClickTimeFrame, ITimeService> _services;

    public TimeServiceComposite(Dictionary<ClickTimeFrame, ITimeService> services)
    {
      _services = services;
    }

    public void Run(ClickTimeFrame timeFrame, int interval, int repeatsFor) =>
      _services[timeFrame].Run(timeFrame, interval, repeatsFor);
  }
}
