using System;
using System.ComponentModel;

namespace AC.Framework.Models
{
  public class ClickStats : INotifyPropertyChanged
  {
    private int _total;
    public int Total
    {
      get { return _total; }
      set
      {
        if (_total == value)
        {
          return;
        }

        _total = value;
        if (this.PropertyChanged != null)
          this.PropertyChanged(this, new PropertyChangedEventArgs("Total"));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private ClickStats()
    {

    }

    public void Add()
    {
      this.Total++;
    }

    public void Reset() => this.Total = 0;

    
    public static readonly ClickStats Instance = new ClickStats();
  }
}
