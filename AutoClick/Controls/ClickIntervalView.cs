using AC.Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClick.Controls
{
  public partial class ClickIntervalView : UserControl
  {
    private Time _intervalTime;
    public Time IntervalTime
    {
      get
      {
        _intervalTime.Hours = numHours.Value;
        _intervalTime.Minutes = numMinutes.Value;
        _intervalTime.Seconds = numSeconds.Value;
        _intervalTime.Milliseconds = numMilliseconds.Value;
        return _intervalTime;
      }
      set
      {
        _intervalTime = value;
      }
    }
    public decimal Milliseconds
    {
      get { return numMilliseconds.Value; }
    }

    public ClickIntervalView()
    {
      InitializeComponent();

      this._intervalTime = new Time();

      //this.numHours.DataBindings.Add("Value", this.IntervalTime, "Hours", true, DataSourceUpdateMode.OnPropertyChanged);
      //this.numMinutes.DataBindings.Add("Value", this.IntervalTime, "Minutes", true, DataSourceUpdateMode.OnPropertyChanged);
      //this.numSeconds.DataBindings.Add("Value", this.IntervalTime, "Seconds", true, DataSourceUpdateMode.OnPropertyChanged);
      //this.numMilliseconds.DataBindings.Add("Value", this.IntervalTime, "Milliseconds", true, DataSourceUpdateMode.OnPropertyChanged);
    }
  }
}
