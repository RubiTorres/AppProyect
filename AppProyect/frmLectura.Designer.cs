namespace AppProyect
{
  partial class frmLectura
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
      this.btnExportar = new System.Windows.Forms.Button();
      this.lstvDatos = new System.Windows.Forms.ListView();
      this.btnExit = new System.Windows.Forms.Button();
      this.btnExaminar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnExportar
      // 
      this.btnExportar.BackColor = System.Drawing.Color.DarkRed;
      this.btnExportar.FlatAppearance.BorderSize = 0;
      this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExportar.ForeColor = System.Drawing.Color.White;
      this.btnExportar.Location = new System.Drawing.Point(12, 12);
      this.btnExportar.Name = "btnExportar";
      this.btnExportar.Size = new System.Drawing.Size(86, 26);
      this.btnExportar.TabIndex = 11;
      this.btnExportar.Text = "Guardar";
      this.btnExportar.UseVisualStyleBackColor = false;
      this.btnExportar.Visible = false;
      this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
      // 
      // lstvDatos
      // 
      this.lstvDatos.BackColor = System.Drawing.Color.Black;
      this.lstvDatos.ForeColor = System.Drawing.Color.White;
      this.lstvDatos.HideSelection = false;
      this.lstvDatos.Location = new System.Drawing.Point(90, 55);
      this.lstvDatos.Name = "lstvDatos";
      this.lstvDatos.Size = new System.Drawing.Size(745, 404);
      this.lstvDatos.TabIndex = 10;
      this.lstvDatos.UseCompatibleStateImageBehavior = false;
      this.lstvDatos.Visible = false;
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
      this.btnExit.TabIndex = 9;
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
      this.btnExaminar.Location = new System.Drawing.Point(398, 162);
      this.btnExaminar.Name = "btnExaminar";
      this.btnExaminar.Size = new System.Drawing.Size(183, 33);
      this.btnExaminar.TabIndex = 8;
      this.btnExaminar.Text = "Examinar";
      this.btnExaminar.UseVisualStyleBackColor = false;
      this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
      // 
      // frmLectura
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(884, 510);
      this.Controls.Add(this.btnExportar);
      this.Controls.Add(this.lstvDatos);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnExaminar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmLectura";
      this.Text = "frmLectura";
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.ListView lstvDatos;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExaminar;
    }
}