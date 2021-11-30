namespace AutoClick
{
  partial class formAutoClick
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      AC.Framework.Models.Time time2 = new AC.Framework.Models.Time();
      AC.Framework.Models.Repeater repeater2 = new AC.Framework.Models.Repeater();
      this.btnStart = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.lblYLocation = new System.Windows.Forms.Label();
      this.lblXLocation = new System.Windows.Forms.Label();
      this.numY = new System.Windows.Forms.NumericUpDown();
      this.numX = new System.Windows.Forms.NumericUpDown();
      this.chkCurrentLocation = new System.Windows.Forms.CheckBox();
      this.grpBoxActions = new System.Windows.Forms.GroupBox();
      this.lblErrorMessage = new System.Windows.Forms.Label();
      this.grpBoxStats = new System.Windows.Forms.GroupBox();
      this.btnResetStats = new System.Windows.Forms.Button();
      this.lblTotalClicks = new System.Windows.Forms.Label();
      this.lblTotalClicksName = new System.Windows.Forms.Label();
      this.grpBoxLocation = new System.Windows.Forms.GroupBox();
      this.clickIntervalViewForRepeat = new AutoClick.Controls.ClickIntervalView();
      this.btnHotKey = new System.Windows.Forms.Button();
      this.repeaterView1 = new AutoClick.Controls.RepeaterView();
      ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
      this.grpBoxActions.SuspendLayout();
      this.grpBoxStats.SuspendLayout();
      this.grpBoxLocation.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnStart
      // 
      this.btnStart.BackColor = System.Drawing.Color.SpringGreen;
      this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnStart.Location = new System.Drawing.Point(16, 79);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(250, 120);
      this.btnStart.TabIndex = 4;
      this.btnStart.Text = "Start";
      this.btnStart.UseVisualStyleBackColor = false;
      this.btnStart.EnabledChanged += new System.EventHandler(this.btnStart_EnabledChanged);
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // btnStop
      // 
      this.btnStop.BackColor = System.Drawing.Color.DarkGray;
      this.btnStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.btnStop.Location = new System.Drawing.Point(581, 51);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(250, 150);
      this.btnStop.TabIndex = 5;
      this.btnStop.Text = "Stop   Ctrl + F12";
      this.btnStop.UseVisualStyleBackColor = false;
      this.btnStop.EnabledChanged += new System.EventHandler(this.btnStop_EnabledChanged);
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // lblYLocation
      // 
      this.lblYLocation.AutoSize = true;
      this.lblYLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblYLocation.Location = new System.Drawing.Point(236, 144);
      this.lblYLocation.Name = "lblYLocation";
      this.lblYLocation.Size = new System.Drawing.Size(36, 41);
      this.lblYLocation.TabIndex = 4;
      this.lblYLocation.Text = "Y";
      // 
      // lblXLocation
      // 
      this.lblXLocation.AutoSize = true;
      this.lblXLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblXLocation.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.lblXLocation.Location = new System.Drawing.Point(50, 144);
      this.lblXLocation.Name = "lblXLocation";
      this.lblXLocation.Size = new System.Drawing.Size(38, 41);
      this.lblXLocation.TabIndex = 3;
      this.lblXLocation.Text = "X";
      // 
      // numY
      // 
      this.numY.Location = new System.Drawing.Point(236, 188);
      this.numY.Name = "numY";
      this.numY.Size = new System.Drawing.Size(140, 47);
      this.numY.TabIndex = 2;
      this.numY.ValueChanged += new System.EventHandler(this.numY_ValueChanged);
      // 
      // numX
      // 
      this.numX.Location = new System.Drawing.Point(50, 188);
      this.numX.Name = "numX";
      this.numX.Size = new System.Drawing.Size(140, 47);
      this.numX.TabIndex = 1;
      this.numX.ValueChanged += new System.EventHandler(this.numX_ValueChanged);
      // 
      // chkCurrentLocation
      // 
      this.chkCurrentLocation.AutoSize = true;
      this.chkCurrentLocation.Checked = true;
      this.chkCurrentLocation.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkCurrentLocation.Location = new System.Drawing.Point(50, 55);
      this.chkCurrentLocation.Name = "chkCurrentLocation";
      this.chkCurrentLocation.Size = new System.Drawing.Size(318, 45);
      this.chkCurrentLocation.TabIndex = 0;
      this.chkCurrentLocation.Text = "use current location";
      this.chkCurrentLocation.UseVisualStyleBackColor = true;
      // 
      // grpBoxActions
      // 
      this.grpBoxActions.Controls.Add(this.btnStart);
      this.grpBoxActions.Controls.Add(this.btnStop);
      this.grpBoxActions.Font = new System.Drawing.Font("Segoe UI Semibold", 9.900001F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
      this.grpBoxActions.Location = new System.Drawing.Point(182, 689);
      this.grpBoxActions.Name = "grpBoxActions";
      this.grpBoxActions.Size = new System.Drawing.Size(866, 250);
      this.grpBoxActions.TabIndex = 11;
      this.grpBoxActions.TabStop = false;
      // 
      // lblErrorMessage
      // 
      this.lblErrorMessage.AutoSize = true;
      this.lblErrorMessage.ForeColor = System.Drawing.Color.Maroon;
      this.lblErrorMessage.Location = new System.Drawing.Point(102, 722);
      this.lblErrorMessage.Name = "lblErrorMessage";
      this.lblErrorMessage.Size = new System.Drawing.Size(0, 41);
      this.lblErrorMessage.TabIndex = 16;
      // 
      // grpBoxStats
      // 
      this.grpBoxStats.Controls.Add(this.btnResetStats);
      this.grpBoxStats.Controls.Add(this.lblTotalClicks);
      this.grpBoxStats.Controls.Add(this.lblTotalClicksName);
      this.grpBoxStats.Location = new System.Drawing.Point(179, 955);
      this.grpBoxStats.Name = "grpBoxStats";
      this.grpBoxStats.Size = new System.Drawing.Size(869, 192);
      this.grpBoxStats.TabIndex = 22;
      this.grpBoxStats.TabStop = false;
      this.grpBoxStats.Text = "stats";
      // 
      // btnResetStats
      // 
      this.btnResetStats.Location = new System.Drawing.Point(556, 81);
      this.btnResetStats.Name = "btnResetStats";
      this.btnResetStats.Size = new System.Drawing.Size(188, 58);
      this.btnResetStats.TabIndex = 2;
      this.btnResetStats.Text = "Reset";
      this.btnResetStats.UseVisualStyleBackColor = true;
      this.btnResetStats.Click += new System.EventHandler(this.btnResetStats_Click);
      // 
      // lblTotalClicks
      // 
      this.lblTotalClicks.AutoSize = true;
      this.lblTotalClicks.ForeColor = System.Drawing.Color.RoyalBlue;
      this.lblTotalClicks.Location = new System.Drawing.Point(273, 92);
      this.lblTotalClicks.Name = "lblTotalClicks";
      this.lblTotalClicks.Size = new System.Drawing.Size(97, 41);
      this.lblTotalClicks.TabIndex = 1;
      this.lblTotalClicks.Text = "label2";
      // 
      // lblTotalClicksName
      // 
      this.lblTotalClicksName.AutoSize = true;
      this.lblTotalClicksName.Location = new System.Drawing.Point(84, 92);
      this.lblTotalClicksName.Name = "lblTotalClicksName";
      this.lblTotalClicksName.Size = new System.Drawing.Size(159, 41);
      this.lblTotalClicksName.TabIndex = 0;
      this.lblTotalClicksName.Text = "click count";
      // 
      // grpBoxLocation
      // 
      this.grpBoxLocation.Controls.Add(this.numX);
      this.grpBoxLocation.Controls.Add(this.numY);
      this.grpBoxLocation.Controls.Add(this.lblYLocation);
      this.grpBoxLocation.Controls.Add(this.chkCurrentLocation);
      this.grpBoxLocation.Controls.Add(this.lblXLocation);
      this.grpBoxLocation.Location = new System.Drawing.Point(673, 372);
      this.grpBoxLocation.Name = "grpBoxLocation";
      this.grpBoxLocation.Size = new System.Drawing.Size(500, 250);
      this.grpBoxLocation.TabIndex = 23;
      this.grpBoxLocation.TabStop = false;
      this.grpBoxLocation.Text = "Location";
      // 
      // clickIntervalViewForRepeat
      // 
      time2.Hours = new decimal(new int[] {
            0,
            0,
            0,
            0});
      time2.Milliseconds = new decimal(new int[] {
            0,
            0,
            0,
            0});
      time2.Minutes = new decimal(new int[] {
            0,
            0,
            0,
            0});
      time2.Seconds = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.clickIntervalViewForRepeat.IntervalTime = time2;
      this.clickIntervalViewForRepeat.Location = new System.Drawing.Point(12, -4);
      this.clickIntervalViewForRepeat.Name = "clickIntervalViewForRepeat";
      this.clickIntervalViewForRepeat.Size = new System.Drawing.Size(1226, 389);
      this.clickIntervalViewForRepeat.TabIndex = 24;
      // 
      // btnHotKey
      // 
      this.btnHotKey.Location = new System.Drawing.Point(1054, 851);
      this.btnHotKey.Name = "btnHotKey";
      this.btnHotKey.Size = new System.Drawing.Size(217, 88);
      this.btnHotKey.TabIndex = 24;
      this.btnHotKey.Text = "Set Stop Key";
      this.btnHotKey.UseVisualStyleBackColor = true;
      this.btnHotKey.Click += new System.EventHandler(this.btnHotKey_Click);
      // 
      // repeaterView1
      // 
      this.repeaterView1.Location = new System.Drawing.Point(12, 372);
      this.repeaterView1.Name = "repeaterView1";
      repeater2.Repeats = true;
      repeater2.RepeatsFor = 100;
      this.repeaterView1.Repeater = repeater2;
      this.repeaterView1.Size = new System.Drawing.Size(630, 250);
      this.repeaterView1.TabIndex = 25;
      // 
      // formAutoClick
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1308, 1190);
      this.Controls.Add(this.repeaterView1);
      this.Controls.Add(this.clickIntervalViewForRepeat);
      this.Controls.Add(this.btnHotKey);
      this.Controls.Add(this.grpBoxLocation);
      this.Controls.Add(this.grpBoxStats);
      this.Controls.Add(this.lblErrorMessage);
      this.Controls.Add(this.grpBoxActions);
      this.KeyPreview = true;
      this.Name = "formAutoClick";
      this.Text = "Auto Clicker";
      ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
      this.grpBoxActions.ResumeLayout(false);
      this.grpBoxStats.ResumeLayout(false);
      this.grpBoxStats.PerformLayout();
      this.grpBoxLocation.ResumeLayout(false);
      this.grpBoxLocation.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TextBox txtHours;
    private TextBox txtMinutes;
    private TextBox txtSeconds;
    private TextBox txtMilliseconds;
    private Button btnStart;
    private Button btnStop;
    private ContextMenuStrip contextMenuStrip1;
    private GroupBox grpBoxActions;
    private Label lblYLocation;
    private Label lblXLocation;
    private NumericUpDown numY;
    private NumericUpDown numX;
    private CheckBox chkCurrentLocation;
    private Label lblErrorMessage;
    private GroupBox grpBoxStats;
    private Button btnResetStats;
    private Label lblTotalClicks;
    private Label lblTotalClicksName;
    private GroupBox grpBoxLocation;
    private Controls.ClickIntervalView clickIntervalViewForRepeat;
    private Button btnHotKey;
    private Controls.RepeaterView repeaterView1;
  }
}