namespace AutoClick.Models
{
  public class AutoClickTimer 
  {
    public System.Windows.Forms.Timer IntervalTimer { get; private set; }
    public System.Windows.Forms.Timer TimePeriodTimer { get; private set; }
    public AutoClickTimer()
    {
      if (this.IntervalTimer == null)
        this.IntervalTimer = new System.Windows.Forms.Timer();
      if (this.TimePeriodTimer == null)
        this.TimePeriodTimer = new System.Windows.Forms.Timer();
    }
  }

  
}
