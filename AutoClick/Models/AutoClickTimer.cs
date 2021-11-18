namespace AutoClick.Models
{
  public class AutoClickTimer
  {
    public System.Windows.Forms.Timer IntervalTimer { get; set; }
    public System.Windows.Forms.Timer TimePeriodTimer { get; set; }
    public AutoClickTimer()
    {
      if (this.IntervalTimer == null)
        this.IntervalTimer = new System.Windows.Forms.Timer();
      if (this.TimePeriodTimer == null)
        this.TimePeriodTimer = new System.Windows.Forms.Timer();
    }


  }
}
