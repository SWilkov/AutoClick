using AC.Framework.Models;

namespace AutoClick.Interfaces
{
  public interface IStatsService
  {
    ClickStats Stats { get; }
    void ResetTotalClicks();
    void AddToClicks(int amount = 1);
  }
}