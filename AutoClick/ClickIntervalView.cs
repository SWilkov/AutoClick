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

namespace AutoClick
{
  public partial class ClickIntervalView : UserControl
  {
    [Category("Setup"), Description("Interval Time controls the gap between auto mouse clicks"),
      Bindable(true, BindingDirection.TwoWay)]
    public Time IntervalTime { get; set; }
    public ClickIntervalView()
    {
      InitializeComponent();

      this.IntervalTime = new Time();

      this.numHours.DataBindings.Add("Value", this.IntervalTime, "Hours", true, DataSourceUpdateMode.OnPropertyChanged);
      this.numMinutes.DataBindings.Add("Value", this.IntervalTime, "Minutes", true, DataSourceUpdateMode.OnPropertyChanged);
      this.numSeconds.DataBindings.Add("Value", this.IntervalTime, "Seconds", true, DataSourceUpdateMode.OnPropertyChanged);
      this.numMilliseconds.DataBindings.Add("Value", this.IntervalTime, "Milliseconds", true, DataSourceUpdateMode.OnPropertyChanged);
    }
  }
}
