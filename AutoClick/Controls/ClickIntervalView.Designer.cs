namespace AutoClick.Controls
{
  partial class ClickIntervalView
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.lblMilliseconds = new System.Windows.Forms.Label();
      this.lblHours = new System.Windows.Forms.Label();
      this.lblSeconds = new System.Windows.Forms.Label();
      this.numHours = new System.Windows.Forms.NumericUpDown();
      this.lblMinutes = new System.Windows.Forms.Label();
      this.numSeconds = new System.Windows.Forms.NumericUpDown();
      this.numMilliseconds = new System.Windows.Forms.NumericUpDown();
      this.numMinutes = new System.Windows.Forms.NumericUpDown();
      this.intervalErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.grpHours = new System.Windows.Forms.GroupBox();
      ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMilliseconds)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.intervalErrorProvider)).BeginInit();
      this.grpHours.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblMilliseconds
      // 
      this.lblMilliseconds.AutoSize = true;
      this.lblMilliseconds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblMilliseconds.Location = new System.Drawing.Point(43, 167);
      this.lblMilliseconds.Name = "lblMilliseconds";
      this.lblMilliseconds.Size = new System.Drawing.Size(194, 41);
      this.lblMilliseconds.TabIndex = 21;
      this.lblMilliseconds.Text = "Milliseconds";
      // 
      // lblHours
      // 
      this.lblHours.AutoSize = true;
      this.lblHours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblHours.Location = new System.Drawing.Point(43, 50);
      this.lblHours.Name = "lblHours";
      this.lblHours.Size = new System.Drawing.Size(102, 41);
      this.lblHours.TabIndex = 18;
      this.lblHours.Text = "Hours";
      // 
      // lblSeconds
      // 
      this.lblSeconds.AutoSize = true;
      this.lblSeconds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblSeconds.Location = new System.Drawing.Point(731, 50);
      this.lblSeconds.Name = "lblSeconds";
      this.lblSeconds.Size = new System.Drawing.Size(133, 41);
      this.lblSeconds.TabIndex = 20;
      this.lblSeconds.Text = "Seconds";
      // 
      // numHours
      // 
      this.numHours.Location = new System.Drawing.Point(43, 94);
      this.numHours.Name = "numHours";
      this.numHours.Size = new System.Drawing.Size(250, 47);
      this.numHours.TabIndex = 12;
      this.numHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.numHours.ValueChanged += new System.EventHandler(this.numHours_ValueChanged);
      // 
      // lblMinutes
      // 
      this.lblMinutes.AutoSize = true;
      this.lblMinutes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblMinutes.Location = new System.Drawing.Point(380, 50);
      this.lblMinutes.Name = "lblMinutes";
      this.lblMinutes.Size = new System.Drawing.Size(133, 41);
      this.lblMinutes.TabIndex = 19;
      this.lblMinutes.Text = "Minutes";
      // 
      // numSeconds
      // 
      this.numSeconds.DecimalPlaces = 2;
      this.numSeconds.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
      this.numSeconds.Location = new System.Drawing.Point(740, 94);
      this.numSeconds.Name = "numSeconds";
      this.numSeconds.Size = new System.Drawing.Size(250, 47);
      this.numSeconds.TabIndex = 14;
      this.numSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.numSeconds.ValueChanged += new System.EventHandler(this.numSeconds_ValueChanged);
      // 
      // numMilliseconds
      // 
      this.numMilliseconds.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.numMilliseconds.Location = new System.Drawing.Point(43, 211);
      this.numMilliseconds.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numMilliseconds.Name = "numMilliseconds";
      this.numMilliseconds.Size = new System.Drawing.Size(250, 47);
      this.numMilliseconds.TabIndex = 15;
      this.numMilliseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.numMilliseconds.ValueChanged += new System.EventHandler(this.numMilliseconds_ValueChanged);
      // 
      // numMinutes
      // 
      this.numMinutes.Location = new System.Drawing.Point(380, 94);
      this.numMinutes.Name = "numMinutes";
      this.numMinutes.Size = new System.Drawing.Size(250, 47);
      this.numMinutes.TabIndex = 13;
      this.numMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.numMinutes.ValueChanged += new System.EventHandler(this.numMinutes_ValueChanged);
      // 
      // intervalErrorProvider
      // 
      this.intervalErrorProvider.ContainerControl = this;
      // 
      // grpHours
      // 
      this.grpHours.Controls.Add(this.numMilliseconds);
      this.grpHours.Controls.Add(this.lblMilliseconds);
      this.grpHours.Controls.Add(this.numSeconds);
      this.grpHours.Controls.Add(this.lblSeconds);
      this.grpHours.Controls.Add(this.numHours);
      this.grpHours.Controls.Add(this.numMinutes);
      this.grpHours.Controls.Add(this.lblHours);
      this.grpHours.Controls.Add(this.lblMinutes);
      this.grpHours.Location = new System.Drawing.Point(64, 30);
      this.grpHours.Name = "grpHours";
      this.grpHours.Size = new System.Drawing.Size(1157, 319);
      this.grpHours.TabIndex = 24;
      this.grpHours.TabStop = false;
      this.grpHours.Text = "Click Interval";
      // 
      // ClickIntervalView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.grpHours);
      this.Name = "ClickIntervalView";
      this.Size = new System.Drawing.Size(1299, 393);
      ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMilliseconds)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.intervalErrorProvider)).EndInit();
      this.grpHours.ResumeLayout(false);
      this.grpHours.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private Label lblMilliseconds;
    private Label lblHours;
    private Label lblSeconds;
    private NumericUpDown numHours;
    private Label lblMinutes;
    private NumericUpDown numSeconds;
    private NumericUpDown numMilliseconds;
    private NumericUpDown numMinutes;
    private ErrorProvider intervalErrorProvider;
    private GroupBox grpHours;
  }
}
