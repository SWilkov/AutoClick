using AC.Framework.Models;
using AutoClick.Models;

namespace AutoClick.Interfaces
{
  /// <summary>
  /// factory class to generate type of Clicker
  /// </summary>
  public interface ITimeFrameFactory
  {
    /// <summary>
    /// Gets the enum type of Auto Clicker
    /// </summary>
    /// <param name="repeaterSetup">Setup details from the user</param>
    /// <returns>type of AutoClick timeframe ie Repeater, Continuous. Defaults to Repeater</returns>
    ClickTimeFrame Get(Repeater repeaterSetup);
  }
}
