namespace AutoClick.Controls
{
  partial class RepeaterView
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
      this.btnRepeat = new System.Windows.Forms.RadioButton();
      this.btnContinous = new System.Windows.Forms.RadioButton();
      this.numRepeats = new System.Windows.Forms.NumericUpDown();
      this.grpRepeater = new System.Windows.Forms.GroupBox();
      ((System.ComponentModel.ISupportInitialize)(this.numRepeats)).BeginInit();
      this.grpRepeater.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnRepeat
      // 
      this.btnRepeat.AutoSize = true;
      this.btnRepeat.Checked = true;
      this.btnRepeat.Location = new System.Drawing.Point(23, 56);
      this.btnRepeat.Name = "btnRepeat";
      this.btnRepeat.Size = new System.Drawing.Size(147, 45);
      this.btnRepeat.TabIndex = 0;
      this.btnRepeat.TabStop = true;
      this.btnRepeat.Text = "Repeat";
      this.btnRepeat.UseVisualStyleBackColor = true;
      this.btnRepeat.CheckedChanged += new System.EventHandler(this.btnRepeat_CheckedChanged);
      // 
      // btnContinous
      // 
      this.btnContinous.AutoSize = true;
      this.btnContinous.Location = new System.Drawing.Point(23, 107);
      this.btnContinous.Name = "btnContinous";
      this.btnContinous.Size = new System.Drawing.Size(208, 45);
      this.btnContinous.TabIndex = 1;
      this.btnContinous.Text = "Continuous";
      this.btnContinous.UseVisualStyleBackColor = true;
      // 
      // numRepeats
      // 
      this.numRepeats.Location = new System.Drawing.Point(279, 78);
      this.numRepeats.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numRepeats.Name = "numRepeats";
      this.numRepeats.Size = new System.Drawing.Size(300, 47);
      this.numRepeats.TabIndex = 2;
      this.numRepeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // grpRepeater
      // 
      this.grpRepeater.Controls.Add(this.btnRepeat);
      this.grpRepeater.Controls.Add(this.btnContinous);
      this.grpRepeater.Location = new System.Drawing.Point(20, 24);
      this.grpRepeater.Name = "grpRepeater";
      this.grpRepeater.Size = new System.Drawing.Size(239, 214);
      this.grpRepeater.TabIndex = 3;
      this.grpRepeater.TabStop = false;
      // 
      // RepeaterView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.grpRepeater);
      this.Controls.Add(this.numRepeats);
      this.Name = "RepeaterView";
      this.Size = new System.Drawing.Size(613, 275);
      ((System.ComponentModel.ISupportInitialize)(this.numRepeats)).EndInit();
      this.grpRepeater.ResumeLayout(false);
      this.grpRepeater.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private RadioButton btnRepeat;
    private RadioButton btnContinous;
    private NumericUpDown numRepeats;
    private GroupBox grpRepeater;
  }
}
