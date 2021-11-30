using AC.Framework.Models;
using AutoClick.Interfaces;

namespace AutoClick.Services
{
  public class ClickStatsService : IClickStatsService
  {
    public void Reset()
    {
      ClickStats.Instance.Reset();
    }

    public void Add()
    {
      ClickStats.Instance.Add();
    }
  }
}
