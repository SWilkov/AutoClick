namespace AutoClick
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lblIntervalHelp = new System.Windows.Forms.Label();
      this.lblMilliseconds = new System.Windows.Forms.Label();
      this.lblHours = new System.Windows.Forms.Label();
      this.lblSeconds = new System.Windows.Forms.Label();
      this.numHours = new System.Windows.Forms.NumericUpDown();
      this.lblMinutes = new System.Windows.Forms.Label();
      this.numSeconds = new System.Windows.Forms.NumericUpDown();
      this.numMilliseconds = new System.Windows.Forms.NumericUpDown();
      this.numMinutes = new System.Windows.Forms.NumericUpDown();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMilliseconds)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
      this.SuspendLayout();
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
      this.groupBox1.Location = new System.Drawing.Point(96, 32);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1101, 335);
      this.groupBox1.TabIndex = 22;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Click Interval";
      // 
      // lblIntervalHelp
      // 
      this.lblIntervalHelp.AutoSize = true;
      this.lblIntervalHelp.Location = new System.Drawing.Point(407, 184);
      this.lblIntervalHelp.MaximumSize = new System.Drawing.Size(500, 100);
      this.lblIntervalHelp.Name = "lblIntervalHelp";
      this.lblIntervalHelp.Size = new System.Drawing.Size(97, 41);
      this.lblIntervalHelp.TabIndex = 22;
      this.lblIntervalHelp.Text = "label1";
      // 
      // lblMilliseconds
      // 
      this.lblMilliseconds.AutoSize = true;
      this.lblMilliseconds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblMilliseconds.Location = new System.Drawing.Point(53, 173);
      this.lblMilliseconds.Name = "lblMilliseconds";
      this.lblMilliseconds.Size = new System.Drawing.Size(194, 41);
      this.lblMilliseconds.TabIndex = 21;
      this.lblMilliseconds.Text = "Milliseconds";
      // 
      // lblHours
      // 
      this.lblHours.AutoSize = true;
      this.lblHours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblHours.Location = new System.Drawing.Point(53, 55);
      this.lblHours.Name = "lblHours";
      this.lblHours.Size = new System.Drawing.Size(102, 41);
      this.lblHours.TabIndex = 18;
      this.lblHours.Text = "Hours";
      // 
      // lblSeconds
      // 
      this.lblSeconds.AutoSize = true;
      this.lblSeconds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblSeconds.Location = new System.Drawing.Point(741, 55);
      this.lblSeconds.Name = "lblSeconds";
      this.lblSeconds.Size = new System.Drawing.Size(133, 41);
      this.lblSeconds.TabIndex = 20;
      this.lblSeconds.Text = "Seconds";
      // 
      // numHours
      // 
      this.numHours.Location = new System.Drawing.Point(53, 99);
      this.numHours.Name = "numHours";
      this.numHours.Size = new System.Drawing.Size(250, 47);
      this.numHours.TabIndex = 12;
      // 
      // lblMinutes
      // 
      this.lblMinutes.AutoSize = true;
      this.lblMinutes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblMinutes.Location = new System.Drawing.Point(390, 55);
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
      this.numSeconds.Location = new System.Drawing.Point(750, 99);
      this.numSeconds.Name = "numSeconds";
      this.numSeconds.Size = new System.Drawing.Size(250, 47);
      this.numSeconds.TabIndex = 14;
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
      this.numMilliseconds.Size = new System.Drawing.Size(250, 47);
      this.numMilliseconds.TabIndex = 15;
      // 
      // numMinutes
      // 
      this.numMinutes.Location = new System.Drawing.Point(390, 99);
      this.numMinutes.Name = "numMinutes";
      this.numMinutes.Size = new System.Drawing.Size(250, 47);
      this.numMinutes.TabIndex = 13;
      // 
      // ClickIntervalView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBox1);
      this.Name = "ClickIntervalView";
      this.Size = new System.Drawing.Size(1299, 470);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMilliseconds)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private GroupBox groupBox1;
    private Label lblIntervalHelp;
    private Label lblMilliseconds;
    private Label lblHours;
    private Label lblSeconds;
    private NumericUpDown numHours;
    private Label lblMinutes;
    private NumericUpDown numSeconds;
    private NumericUpDown numMilliseconds;
    private NumericUpDown numMinutes;
  }
}
