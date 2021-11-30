using AC.Framework.Models;
using AutoClick.Notifications;
using System.ComponentModel;

namespace AutoClick
{
  public partial class SettingsForm : Form
  {
    private UserSettings _userSettings;
    public UserSettings UserSettings
    {
      get { return _userSettings; }
    }

    [Browsable(true)]
    [Category("Action")]
    [Description("Hot key possibly changed")]
    public event EventHandler<SettingsSavedEventArgs> SettingsSavedEvent;

    protected void OnSettingsSaved(object sender, SettingsSavedEventArgs e)
    {
      var settingsSavedEvent = SettingsSavedEvent;
      if (settingsSavedEvent != null)
        settingsSavedEvent(this, e);
    }

    private void SettingsSaved(int saveKey)
    {
      OnSettingsSaved(this, new SettingsSavedEventArgs(saveKey));
    }

    public SettingsForm()
    {
      InitializeComponent();

      this._userSettings = new UserSettings();
      
      SetStyleDefaults();
      Set(Properties.Settings.Default.StopKey);
    }

    private void Set(int key)
    {
      Properties.Settings.Default.StopKey = key;
      Properties.Settings.Default.Save();

      this._userSettings.StopHotKey = key;
      SetStyleDefaults();
      SetStyleSelected(key);

      //Raise event
      SettingsSaved(key);
    }

    private void btnF1_Click(object sender, EventArgs e) => Set((int)Keys.F1);

    private void btnF2_Click(object sender, EventArgs e) => Set((int)Keys.F2);

    private void btnF3_Click(object sender, EventArgs e) => Set((int)Keys.F3);

    private void btnF4_Click(object sender, EventArgs e) => Set((int)Keys.F4);

    private void btnF5_Click(object sender, EventArgs e) => Set((int)Keys.F5);

    private void btnF6_Click(object sender, EventArgs e) => Set((int)Keys.F6);

    private void btnF7_Click(object sender, EventArgs e) => Set((int)Keys.F7);

    private void btnF8_Click(object sender, EventArgs e) => Set((int)Keys.F8);

    private void btnF9_Click(object sender, EventArgs e) => Set((int)Keys.F9);

    private void btnF10_Click(object sender, EventArgs e) => Set((int)Keys.F10);

    /// <summary>
    /// Clear all the
    /// </summary>
    private void SetStyleDefaults()
    {
      btnF1.BackColor = SystemColors.Control;
      btnF2.BackColor = SystemColors.Control;
      btnF3.BackColor = SystemColors.Control;
      btnF4.BackColor = SystemColors.Control;
      btnF5.BackColor = SystemColors.Control;
      btnF6.BackColor = SystemColors.Control;
      btnF7.BackColor = SystemColors.Control;
      btnF8.BackColor = SystemColors.Control;
      btnF9.BackColor = SystemColors.Control;
      btnF10.BackColor = SystemColors.Control;

      btnF1.ForeColor = SystemColors.ControlText;
      btnF2.ForeColor = SystemColors.ControlText;
      btnF3.ForeColor = SystemColors.ControlText;
      btnF4.ForeColor = SystemColors.ControlText;
      btnF5.ForeColor = SystemColors.ControlText;
      btnF6.ForeColor = SystemColors.ControlText;
      btnF7.ForeColor = SystemColors.ControlText;
      btnF8.ForeColor = SystemColors.ControlText;
      btnF9.ForeColor = SystemColors.ControlText;
      btnF10.ForeColor = SystemColors.ControlText;

    }

    /// <summary>
    /// Sets the back and fore color of the selected Hot Key
    /// </summary>
    /// <param name="key">The int value of Keys enum</param>
    private void SetStyleSelected(int key)
    {
      switch (key)
      {
        case (int)Keys.F1:
          btnF1.BackColor = Color.Green;
          btnF1.ForeColor = SystemColors.HighlightText;
          break;
        case (int)Keys.F2:
          btnF2.BackColor = Color.Green;
          btnF2.ForeColor = SystemColors.HighlightText;
          break;
        case (int)Keys.F3:
          btnF3.BackColor = Color.Green;
          btnF3.ForeColor = SystemColors.HighlightText;
          break;       
        case (int)Keys.F4:
          btnF4.BackColor = Color.Green;
          btnF4.ForeColor = SystemColors.HighlightText;
          break;
        case (int)Keys.F5:
          btnF5.BackColor = Color.Green;
          btnF5.ForeColor = SystemColors.HighlightText;
          break;
        case (int)Keys.F6:
          btnF6.BackColor = Color.Green;
          btnF6.ForeColor = SystemColors.HighlightText;
          break;
        case (int)Keys.F7:
          btnF7.BackColor = Color.Green;
          btnF7.ForeColor = SystemColors.HighlightText;
          break;
        case (int)Keys.F8:
          btnF8.BackColor = Color.Green;
          btnF8.ForeColor = SystemColors.HighlightText;
          break;
        case (int)Keys.F9:
          btnF9.BackColor = Color.Green;
          btnF9.ForeColor = SystemColors.HighlightText;
          break;
        case (int)Keys.F10:
          btnF10.BackColor = Color.Green;
          btnF10.ForeColor = SystemColors.HighlightText;
          break;
        default:
          btnF10.BackColor = Color.Green;
          btnF10.ForeColor = SystemColors.HighlightText;
          break;
      }
    }    

    private void btnBack_Click(object sender, EventArgs e)
    {
      FormState.PreviousPage.Show();
      this.Hide();
      FormState.PreviousPage = this;
    }
  }
}
