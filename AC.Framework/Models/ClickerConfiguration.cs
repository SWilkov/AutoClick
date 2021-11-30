namespace AC.Framework.Models
{  
  public static class ClickerConfiguration
  {
    public static int Interval { get; set; } = 0;
    public static int RepeatsFor { get; set; } = 0;
    public static Time RunningTime { get; set; }
    public static MouseLocation Mouselocation { get; set; }

    public static void Set(int interval, int repeatFor, Time runningTime, MouseLocation mouseLocation)
    {
      Interval = interval;
      RepeatsFor = repeatFor;
      RunningTime = runningTime;
      Mouselocation = mouseLocation;
    }
  }
}
