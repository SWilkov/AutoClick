using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AC.Framework.Models
{
  public class Time : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
    {
      var handler = PropertyChanged;
      if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
    }

    private decimal _hours = 0;
    public decimal Hours
    {
      get {  return _hours; }
      set
      {
        if (Equals(value, _hours)) return;  
        _hours = value;
        OnPropertyChanged(nameof(Hours));
      }
    }

    private decimal _minutes = 0;
    public decimal Minutes
    {
      get { return _minutes; }
      set
      {
        if (Equals(value, _minutes)) return;
        _minutes = value;
        OnPropertyChanged(nameof(Minutes));
      }
    }

    private decimal _seconds = 0;
    public decimal Seconds
    {
      get => _seconds;
      set
      {
        if (Equals(_seconds, value)) return;
        _seconds = value;
        OnPropertyChanged(nameof(Seconds));
      }
    }

    private decimal _milliseconds = 0;
    public decimal Milliseconds
    {
      get => (_milliseconds == 0) ? 0 : _milliseconds;
      set
      {
        if (Equals(_milliseconds, value)) return;
        _milliseconds = value;
        OnPropertyChanged(nameof(Milliseconds));
      }
    }

    private bool _enabled = true;
    public bool Enabled
    {
      get => _enabled;
      private set
      {
        _enabled = Hours > 0 || Minutes > 0 || Seconds > 0 || Milliseconds > 0;
        OnPropertyChanged(nameof(Enabled));
      }
    }
    //public bool Enabled => Hours > 0 || Minutes > 0 || Seconds > 0 || Milliseconds > 0;
  }
}
