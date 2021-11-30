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

    private bool _repeats = false;
    public bool Repeats
    {
      get { return _repeats; }
      set { _repeats = value; }
    }

    private int _repeatsFor = 50;
    public int RepeatsFor
    {
      get { return _repeatsFor; }
      set { _repeatsFor = value; }
    }

    public RepeaterView()
    {
      InitializeComponent();
      DataBinding();

      this.Repeats = true;
    }

    private void btnRepeat_CheckedChanged(object sender, EventArgs e)
    {
      numRepeats.Enabled = btnRepeat.Checked;
    }

    private void DataBinding()
    {
      btnRepeat.DataBindings.Add("Checked", this, "Repeats", true, DataSourceUpdateMode.OnPropertyChanged);
      numRepeats.DataBindings.Add("Value", this, "RepeatsFor", true, DataSourceUpdateMode.OnPropertyChanged);
    }
  }
}
