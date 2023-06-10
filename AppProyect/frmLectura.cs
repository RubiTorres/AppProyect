using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AppProyect
{
  public partial class frmLectura : Form
  {
    OpenFileDialog dialogo = new OpenFileDialog();
    public frmLectura()
    {
      InitializeComponent();
      lstvDatos.View = View.Details;
    }
    private void btnExaminar_Click(object sender, EventArgs e)
    {
      if (dialogo.ShowDialog() != DialogResult.OK)
      {
        return;
      }
      lstvDatos.Visible = true;
      btnExportar.Visible = true;
      lstvDatos.Clear();
      string rutaArchivo = dialogo.FileName;
      StreamReader sr = new StreamReader(rutaArchivo, Encoding.GetEncoding(1252));
      string columnas = sr.ReadLine();
      string[] columna = columnas.Split('|');
      for (int i = 0; i < columna.Length; i++)
      {
        lstvDatos.Columns.Add(columna[i]);
      }
      string renglon;
      while ((renglon = sr.ReadLine()) != null)
      {
        string[] datos = renglon.Split('|');
        ListViewItem item = new ListViewItem(datos[0]);
        for (int i = 1; i < datos.Length; i++)
        {
          item.SubItems.Add(datos[i]);
        }
        lstvDatos.Items.Add(item);

      }
    }
    private void btnExportar_Click(object sender, EventArgs e)

    {
      SaveFileDialog sfd = new SaveFileDialog();
      sfd.Filter = "CSV|*.csv| txt|*.txt";
      if (sfd.ShowDialog() != DialogResult.OK)
      {
        return;
      }
      StreamWriter sw = new StreamWriter(sfd.FileName);
      foreach (ListViewItem item in lstvDatos.Items)
      {
        int i = 1;
        foreach (ListViewItem.ListViewSubItem sub in item.SubItems)
        {
          if (i == lstvDatos.Columns.Count)
          {
            sw.Write(sub.Text);
            sw.WriteLine();
            i = 0;
          }
          else
          {
            sw.Write(sub.Text + ",");
            i++;
          }
        }
      }
      sw.Close();
    }
    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
