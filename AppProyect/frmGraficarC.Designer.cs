namespace AppProyect
{
  partial class frmGraficarC
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.btnExit = new System.Windows.Forms.Button();
      this.btnExaminar = new System.Windows.Forms.Button();
      this.chGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
      ((System.ComponentModel.ISupportInitialize)(this.chGrafica)).BeginInit();
      this.SuspendLayout();
      // 
      // btnExit
      // 
      this.btnExit.BackColor = System.Drawing.Color.DarkRed;
      this.btnExit.FlatAppearance.BorderSize = 0;
      this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExit.ForeColor = System.Drawing.Color.White;
      this.btnExit.Location = new System.Drawing.Point(847, 12);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(25, 27);
      this.btnExit.TabIndex = 5;
      this.btnExit.Text = "X";
      this.btnExit.UseVisualStyleBackColor = false;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // btnExaminar
      // 
      this.btnExaminar.BackColor = System.Drawing.Color.DarkRed;
      this.btnExaminar.FlatAppearance.BorderSize = 0;
      this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExaminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExaminar.ForeColor = System.Drawing.Color.White;
      this.btnExaminar.Location = new System.Drawing.Point(362, 220);
      this.btnExaminar.Name = "btnExaminar";
      this.btnExaminar.Size = new System.Drawing.Size(183, 33);
      this.btnExaminar.TabIndex = 4;
      this.btnExaminar.Text = "Examinar";
      this.btnExaminar.UseVisualStyleBackColor = false;
      this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
      // 
      // chGrafica
      // 
      this.chGrafica.BackColor = System.Drawing.Color.Transparent;
      this.chGrafica.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
      this.chGrafica.BorderlineColor = System.Drawing.Color.Transparent;
      chartArea1.Name = "ChartArea1";
      this.chGrafica.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chGrafica.Legends.Add(legend1);
      this.chGrafica.Location = new System.Drawing.Point(179, 42);
      this.chGrafica.Name = "chGrafica";
      this.chGrafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
      series1.ChartArea = "ChartArea1";
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      this.chGrafica.Series.Add(series1);
      this.chGrafica.Size = new System.Drawing.Size(564, 392);
      this.chGrafica.TabIndex = 6;
      this.chGrafica.Text = "chGrafica";
      this.chGrafica.Visible = false;
      // 
      // frmGraficarC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(884, 510);
      this.Controls.Add(this.chGrafica);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnExaminar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmGraficarC";
      this.Text = "frmGraficarC";
      ((System.ComponentModel.ISupportInitialize)(this.chGrafica)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGrafica;
    }
}