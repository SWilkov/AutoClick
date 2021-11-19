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
      this.btnStart = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblYLocation = new System.Windows.Forms.Label();
      this.lblXLocation = new System.Windows.Forms.Label();
      this.numY = new System.Windows.Forms.NumericUpDown();
      this.numX = new System.Windows.Forms.NumericUpDown();
      this.chkCurrentLocation = new System.Windows.Forms.CheckBox();
      this.grpBoxActions = new System.Windows.Forms.GroupBox();
      this.numHours = new System.Windows.Forms.NumericUpDown();
      this.numMinutes = new System.Windows.Forms.NumericUpDown();
      this.numSeconds = new System.Windows.Forms.NumericUpDown();
      this.numMilliseconds = new System.Windows.Forms.NumericUpDown();
      this.lblErrorMessage = new System.Windows.Forms.Label();
      this.grpBoxRepeat = new System.Windows.Forms.GroupBox();
      this.numRepeats = new System.Windows.Forms.NumericUpDown();
      this.lblHours = new System.Windows.Forms.Label();
      this.lblMinutes = new System.Windows.Forms.Label();
      this.lblSeconds = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lblIntervalHelp = new System.Windows.Forms.Label();
      this.lblMilliseconds = new System.Windows.Forms.Label();
      this.grpBoxStats = new System.Windows.Forms.GroupBox();
      this.btnResetStats = new System.Windows.Forms.Button();
      this.lblTotalClicks = new System.Windows.Forms.Label();
      this.lblTotalClicksName = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
      this.grpBoxActions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMilliseconds)).BeginInit();
      this.grpBoxRepeat.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numRepeats)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.grpBoxStats.SuspendLayout();
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
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // btnStop
      // 
      this.btnStop.BackColor = System.Drawing.Color.Red;
      this.btnStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.btnStop.Location = new System.Drawing.Point(581, 78);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(250, 120);
      this.btnStop.TabIndex = 5;
      this.btnStop.Text = "Stop";
      this.btnStop.UseVisualStyleBackColor = false;
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.lblYLocation);
      this.panel1.Controls.Add(this.lblXLocation);
      this.panel1.Controls.Add(this.numY);
      this.panel1.Controls.Add(this.numX);
      this.panel1.Controls.Add(this.chkCurrentLocation);
      this.panel1.Location = new System.Drawing.Point(623, 358);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(633, 252);
      this.panel1.TabIndex = 10;
      // 
      // lblYLocation
      // 
      this.lblYLocation.AutoSize = true;
      this.lblYLocation.Location = new System.Drawing.Point(363, 110);
      this.lblYLocation.Name = "lblYLocation";
      this.lblYLocation.Size = new System.Drawing.Size(35, 41);
      this.lblYLocation.TabIndex = 4;
      this.lblYLocation.Text = "Y";
      // 
      // lblXLocation
      // 
      this.lblXLocation.AutoSize = true;
      this.lblXLocation.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.lblXLocation.Location = new System.Drawing.Point(42, 111);
      this.lblXLocation.Name = "lblXLocation";
      this.lblXLocation.Size = new System.Drawing.Size(36, 41);
      this.lblXLocation.TabIndex = 3;
      this.lblXLocation.Text = "X";
      // 
      // numY
      // 
      this.numY.Location = new System.Drawing.Point(362, 165);
      this.numY.Name = "numY";
      this.numY.Size = new System.Drawing.Size(140, 47);
      this.numY.TabIndex = 2;
      this.numY.ValueChanged += new System.EventHandler(this.numY_ValueChanged);
      // 
      // numX
      // 
      this.numX.Location = new System.Drawing.Point(41, 161);
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
      this.chkCurrentLocation.Location = new System.Drawing.Point(17, 24);
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
      // numHours
      // 
      this.numHours.Location = new System.Drawing.Point(53, 99);
      this.numHours.Name = "numHours";
      this.numHours.Size = new System.Drawing.Size(250, 47);
      this.numHours.TabIndex = 12;
      this.numHours.Validating += new System.ComponentModel.CancelEventHandler(this.numHours_Validating);
      // 
      // numMinutes
      // 
      this.numMinutes.Location = new System.Drawing.Point(414, 97);
      this.numMinutes.Name = "numMinutes";
      this.numMinutes.Size = new System.Drawing.Size(300, 47);
      this.numMinutes.TabIndex = 13;
      this.numMinutes.Validating += new System.ComponentModel.CancelEventHandler(this.numMinutes_Validating);
      // 
      // numSeconds
      // 
      this.numSeconds.DecimalPlaces = 2;
      this.numSeconds.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
      this.numSeconds.Location = new System.Drawing.Point(791, 97);
      this.numSeconds.Name = "numSeconds";
      this.numSeconds.Size = new System.Drawing.Size(300, 47);
      this.numSeconds.TabIndex = 14;
      this.numSeconds.Validating += new System.ComponentModel.CancelEventHandler(this.numSeconds_Validating);
      // 
      // numMilliseconds
      // 
      this.numMilliseconds.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.numMilliseconds.Location = new System.Drawing.Point(53, 217);
      this.numMilliseconds.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numMilliseconds.Name = "numMilliseconds";
      this.numMilliseconds.Size = new System.Drawing.Size(300, 47);
      this.numMilliseconds.TabIndex = 15;
      this.numMilliseconds.Validating += new System.ComponentModel.CancelEventHandler(this.numMilliseconds_Validating);
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
      // grpBoxRepeat
      // 
      this.grpBoxRepeat.Controls.Add(this.numRepeats);
      this.grpBoxRepeat.Location = new System.Drawing.Point(38, 372);
      this.grpBoxRepeat.Name = "grpBoxRepeat";
      this.grpBoxRepeat.Size = new System.Drawing.Size(500, 227);
      this.grpBoxRepeat.TabIndex = 17;
      this.grpBoxRepeat.TabStop = false;
      this.grpBoxRepeat.Text = "Repeats";
      // 
      // numRepeats
      // 
      this.numRepeats.Location = new System.Drawing.Point(57, 119);
      this.numRepeats.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numRepeats.Name = "numRepeats";
      this.numRepeats.Size = new System.Drawing.Size(300, 47);
      this.numRepeats.TabIndex = 0;
      // 
      // lblHours
      // 
      this.lblHours.AutoSize = true;
      this.lblHours.Location = new System.Drawing.Point(53, 55);
      this.lblHours.Name = "lblHours";
      this.lblHours.Size = new System.Drawing.Size(97, 41);
      this.lblHours.TabIndex = 18;
      this.lblHours.Text = "Hours";
      // 
      // lblMinutes
      // 
      this.lblMinutes.AutoSize = true;
      this.lblMinutes.Location = new System.Drawing.Point(403, 43);
      this.lblMinutes.Name = "lblMinutes";
      this.lblMinutes.Size = new System.Drawing.Size(125, 41);
      this.lblMinutes.TabIndex = 19;
      this.lblMinutes.Text = "Minutes";
      // 
      // lblSeconds
      // 
      this.lblSeconds.AutoSize = true;
      this.lblSeconds.Location = new System.Drawing.Point(782, 43);
      this.lblSeconds.Name = "lblSeconds";
      this.lblSeconds.Size = new System.Drawing.Size(130, 41);
      this.lblSeconds.TabIndex = 20;
      this.lblSeconds.Text = "Seconds";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lblIntervalHelp);
      this.groupBox1.Controls.Add(this.lblMilliseconds);
      this.groupBox1.Controls.Add(this.lblHours);
      this.groupBox1.Controls.Add(this.lblSeconds);
      this.groupBox1.Controls.Add(this.numHours);
      this.groupBox1.Controls.Add(this.lblMinutes);
      this.groupBox1.Controls.Add(this.numSeconds);
      this.groupBox1.Controls.Add(this.numMilliseconds);
      this.groupBox1.Controls.Add(this.numMinutes);
      this.groupBox1.Location = new System.Drawing.Point(49, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1209, 312);
      this.groupBox1.TabIndex = 21;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Click Interval";
      // 
      // lblIntervalHelp
      // 
      this.lblIntervalHelp.AutoSize = true;
      this.lblIntervalHelp.Location = new System.Drawing.Point(407, 184);
      this.lblIntervalHelp.Name = "lblIntervalHelp";
      this.lblIntervalHelp.Size = new System.Drawing.Size(97, 41);
      this.lblIntervalHelp.TabIndex = 22;
      this.lblIntervalHelp.Text = "label1";
      // 
      // lblMilliseconds
      // 
      this.lblMilliseconds.AutoSize = true;
      this.lblMilliseconds.Location = new System.Drawing.Point(53, 165);
      this.lblMilliseconds.Name = "lblMilliseconds";
      this.lblMilliseconds.Size = new System.Drawing.Size(182, 41);
      this.lblMilliseconds.TabIndex = 21;
      this.lblMilliseconds.Text = "Milliseconds";
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
      // formAutoClick
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1308, 1190);
      this.Controls.Add(this.grpBoxStats);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.grpBoxRepeat);
      this.Controls.Add(this.lblErrorMessage);
      this.Controls.Add(this.grpBoxActions);
      this.Controls.Add(this.panel1);
      this.KeyPreview = true;
      this.Name = "formAutoClick";
      this.Text = "Auto Clicker";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
      this.grpBoxActions.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMilliseconds)).EndInit();
      this.grpBoxRepeat.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numRepeats)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.grpBoxStats.ResumeLayout(false);
      this.grpBoxStats.PerformLayout();
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
    private Panel panel1;
    private GroupBox grpBoxActions;
    private Label lblYLocation;
    private Label lblXLocation;
    private NumericUpDown numY;
    private NumericUpDown numX;
    private CheckBox chkCurrentLocation;
    private NumericUpDown numMilliseconds;
    private NumericUpDown numSeconds;
    private NumericUpDown numMinutes;
    private NumericUpDown numHours;
    private Label lblErrorMessage;
    private GroupBox grpBoxRepeat;
    private NumericUpDown numRepeats;
    private Label lblHours;
    private Label lblMinutes;
    private Label lblSeconds;
    private GroupBox groupBox1;
    private Label lblIntervalHelp;
    private Label lblMilliseconds;
    private GroupBox grpBoxStats;
    private Button btnResetStats;
    private Label lblTotalClicks;
    private Label lblTotalClicksName;
  }
}