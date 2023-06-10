using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AppProyect
{
  public partial class frmMenu : Form
  {
    public frmMenu()
    {
      InitializeComponent();
    }
    private void btnGraficas_Click(object sender, EventArgs e)
    {
      frmGraficarC grafic = new frmGraficarC();
      grafic.Show();
    }
    private void btnLecturaArchivos_Click(object sender, EventArgs e)
    {
      frmJera jerarquia = new frmJera();
      jerarquia.Show();
    }
    private void btnMuestraCSV_Click(object sender, EventArgs e)
    {
      frmLectura Lectura = new frmLectura();
      Lectura.Show();
    }
    private void btnApi_Click(object sender, EventArgs e)
    {
      frmBanxico fr = new frmBanxico();
      fr.Show();
    }
    private void btnTablas_Click(object sender, EventArgs e)
    {
      Process.Start("file:///C:/Users/golos/source/repos/AppProyect/Java/tabla%20editable.html");
    }
    private void btnGraficasJS_Click(object sender, EventArgs e)
    {
      Process.Start("file:///C:/Users/golos/source/repos/AppProyect/Java/Graficas.html");
    }
    private void btnJerJS_Click(object sender, EventArgs e)
    {
      Process.Start("file:///C:/Users/golos/source/repos/AppProyect/Java/Jerarquia.html");
    }
    private void btnApiB_Click(object sender, EventArgs e)
    {
      Process.Start("file:///C:/Users/golos/source/repos/AppProyect/Java/Consultas%20a%20banxico.html");
    }
    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void label1_Click(object sender, EventArgs e)
    {
      btnGraficas.Visible = true;
    }
  }
}
