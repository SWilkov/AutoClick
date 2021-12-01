using AC.Framework.Models;

namespace AutoClick.Interfaces
{
  /// <summary>
  /// Service class to help position the mouse cursor
  /// </summary>
  public interface IMousePositionService
  {
    /// <summary>
    /// gets a X/Y position for the mouse based on user provided setup
    /// </summary>
    /// <param name="setup">Setup contains details about mouse location preference ie use current location</param>
    /// <returns>X and Y co-ordinates of the mouse position</returns>
    MouseLocation Get(Setup setup);
  }
}
