using AC.Framework.Models;
using AutoClick.Interfaces;
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
  public partial class ClickStatistics : UserControl
  {
    private readonly IClickStatsService _clickStatsService;
      
    public ClickStatistics()
    {
      InitializeComponent();
      SetDataBindings();
    }

    //public ClickStatistics(IClickStatsService clickStatsService)
    //{
    //  InitializeComponent();

    //  _clickStatsService = clickStatsService;
    //}

    private void SetDataBindings()
    {
      lblTotalClicks.DataBindings.Add("Text", ClickStats.Instance, "Total", true, DataSourceUpdateMode.OnPropertyChanged);
    }    
  }
}
