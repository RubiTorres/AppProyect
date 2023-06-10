namespace AppProyect
{
  partial class frmBanxico
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
      this.fechaFinal = new System.Windows.Forms.DateTimePicker();
      this.FechaInicial = new System.Windows.Forms.DateTimePicker();
      this.txtData = new System.Windows.Forms.RichTextBox();
      this.txtTitle = new System.Windows.Forms.TextBox();
      this.btnDatos = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnExit
      // 
      this.btnExit.BackColor = System.Drawing.Color.DarkRed;
      this.btnExit.FlatAppearance.BorderSize = 0;
      this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExit.ForeColor = System.Drawing.Color.White;
      this.btnExit.Location = new System.Drawing.Point(840, 34);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(25, 27);
      this.btnExit.TabIndex = 14;
      this.btnExit.Text = "X";
      this.btnExit.UseVisualStyleBackColor = false;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // fechaFinal
      // 
      this.fechaFinal.Location = new System.Drawing.Point(20, 87);
      this.fechaFinal.Name = "fechaFinal";
      this.fechaFinal.Size = new System.Drawing.Size(200, 20);
      this.fechaFinal.TabIndex = 13;
      // 
      // FechaInicial
      // 
      this.FechaInicial.Location = new System.Drawing.Point(20, 59);
      this.FechaInicial.Name = "FechaInicial";
      this.FechaInicial.Size = new System.Drawing.Size(200, 20);
      this.FechaInicial.TabIndex = 12;
      // 
      // txtData
      // 
      this.txtData.BackColor = System.Drawing.Color.Black;
      this.txtData.ForeColor = System.Drawing.Color.White;
      this.txtData.Location = new System.Drawing.Point(239, 87);
      this.txtData.Name = "txtData";
      this.txtData.Size = new System.Drawing.Size(626, 390);
      this.txtData.TabIndex = 11;
      this.txtData.Text = "";
      this.txtData.Visible = false;
      // 
      // txtTitle
      // 
      this.txtTitle.BackColor = System.Drawing.Color.Black;
      this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTitle.ForeColor = System.Drawing.Color.Red;
      this.txtTitle.Location = new System.Drawing.Point(92, 34);
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.Size = new System.Drawing.Size(698, 19);
      this.txtTitle.TabIndex = 10;
      this.txtTitle.Visible = false;
      // 
      // btnDatos
      // 
      this.btnDatos.BackColor = System.Drawing.Color.DarkRed;
      this.btnDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      this.btnDatos.Location = new System.Drawing.Point(49, 123);
      this.btnDatos.Name = "btnDatos";
      this.btnDatos.Size = new System.Drawing.Size(143, 36);
      this.btnDatos.TabIndex = 9;
      this.btnDatos.Text = "Obtener datos";
      this.btnDatos.UseVisualStyleBackColor = false;
      this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
      // 
      // frmBanxico
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(884, 510);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.fechaFinal);
      this.Controls.Add(this.FechaInicial);
      this.Controls.Add(this.txtData);
      this.Controls.Add(this.txtTitle);
      this.Controls.Add(this.btnDatos);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmBanxico";
      this.Text = "frmBanxico";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker fechaFinal;
        private System.Windows.Forms.DateTimePicker FechaInicial;
        private System.Windows.Forms.RichTextBox txtData;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnDatos;
    }
}