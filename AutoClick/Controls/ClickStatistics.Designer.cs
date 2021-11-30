namespace AutoClick.Controls
{
  partial class ClickStatistics
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
      this.grpBoxStats = new System.Windows.Forms.GroupBox();
      this.btnResetStats = new System.Windows.Forms.Button();
      this.lblTotalClicks = new System.Windows.Forms.Label();
      this.lblTotalClicksName = new System.Windows.Forms.Label();
      this.grpBoxStats.SuspendLayout();
      this.SuspendLayout();
      // 
      // grpBoxStats
      // 
      this.grpBoxStats.Controls.Add(this.btnResetStats);
      this.grpBoxStats.Controls.Add(this.lblTotalClicks);
      this.grpBoxStats.Controls.Add(this.lblTotalClicksName);
      this.grpBoxStats.Location = new System.Drawing.Point(77, 44);
      this.grpBoxStats.Name = "grpBoxStats";
      this.grpBoxStats.Size = new System.Drawing.Size(869, 192);
      this.grpBoxStats.TabIndex = 23;
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
      // ClickStatistics
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.grpBoxStats);
      this.Name = "ClickStatistics";
      this.Size = new System.Drawing.Size(1048, 314);
      this.grpBoxStats.ResumeLayout(false);
      this.grpBoxStats.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private GroupBox grpBoxStats;
    private Button btnResetStats;
    private Label lblTotalClicks;
    private Label lblTotalClicksName;
  }
}
