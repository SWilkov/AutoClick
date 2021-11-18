namespace AutoClick
{
  partial class Form2
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
      this.lblF = new System.Windows.Forms.Label();
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
      this.grpBoxActions.Text = "actions";
      // 
      // numHours
      // 
      this.numHours.Location = new System.Drawing.Point(82, 71);
      this.numHours.Name = "numHours";
      this.numHours.Size = new System.Drawing.Size(250, 47);
      this.numHours.TabIndex = 12;
      this.numHours.Validating += new System.ComponentModel.CancelEventHandler(this.numHours_Validating);
      // 
      // numMinutes
      // 
      this.numMinutes.Location = new System.Drawing.Point(484, 69);
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
      this.numSeconds.Location = new System.Drawing.Point(904, 75);
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
      this.numMilliseconds.Location = new System.Drawing.Point(484, 206);
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
      this.grpBoxRepeat.Location = new System.Drawing.Point(38, 349);
      this.grpBoxRepeat.Name = "grpBoxRepeat";
      this.grpBoxRepeat.Size = new System.Drawing.Size(500, 250);
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
      // lblF
      // 
      this.lblF.AutoSize = true;
      this.lblF.Location = new System.Drawing.Point(45, 587);
      this.lblF.Name = "lblF";
      this.lblF.Size = new System.Drawing.Size(213, 41);
      this.lblF.TabIndex = 18;
      this.lblF.Text = "pressed key = ";
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1308, 993);
      this.Controls.Add(this.lblF);
      this.Controls.Add(this.grpBoxRepeat);
      this.Controls.Add(this.lblErrorMessage);
      this.Controls.Add(this.numMilliseconds);
      this.Controls.Add(this.numSeconds);
      this.Controls.Add(this.numMinutes);
      this.Controls.Add(this.numHours);
      this.Controls.Add(this.grpBoxActions);
      this.Controls.Add(this.panel1);
      this.KeyPreview = true;
      this.Name = "Form2";
      this.Text = "Form2";
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
    private Label lblF;
  }
}