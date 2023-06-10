using System;
using System.Net;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppProyect
{
  public partial class frmBanxico : Form
  {
    public frmBanxico()
    {
      InitializeComponent();
    }
    private void btnDatos_Click(object sender, EventArgs e)
    {

      {
        DateTime startDate = FechaInicial.Value;
        DateTime endDate = fechaFinal.Value;

        Response response = ReadSerie(startDate, endDate);
        if (response != null)
        {
          txtData.Visible = true;
          txtTitle.Visible = true;
          Serie serie = response.seriesResponse.series[0];
          txtTitle.Text = serie.Title;

          foreach (DataSerie dataSerie in serie.Data)
          {
            if (dataSerie.Data.Equals("N/E")) continue;
            txtData.AppendText("Fecha: " + dataSerie.Date + Environment.NewLine);
            txtData.AppendText("Dato: " + dataSerie.Data + Environment.NewLine);
          }
        }
      }
    }
    static Response ReadSerie(DateTime startDate, DateTime endDate)
    {
      try
      {
        string url = string.Format("https://www.banxico.org.mx/SieAPIRest/service/v1/series/SF43718/datos/{0}/{1}", startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));

        HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
        request.Accept = "application/json";
        request.Headers["Bmx-Token"] = "3f03787e7c901d37d467f9fb66cd2e6ff8aa11e518b3307aadb7f1d9d4d58951";
        HttpWebResponse response = request.GetResponse() as HttpWebResponse;
        if (response.StatusCode != HttpStatusCode.OK)
          throw new Exception(String.Format(
          "Server error (HTTP {0}: {1}).",
          response.StatusCode,
          response.StatusDescription));
        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
        object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
        Response jsonResponse = objResponse as Response;
        return jsonResponse;
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
      return null;
    }
    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
