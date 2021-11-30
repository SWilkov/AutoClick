using AC.Framework.Models;
using AutoClick.Interfaces;
using AutoClick.Notifications;
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
  public partial class RepeaterProgress : UserControl, INotifyPropertyChanged
  {
    protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
    {
      var propertyChanged = PropertyChanged;
      if (propertyChanged != null)
        propertyChanged(this, e);
    }

    private int _maximum = 50;
    public int Maximum 
    {
      get { return _maximum; }
      set 
        {
          if (Equals(value, _maximum))
            return;
          _maximum = value;
          OnPropertyChanged(new PropertyChangedEventArgs("Maximun"));
        }
    }

    private ITimerPublisher _timerPublisher;

    public event PropertyChangedEventHandler? PropertyChanged;

    public RepeaterProgress()
    {
      InitializeComponent();           
    }

    public void Setup()
    {
      
      repeaterProgressBar.Minimum = 1;
      repeaterProgressBar.Step = 1;
      repeaterProgressBar.Maximum = this.Maximum;
      repeaterProgressBar.Value = repeaterProgressBar.Minimum;
    }

    public void Step()
    {
      repeaterProgressBar.PerformStep();
    }

    public void Reset()
    {
      
    }
  }
}
