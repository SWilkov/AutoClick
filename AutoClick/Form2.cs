using AC.Framework.Models;
using AC.Utils.Interfaces;
using AC.Utils.Models;
using AutoClick.Commands;
using AutoClick.Interfaces;
using AutoClick.Notifications;
using System.ComponentModel;
using KeyboardSimulator.Native;

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
    private readonly IUserSettingsService _userSettingsService;
    private readonly IHotKeyService _hotKeyService;
    private const int STOPCLICKS_HOTKEY_ID = 1;
    //private readonly IStatsService _statsService;
    private SettingsForm _settingsForm;

    public formAutoClick(IValidator<Setup> validator,
      IMousePositionService mousePositionService,
      ICommandHandler<StartAutoClickCommand> starAutoClickHandler,
      ITimeFrameFactory timeFrameFactory,
      ICommandHandler<TimerIntervalCommand> timeIntervalHandler,
      ICommandHandler<StopAutoClickCommand> stopAutoClickHandler,
      ITimerPublisher timerPublisher, ITimeService timeService,
      IUserSettingsService userSettingsService,
      IHotKeyService hotKeyService)
    {
      InitializeComponent();
      _setup = new Setup();
      
      _validator = validator;
      _mousePositionService = mousePositionService;
      _startAutoClickHandler = starAutoClickHandler;
      _stopAutoClickHandler = stopAutoClickHandler;
      _timeFrameFactory = timeFrameFactory;
      _timeIntervalHandler = timeIntervalHandler;
      _timerPublisher = timerPublisher;
      _timeService = timeService;
      _userSettingsService = userSettingsService;
      _hotKeyService = hotKeyService;

      _hotKeyService.RegisterHotKeyWrapper(this.Handle, STOPCLICKS_HOTKEY_ID, (int)Modifiers.Ctrl, (int)VirtualKeyCodes.F8);
 
      SetupControlDataBindings();

      this.btnStop.Enabled = false;
      SetStopText();

      #region Events
      _timerPublisher.TimerEndedEvent += (s, e) =>
      {
        Console.WriteLine("Timer Ended Event!");
        btnStart.Enabled = true;
        btnStop.Enabled = false;
      };

      clickIntervalViewForRepeat.IntervalChangedEvent += (s, e) =>
      {
        Console.WriteLine($"{e.Result}");
        this.btnStart.Enabled = e.Result == ValidationResult.Valid;
      };

      _settingsForm = new SettingsForm();
      _settingsForm.SettingsSavedEvent += (s, e) =>
      {
        SetStopText();
      };

      #endregion
      _timeService = timeService;
      btnStart.Enabled = false;
    }

    protected override void WndProc(ref Message m)
    {
      if (m.Msg == (int)Specials.WM_HOTKEY && m.WParam.ToInt32() == STOPCLICKS_HOTKEY_ID)
      {
        //Stop the autoclicker
        _stopAutoClickHandler.Handle(new StopAutoClickCommand());
      }
      
      base.WndProc(ref m);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (_timerPublisher != null)
        _timerPublisher.TimerEndedEvent -= (s, e) => { };
      if (_settingsForm != null)
        _settingsForm.SettingsSavedEvent -= (s, e) => { };
      if (clickIntervalViewForRepeat != null)
        clickIntervalViewForRepeat.IntervalChangedEvent -= (s, e) => { };
     
      _hotKeyService.UnregisterHotKeyWrapper(this.Handle, STOPCLICKS_HOTKEY_ID);
      base.OnFormClosing(e);
    }

    private void SetStopText()
    {
      this.btnStop.Text = $"Stop (Ctrl/\n{(VirtualKeyCodes)_userSettingsService.GetStopKey()})";
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
      this.chkCurrentLocation.DataBindings.Add("Checked", _setup, "UseCurrentLocation", true, DataSourceUpdateMode.OnPropertyChanged);

      this.numX.DataBindings.Add("Value", _setup.MouseLocation, "X", true, DataSourceUpdateMode.OnPropertyChanged);
      this.numY.DataBindings.Add("Value", _setup.MouseLocation, "Y", true, DataSourceUpdateMode.OnPropertyChanged);

      //this.numRepeats.DataBindings.Add("Value", _setup, "RepeatsFor", true, DataSourceUpdateMode.OnPropertyChanged);
           
      //lblTotalClicks.DataBindings.Add("Text", ClickStats.Instance, "Total", true, DataSourceUpdateMode.OnPropertyChanged);
    }

   
    #endregion

    #region Start/Stop Events
    private void btnStart_Click(object sender, EventArgs e)
    {
      var validation = _validator.Validate(_setup);
      if (validation != null && validation.Result == ValidationResult.Invalid)
      {
        Console.WriteLine($"{validation.Message}");
        lblErrorMessage.Text = validation.Message;
      }

      _setup.Repeater = new Repeater
      {
        Repeats = repeaterView.Repeats,
        RepeatsFor = repeaterView.RepeatsFor
      };      

      var timeFrame = _timeFrameFactory.Get(_setup.Repeater);
      var timeIntervalCommand = new TimerIntervalCommand(clickIntervalViewForRepeat.IntervalTime);
      _timeIntervalHandler.Handle(timeIntervalCommand);

      var mp = _mousePositionService.Get(_setup);      
      ClickerConfiguration.Set(timeIntervalCommand.Milliseconds, _setup.Repeater.RepeatsFor, _setup.RunningTime, mp);
           
      _timeService.Run(timeFrame);

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



    private void btnResetStats_Click(object sender, EventArgs e)
    {
      ClickStats.Instance.Reset(); 
    }    

    private void btnHotKey_Click(object sender, EventArgs e)
    {
      if (_settingsForm == null)
        _settingsForm = new SettingsForm();
     
      _settingsForm.Show();

      FormState.PreviousPage = this;
      this.Hide();
    }
  }
}
