using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AC.Framework.Models
{
  public class Repeater : INotifyPropertyChanged
  {
    private bool _repeats;
    public bool Repeats
    {
      get { return _repeats; }
      set
      {
        if (Equals(value, _repeats))
          return;
        _repeats = value;
        OnPropertyChanged();
      }
    }
    private int _repeatsFor;
    public int RepeatsFor
    {
      get { return _repeatsFor; }
      set
      {
        if (Equals(value, _repeatsFor)) return;
        _repeatsFor = value;
        OnPropertyChanged();
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      var handler = PropertyChanged;
      if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
    }

  }
}
