namespace AutoClick.Notifications
{
  public class SettingsSavedEventArgs : EventArgs
  {
    public int SaveKey { get; set; }
    public SettingsSavedEventArgs(int saveKey)
    {
      this.SaveKey = saveKey;
    }
  }
}
