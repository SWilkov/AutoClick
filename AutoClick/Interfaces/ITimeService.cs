using AC.Framework.Models;
using AutoClick.Models;

namespace AutoClick.Interfaces
{
  public interface ITimeService
  {
    void Run(ClickTimeFrame timeFrame);
    bool Enabled { get; }
  }
}