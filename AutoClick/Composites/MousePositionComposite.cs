using AC.Framework.Models;
using AutoClick.Interfaces;

namespace AutoClick.Composites
{
  public class MousePositionComposite : IMousePositionService
  {
    private readonly Dictionary<bool, IMousePositionService> _services;
    public MousePositionComposite(Dictionary<bool, IMousePositionService> services)
    {
      _services = services;
    }

    public MouseLocation Get(Setup setup) =>
      _services[setup.UseCurrentLocation].Get(setup);
  }
}
