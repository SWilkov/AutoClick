using AC.Framework.Models;
using AutoClick.Models;

namespace AutoClick.Interfaces
{
  public interface ITimeService
  {
    void Run(ClickTimeFrame timeFrame, int interval, int repeatsFor);
  }
}