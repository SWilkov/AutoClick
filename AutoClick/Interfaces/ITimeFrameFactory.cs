using AC.Framework.Models;
using AutoClick.Models;

namespace AutoClick.Interfaces
{
  public interface ITimeFrameFactory
  {
    ClickTimeFrame Get(Repeater repeaterSetup);
  }
}
