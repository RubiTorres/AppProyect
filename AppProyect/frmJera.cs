using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AppProyect
{
  public partial class frmJera : Form
  {
    OpenFileDialog dialogo = new OpenFileDialog();
    public frmJera()
    {
      InitializeComponent();
    }
    private void btnExaminar_Click(object sender, EventArgs e)
    {
      if (dialogo.ShowDialog() != DialogResult.OK)
      {
        return;
      }
      tvJerarquia.Visible = true;
      string renglon;
      string rutaArchivo = dialogo.FileName;
      StreamReader sr = new StreamReader(rutaArchivo, Encoding.GetEncoding(1252));

      TreeNode estado = null;
      TreeNode ciudad = null;
      TreeNode codigoPostal = null;
      TreeNode colonia = null;

      while ((renglon = sr.ReadLine()) != null)
      {
        string[] datos = renglon.Split('|');
        string estadoActual = datos[4];
        string ciudadActual = datos[5];
        string codigoPostalActual = datos[1];
        string coloniaActual = datos[0];

        if (estado == null || estado.Text != estadoActual)
        {
          estado = new TreeNode(estadoActual);
          tvJerarquia.Nodes.Add(estado);
          ciudad = null;
        }

        if (ciudad == null || ciudad.Text != ciudadActual)
        {
          ciudad = new TreeNode(ciudadActual);
          estado.Nodes.Add(ciudad);
          codigoPostal = null;
        }

        if (codigoPostal == null || codigoPostal.Text != codigoPostalActual)
        {
          codigoPostal = new TreeNode(codigoPostalActual);
          ciudad.Nodes.Add(codigoPostal);
          colonia = null;
        }

        if (colonia == null || colonia.Text != coloniaActual)
        {
          colonia = new TreeNode(coloniaActual);
          codigoPostal.Nodes.Add(colonia);
        }
      }

      sr.Close();

    }
    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }    
  }
}