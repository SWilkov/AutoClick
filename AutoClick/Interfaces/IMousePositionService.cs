using AC.Framework.Models;

namespace AutoClick.Interfaces
{
  public interface IMousePositionService
  {
    MouseLocation Get(Setup setup);
  }
}
