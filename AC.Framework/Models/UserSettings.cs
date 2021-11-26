using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AC.Framework.Models
{
  public class UserSettings : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      var handler = PropertyChanged;
      if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
    }

    private int _stopHotKey = 0;
    public int StopHotKey
    {
      get { return _stopHotKey; }
      set
      {
        if (Equals(value, _stopHotKey)) return;
        _stopHotKey = value;
        OnPropertyChanged();
      }
    }
  }
}
