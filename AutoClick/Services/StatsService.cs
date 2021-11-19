using AC.Framework.Models;
using AutoClick.Interfaces;

namespace AutoClick.Services
{
  public class StatsService : IStatsService
  {
    private ClickStats _clickStats;
    public ClickStats Stats
    {
      get { return _clickStats; } 
      set { _clickStats = value; }
    }

    public StatsService()
    {
      _clickStats = new ClickStats();
    }
    public void ResetTotalClicks()
    {
      if (_clickStats != null && _clickStats.Total > default(int))
        _clickStats.Total = default(int);
    }

    public void AddToClicks(int amount = 1)
    {
      this._clickStats.Total += amount;
    }
  }
}
