namespace AutoClick.Models
{
  public class AutoClickTimer 
  {
    public System.Windows.Forms.Timer IntervalTimer { get; private set; }

    public AutoClickTimer()
    {
      IntervalTimer = new System.Windows.Forms.Timer();
    }
    
    public static readonly AutoClickTimer Instance = new AutoClickTimer();

    public void DisposeEvents()
    {
      if (IntervalTimer != null)
      {
        IntervalTimer.Tick -= (s, e) => { };
      }
    }
  }

  
}
