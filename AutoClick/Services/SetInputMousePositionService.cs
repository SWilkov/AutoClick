using AC.Framework.Models;
using AutoClick.Interfaces;

namespace AutoClick.Services
{
  public class SetInputMousePositionService : IMousePositionService
  {
    public MouseLocation Get(Setup setup)
    {
      if (setup == null) throw new ArgumentNullException(nameof(setup));
      if (setup.UseCurrentLocation) throw new ArgumentException("Invalid");

      return new MouseLocation
      {
        X = setup.MouseLocation.X,
        Y = setup.MouseLocation.Y
      };
    }
  }
}
