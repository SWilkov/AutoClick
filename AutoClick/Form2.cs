using AC.Framework.Models;
using AC.Utils.Interfaces;
using AC.Utils.Models;
using AutoClick.Commands;
using AutoClick.Interfaces;
using AutoClick.Notifications;
using System.ComponentModel;

namespace AutoClick
{
  public partial class formAutoClick : Form
  {
    private readonly Setup _setup;
    
    private readonly IValidator<Setup> _validator;
    private readonly IMousePositionService _mousePositionService;
    private readonly ICommandHandler<StartAutoClickCommand> _startAutoClickHandler;
    private readonly ITimeFrameFactory _timeFrameFactory;
    private readonly ICommandHandler<TimerIntervalCommand> _timeIntervalHandler;
    private readonly ITimerPublisher _timerPublisher;
    private readonly ICommandHandler<StopAutoClickCommand> _stopAutoClickHandler;
    private readonly ITimeService _timeService;
    //private readonly IStatsService _statsService;


    public formAutoClick(IValidator<Setup> validator,
      IMousePositionService mousePositionService,
      ICommandHandler<StartAutoClickCommand> starAutoClickHandler,
      ITimeFrameFactory timeFrameFactory,
      ICommandHandler<TimerIntervalCommand> timeIntervalHandler,
      ICommandHandler<StopAutoClickCommand> stopAutoClickHandler,
      ITimerPublisher timerPublisher, ITimeService timeService)
    {
      InitializeComponent();
      _setup = new Setup();

      //this.Controls.Add(new ClickIntervalView());

      _validator = validator;
      _mousePositionService = mousePositionService;
      _startAutoClickHandler = starAutoClickHandler;
      _stopAutoClickHandler = stopAutoClickHandler;
      _timeFrameFactory = timeFrameFactory;
      _timeIntervalHandler = timeIntervalHandler;
      _timerPublisher = timerPublisher;
      _timeService = timeService;

      SetupControlDataBindings();

      //this.lblIntervalHelp.Text = "Set hours, minutes, seconds or milliseconds if both are detected milliseconds will be used.";
      this.btnStop.Enabled = false;

      ClickStats.Instance.PropertyChanged += (s, e) =>
      {
        Console.WriteLine(e.PropertyName);
      };

      _timerPublisher.TimerEndedEvent += (s, e) =>
      {
        Console.WriteLine("Timer Ended Event!");
        btnStart.Enabled = true;
        btnStop.Enabled = false;
      };
      _timeService = timeService;
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (_timerPublisher != null)
        _timerPublisher.TimerEndedEvent -= (s, e) => { };
      if (ClickStats.Instance != null)
        ClickStats.Instance.PropertyChanged -= (s, e) => { };

      base.OnFormClosing(e);
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

    #region DataBinding
    private void SetupControlDataBindings()
    {
      //this.numHours.DataBindings.Add("Value", _setup.Interval, "Hours", true, DataSourceUpdateMode.OnPropertyChanged);
      //this.numMinutes.DataBindings.Add("Value", _setup.Interval, "Minutes", true, DataSourceUpdateMode.OnPropertyChanged);
      //this.numSeconds.DataBindings.Add("Value", _setup.Interval, "Seconds", true, DataSourceUpdateMode.OnPropertyChanged);
      //this.numMilliseconds.DataBindings.Add("Value", _setup.Interval, "Milliseconds", true, DataSourceUpdateMode.OnPropertyChanged);
      this.chkCurrentLocation.DataBindings.Add("Checked", _setup, "UseCurrentLocation", true, DataSourceUpdateMode.OnPropertyChanged);

      this.numX.DataBindings.Add("Value", _setup.MouseLocation, "X", true, DataSourceUpdateMode.OnPropertyChanged);
      this.numY.DataBindings.Add("Value", _setup.MouseLocation, "Y", true, DataSourceUpdateMode.OnPropertyChanged);

      this.numRepeats.DataBindings.Add("Value", _setup, "RepeatsFor", true, DataSourceUpdateMode.OnPropertyChanged);
           
      lblTotalClicks.DataBindings.Add("Text", ClickStats.Instance, "Total", true, DataSourceUpdateMode.OnPropertyChanged);
    }

   
    #endregion

    #region Start/Stop Events
    private void btnStart_Click(object sender, EventArgs e)
    {
      //Console.WriteLine($"{numHours.Text} Hours, {numMinutes.Text} Minutes");

      var validation = _validator.Validate(_setup);
      if (validation != null && validation.Result == ValidationResult.Invalid)
      {
        Console.WriteLine($"{validation.Message}");
        lblErrorMessage.Text = validation.Message;
      }

      var timeFrame = _timeFrameFactory.Get(_setup);
      var timeIntervalCommand = new TimerIntervalCommand(clickIntervalViewForRepeat.IntervalTime);
      _timeIntervalHandler.Handle(timeIntervalCommand);

      var mp = _mousePositionService.Get(_setup);

      ClickerConfiguration.Set(timeIntervalCommand.Milliseconds, _setup.RepeatsFor, _setup.RunningTime, mp);

      //var config = new ClickerConfiguration(timeIntervalCommand.Interval, _setup.RepeatsFor, _setup.RunningTime, mp);

      //var startCommand = new StartAutoClickCommand(timeFrame, ClickerConfiguration);
      //_startAutoClickHandler.Handle(startCommand);
      _timeService.Run(timeFrame, ClickerConfiguration.Interval, ClickerConfiguration.RepeatsFor);

      btnStart.Enabled = false;
      btnStop.Enabled = true;
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      var cmd = new StopAutoClickCommand();
      _stopAutoClickHandler.Handle(cmd);

      btnStart.Enabled = true;
      btnStop.Enabled = false;
    }

    private void btnStop_EnabledChanged(object sender, EventArgs e)
    {
      btnStop.BackColor = btnStop.Enabled ? Color.Red : Color.DarkGray;
    }

    private void btnStart_EnabledChanged(object sender, EventArgs e)
    {
      btnStart.BackColor = btnStart.Enabled ? Color.SpringGreen : Color.DarkGray;
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
        
      }
    }

    private void btnResetStats_Click(object sender, EventArgs e)
    {
      ClickStats.Instance.Reset(); 
    }

    private void lblMilliseconds_Click(object sender, EventArgs e)
    {

    } 
    
    
  }
}
