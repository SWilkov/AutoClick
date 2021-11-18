using AC.Framework.Models;
using AutoClick.Interfaces;

namespace AutoClick.Services
{
  public class SetCurrentMousePositionService : IMousePositionService
  {
    public MouseLocation Get(Setup setup)
    {
      if (setup == null) throw new ArgumentNullException(nameof(setup));
      if (!setup.UseCurrentLocation) throw new ArgumentException("Invalid method");

      var point = Cursor.Position;
      return new MouseLocation
      {
        X = point.X,
        Y = point.Y
      };
    }
  }
}
