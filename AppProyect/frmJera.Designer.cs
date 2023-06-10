namespace AppProyect
{
  partial class frmJera
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
      this.btnExit = new System.Windows.Forms.Button();
      this.btnExaminar = new System.Windows.Forms.Button();
      this.tvJerarquia = new System.Windows.Forms.TreeView();
      this.SuspendLayout();
      // 
      // btnExit
      // 
      this.btnExit.BackColor = System.Drawing.Color.DarkRed;
      this.btnExit.FlatAppearance.BorderSize = 0;
      this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExit.ForeColor = System.Drawing.Color.White;
      this.btnExit.Location = new System.Drawing.Point(847, 22);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(25, 27);
      this.btnExit.TabIndex = 8;
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
      this.btnExaminar.Location = new System.Drawing.Point(350, 190);
      this.btnExaminar.Name = "btnExaminar";
      this.btnExaminar.Size = new System.Drawing.Size(183, 33);
      this.btnExaminar.TabIndex = 7;
      this.btnExaminar.Text = "Examinar";
      this.btnExaminar.UseVisualStyleBackColor = false;
      this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
      // 
      // tvJerarquia
      // 
      this.tvJerarquia.BackColor = System.Drawing.Color.Black;
      this.tvJerarquia.ForeColor = System.Drawing.Color.White;
      this.tvJerarquia.Location = new System.Drawing.Point(287, 12);
      this.tvJerarquia.Name = "tvJerarquia";
      this.tvJerarquia.Size = new System.Drawing.Size(279, 476);
      this.tvJerarquia.TabIndex = 11;
      this.tvJerarquia.Visible = false;
      // 
      // frmJera
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(884, 510);
      this.Controls.Add(this.tvJerarquia);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnExaminar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmJera";
      this.Text = "Jera";
      this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExaminar;
    private System.Windows.Forms.TreeView tvJerarquia;
  }
}