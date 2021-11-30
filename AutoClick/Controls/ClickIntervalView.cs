using AC.Framework.Models;
using AC.Utils.Models;
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
  

  public partial class ClickIntervalView : UserControl
  {
    private ValidationResult _validationResult;
    public ValidationResult ValidationResult
    {
      get { return _validationResult; }
      set { _validationResult = value; }
    }

    private string _errorMessage;
    public string ErrorMessage
    {
      get { return _errorMessage; }
      set { _errorMessage = value; }
    }

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

    [Browsable(true)]
    [Category("Action")]
    [Description("")]
    public event EventHandler<IntervalChangedEventArgs> IntervalChangedEvent;

    protected void OnIntervalChanged(object sender, IntervalChangedEventArgs e)
    {
      var intervalChangedEvent = IntervalChangedEvent;
      if (intervalChangedEvent != null)
        intervalChangedEvent(this, e);
    }

    private void IntervalChanged(ValidationResult res)
    {
      OnIntervalChanged(this, new IntervalChangedEventArgs(res));
    }

    public ClickIntervalView()
    {
      InitializeComponent();

      this._intervalTime = new Time();
      Validation(out _errorMessage);
      IntervalChanged(_validationResult);

      //this.numHours.DataBindings.Add("Value", this.IntervalTime, "Hours", true, DataSourceUpdateMode.OnPropertyChanged);
      //this.numMinutes.DataBindings.Add("Value", this.IntervalTime, "Minutes", true, DataSourceUpdateMode.OnPropertyChanged);
      //this.numSeconds.DataBindings.Add("Value", this.IntervalTime, "Seconds", true, DataSourceUpdateMode.OnPropertyChanged);
      //this.numMilliseconds.DataBindings.Add("Value", this.IntervalTime, "Milliseconds", true, DataSourceUpdateMode.OnPropertyChanged);
    }
    
    public bool Validation(out string errorMessage)
    {
      if (numHours.Value <= 0 && numMinutes.Value <= 0 && numSeconds.Value <= 0 && numMilliseconds.Value <= 0)
      {
        _validationResult = ValidationResult.Invalid;
        errorMessage = "Need to set a click interval.";
        return false;
      }

      if ((numHours.Value > 0 || numMinutes.Value > 0 || numSeconds.Value > 0) && numMilliseconds.Value > 0)
      {
        _validationResult = ValidationResult.Invalid;
        errorMessage = "Set either hours, minutes, seconds or milliseconds.";
        return false;
      }

      _validationResult = ValidationResult.Valid;
      errorMessage = string.Empty;
      return true;
    }
  
    private void CheckErrors(CancelEventArgs e)
    {
      string error;
      if (!Validation(out error))
      {
        e.Cancel = true;
        this.intervalErrorProvider.SetError(numMilliseconds, error);
      }
    }
   
    private void numHours_ValueChanged(object sender, EventArgs e)
    {
      numMilliseconds.Enabled  = numHours.Value == 0;
      string errorMessage;
      if (!Validation(out errorMessage))
      {

      }

      IntervalChanged(_validationResult);
    }

    private void numMinutes_ValueChanged(object sender, EventArgs e)
    {
      numMilliseconds.Enabled = numMinutes.Value == 0;
      string errorMessage;
      if (!Validation(out errorMessage))
      {

      }
      IntervalChanged(_validationResult);
    }

    private void numSeconds_ValueChanged(object sender, EventArgs e)
    {
      numSeconds.Enabled = numSeconds.Value == 0;
      string errorMessage;
      if (!Validation(out errorMessage))
      {

      }
      IntervalChanged(_validationResult);
    }

    private void numMilliseconds_ValueChanged(object sender, EventArgs e)
    {
      numHours.Enabled = numMilliseconds.Value == 0;
      numMinutes.Enabled = numMilliseconds.Value == 0;
      numSeconds.Enabled = numMilliseconds.Value == 0;
      string errorMessage;
      if (!Validation(out errorMessage))
      {

      }
      IntervalChanged(_validationResult);
    }
  }
}
