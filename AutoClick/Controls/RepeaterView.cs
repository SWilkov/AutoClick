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
  public partial class RepeaterView : UserControl
  {
    public Repeater Repeater { get; set; } 
    public RepeaterView()
    {
      InitializeComponent();
      this.Repeater = new Repeater();
      DataBinding();
    }

    private void btnRepeat_CheckedChanged(object sender, EventArgs e)
    {
      numRepeats.Enabled = btnRepeat.Checked;
    }

    private void DataBinding()
    {
      btnRepeat.DataBindings.Add("Checked", this.Repeater, "Repeats", true, DataSourceUpdateMode.OnPropertyChanged);
      numRepeats.DataBindings.Add("Value", this.Repeater, "RepeatsFor", true, DataSourceUpdateMode.OnPropertyChanged);
    }
  }
}
