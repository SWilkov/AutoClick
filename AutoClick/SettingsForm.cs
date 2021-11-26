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
  public partial class SettingsForm : Form
  {
    private string _stopKey;
    public string StopKey
    {
      get { return _stopKey; }
      set
      {

      }
    }

    public SettingsForm()
    {
      InitializeComponent();

      Properties.Settings.Default.StopKey;
    }
  }
}
