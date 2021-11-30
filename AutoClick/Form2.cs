using AC.Framework.Models;
using AC.Utils.Interfaces;
using AC.Utils.Models;
using AutoClick.Commands;
using AutoClick.Interfaces;
using KeyboardSimulator.Native;

namespace AutoClick
{
  public partial class formAutoClick : Form
  {
    #region Fields
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
    private SettingsForm _settingsForm;
    #endregion

    #region ctor
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

      _hotKeyService.RegisterHotKeyWrapper(this.Handle, STOPCLICKS_HOTKEY_ID, (int)Modifiers.Ctrl, _userSettingsService.GetStopKey());
 
      SetupControlDataBindings();

      this.btnStop.Enabled = false;
      SetStopText();

      #region Events
      ClickStats.Instance.PropertyChanged += (s, e) =>
      {
        repeaterProgress1.Step();
      };

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
      repeaterProgress1.Maximum = ClickerConfiguration.RepeatsFor;
      repeaterProgress1.Setup();
    }
    #endregion

    #region System Events
    protected override void WndProc(ref Message m)
    {
      if (m.Msg == (int)Specials.WM_HOTKEY && m.WParam.ToInt32() == STOPCLICKS_HOTKEY_ID)
      {
        //Start/Stop the autoclicker
        if (_timeService.Enabled)
          _stopAutoClickHandler.Handle(new StopAutoClickCommand());
        else
          StartTimer();
      }
     
      base.WndProc(ref m);
    }
    #endregion

    #region Overriden Events
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
    #endregion     

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

    #region Control Events
    private void btnStart_Click(object sender, EventArgs e) => StartTimer();    

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

    private void btnHotKey_Click(object sender, EventArgs e)
    {
      if (_settingsForm == null)
        _settingsForm = new SettingsForm();

      _settingsForm.Show();

      FormState.PreviousPage = this;
      this.Hide();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      repeaterProgress1.Maximum = repeaterView.RepeatsFor;
      repeaterProgress1.Setup();

      ClickStats.Instance.Reset();
    }
    #endregion

    #region Helper methods
    private void StartTimer()
    {
      repeaterProgress1.Maximum = repeaterView.RepeatsFor;
      repeaterProgress1.Setup();

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
    private void SetStopText()
    {
      this.btnStop.Text = $"Stop (Ctrl/\n{(VirtualKeyCodes)_userSettingsService.GetStopKey()})";
    }
    #endregion
  }
}
