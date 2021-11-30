using AutoClick.Interfaces;

namespace AutoClick.Services
{
  public class UserSettingsService : IUserSettingsService
  {
    public int GetStopKey() => Properties.Settings.Default.StopKey;
    public int GetStopKeyId() => Properties.Settings.Default.StopKeyId;
  }
}
