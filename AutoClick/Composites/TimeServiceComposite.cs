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

    public void Run(ClickTimeFrame timeFrame) =>
      _services[timeFrame].Run(timeFrame);

    public bool Enabled =>
      _services.Values.Any(x => x.Enabled);
  }
}
