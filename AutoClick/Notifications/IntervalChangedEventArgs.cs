using AC.Utils.Models;

namespace AutoClick.Notifications
{
  public class IntervalChangedEventArgs : EventArgs
  {
    public ValidationResult Result { get; private set; }
    public IntervalChangedEventArgs(ValidationResult result)
    {
      this.Result = result;
    }
  }
}
