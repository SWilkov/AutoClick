namespace AutoClick.Interfaces
{
  /// <summary>
  /// Wrapper aorund Windows Forms Settings configuration file
  /// </summary>
  public interface IUserSettingsService
  {
    /// <summary>
    /// Get the saved Stop AutoClick Key eg F10 in hexadecimal
    /// </summary>
    /// <returns></returns>
    int GetStopKey();

    /// <summary>
    /// Gets the StopKey ID used by System methods to register unregister hot key
    /// </summary>
    /// <returns></returns>
    int GetStopKeyId();
  }
}