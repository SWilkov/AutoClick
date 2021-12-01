namespace AutoClick.Interfaces
{
  /// <summary>
  /// Wrapper for the static CliskStats 
  /// </summary>
  public interface IClickStatsService
  {
    /// <summary>
    /// Add one to the count
    /// </summary>
    void Add();
    /// <summary>
    /// reset the count to zero
    /// </summary>
    void Reset();
  }
}