using AC.Framework.Models;
using AutoClick.Models;

namespace AutoClick.Interfaces
{
  /// <summary>
  /// Determines which type of AutoClicker to run
  /// </summary>
  public interface ITimeService
  {
    /// <summary>
    /// Start and run the timer based on which TimeFrame 
    /// </summary>
    /// <param name="timeFrame">Repeater or Continuous timer</param>
    void Run(ClickTimeFrame timeFrame);
    /// <summary>
    /// Is the timer running?
    /// </summary>
    bool Enabled { get; }
  }
}