using AC.Framework.Models;
using AC.Utils.Interfaces;
using AC.Utils.Models;
using AutoClick.Commands;
using AutoClick.Interfaces;
using System.ComponentModel;

namespace AutoClick
{
  public partial class Form2 : Form
  {
    private readonly Setup _setup;
    private readonly IValidator<Setup> _validator;
    private readonly IMousePositionService _mousePositionService;
    private readonly ICommandHandler<StartAutoClickCommand> _startAutoClickHandler;
    private readonly ITimeFrameFactory _timeFrameFactory;
    private readonly ICommandHandler<TimerIntervalCommand> _timeIntervalHandler;
    private readonly ICommandHandler<StopAutoClickCommand> _stopAutoClickHandler;

    public Form2(IValidator<Setup> validator,
      IMousePositionService mousePositionService,
      ICommandHandler<StartAutoClickCommand> starAutoClickHandler,
      ITimeFrameFactory timeFrameFactory,
      ICommandHandler<TimerIntervalCommand> timeIntervalHandler,
      ICommandHandler<StopAutoClickCommand> stopAutoClickHandler)
    {
      InitializeComponent();
      _setup = new Setup();
      _validator = validator;
      _mousePositionService = mousePositionService;
      _startAutoClickHandler = starAutoClickHandler;
      _stopAutoClickHandler = stopAutoClickHandler;
      _timeFrameFactory = timeFrameFactory;
      _timeIntervalHandler = timeIntervalHandler;

      
      this.numHours.DataBindings.Add("Value", _setup.Interval, "Hours", true, DataSourceUpdateMode.OnPropertyChanged);
      this.numMinutes.DataBindings.Add("Value", _setup.Interval, "Minutes", true, DataSourceUpdateMode.OnPropertyChanged);
      this.numSeconds.DataBindings.Add("Value", _setup.Interval, "Seconds", true, DataSourceUpdateMode.OnPropertyChanged);
      this.numMilliseconds.DataBindings.Add("Value", _setup.Interval, "Milliseconds", true, DataSourceUpdateMode.OnPropertyChanged);
      this.chkCurrentLocation.DataBindings.Add("Checked", _setup, "UseCurrentLocation", true, DataSourceUpdateMode.OnPropertyChanged);

      this.numX.DataBindings.Add("Value", _setup.MouseLocation, "X", true, DataSourceUpdateMode.OnPropertyChanged);
      this.numY.DataBindings.Add("Value", _setup.MouseLocation, "Y", true, DataSourceUpdateMode.OnPropertyChanged);

      this.numRepeats.DataBindings.Add("Value", _setup, "RepeatsFor", true, DataSourceUpdateMode.OnPropertyChanged);
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      Console.WriteLine($"{numHours.Text} Hours, {numMinutes.Text} Minutes");

      var validation = _validator.Validate(_setup);
      if (validation != null && validation.Result == ValidationResult.Invalid)
      {
        Console.WriteLine($"{validation.Message}");
        lblErrorMessage.Text = validation.Message;
      }

      var timeFrame = _timeFrameFactory.Get(_setup);
      var timeIntervalCommand = new TimerIntervalCommand(_setup);
      _timeIntervalHandler.Handle(timeIntervalCommand);

      var mp = _mousePositionService.Get(_setup);

      var config = new ClickerConfiguration(timeIntervalCommand.Interval, _setup.RepeatsFor, _setup.RunningTime, mp);

      var startCommand = new StartAutoClickCommand(timeFrame, config);

      _startAutoClickHandler.Handle(startCommand);

      lblF.Text = "Started";
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }    

    private void numY_ValueChanged(object sender, EventArgs e)
    {
      if (chkCurrentLocation.Checked)
        chkCurrentLocation.Checked = false;
    }

    private void numX_ValueChanged(object sender, EventArgs e)
    {
      if (chkCurrentLocation.Checked)
        chkCurrentLocation.Checked = false;
    }   

    private void Validate()
    {
      var validation = _validator.Validate(_setup);
      if (validation.Result == ValidationResult.Invalid)
      {
        lblErrorMessage.Text = validation.Message;
      } else
      {
        lblErrorMessage.Text = String.Empty;
      }
    }

    private void numHours_Validating(object sender, CancelEventArgs e)
    {
      //Validate();
    }

    private void numMinutes_Validating(object sender, CancelEventArgs e)
    {
      //Validate();
    }

    private void numSeconds_Validating(object sender, CancelEventArgs e)
    {
      //Validate();
    }

    private void numMilliseconds_Validating(object sender, CancelEventArgs e)
    {
      //Validate();
    }

    #region Events

    private void btnStop_Click(object sender, EventArgs e)
    {
      var cmd = new StopAutoClickCommand();
      _stopAutoClickHandler.Handle(cmd);
    }


    #endregion

    private void Form2_KeyPress(object sender, KeyPressEventArgs e)
    {
      
    }

    private void Form2_KeyDown(object sender, KeyEventArgs e)
    {
      //TODO this only works when the form is in focus. Need to add a keyboard hook to activate at anytime
      if (e.KeyCode == Keys.F10)
      {
        var stopCommand = new StopAutoClickCommand();
        _stopAutoClickHandler.Handle(stopCommand);
        lblF.Text = "Stopped";
      }
    }
  }
}
