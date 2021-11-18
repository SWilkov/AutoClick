namespace AC.Framework.Models
{
  public class Time
  {
    public double Hours { get; set; } = 0;
    public double Minutes { get; set; } = 0;
    public double Seconds { get; set; } = 0;
    public int Milliseconds { get; set; } = 0;
    public bool Enabled => Hours > 0 || Minutes > 0 || Seconds > 0 || Milliseconds > 0;
  }
}
