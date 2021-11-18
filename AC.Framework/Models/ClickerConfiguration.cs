namespace AC.Framework.Models
{
  public class ClickerConfiguration
  {
    public int Interval { get; private set; }
    public int RepeatsFor { get; private set; }
    public Time RunningTime { get; private set; }
    public MouseLocation Mouselocation { get; private set; }
    public ClickerConfiguration(int interval, int repeatsFor, Time runningTime, MouseLocation mouseLocation)
    {
      this.Interval = interval;
      this.RepeatsFor = repeatsFor;
      this.RunningTime = runningTime;
      this.Mouselocation = mouseLocation;
    }
  }
}
