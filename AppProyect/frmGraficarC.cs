using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AppProyect
{
  public partial class frmGraficarC : Form
  {
    OpenFileDialog dialogo = new OpenFileDialog();
    public frmGraficarC()
    {
      InitializeComponent();
    }
    private void btnExaminar_Click(object sender, EventArgs e)
    {
      string renglon;
      if (dialogo.ShowDialog() != DialogResult.OK)
      {
        return;
      }
      btnExaminar.Visible = false;
      chGrafica.Visible = true;
      string rutaArchivo = dialogo.FileName;
      StreamReader dr = new StreamReader(rutaArchivo, Encoding.GetEncoding(1252));
      string x = "";
      int y = 0;
      while ((renglon = dr.ReadLine()) != null)
      {
        string[] datos = renglon.Split('|');
        if (x != datos[0] && x != "")
        {
          chGrafica.Series[0].Points.AddXY(x, y);
          y = 0;
        }
        x = datos[0];
        y++;
      }
      chGrafica.Series[0].Points.AddXY(x, y);
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
