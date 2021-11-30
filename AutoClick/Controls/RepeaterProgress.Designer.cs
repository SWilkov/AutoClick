namespace AutoClick.Controls
{
  partial class RepeaterProgress
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
      this.repeaterProgressBar = new System.Windows.Forms.ProgressBar();
      this.SuspendLayout();
      // 
      // repeaterProgressBar
      // 
      this.repeaterProgressBar.Location = new System.Drawing.Point(67, 45);
      this.repeaterProgressBar.Minimum = 1;
      this.repeaterProgressBar.Name = "repeaterProgressBar";
      this.repeaterProgressBar.Size = new System.Drawing.Size(612, 58);
      this.repeaterProgressBar.Step = 1;
      this.repeaterProgressBar.TabIndex = 0;
      this.repeaterProgressBar.Value = 1;
      // 
      // RepeaterProgress
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.repeaterProgressBar);
      this.Name = "RepeaterProgress";
      this.Size = new System.Drawing.Size(753, 150);
      this.ResumeLayout(false);

    }

    #endregion

    private ProgressBar repeaterProgressBar;
  }
}
