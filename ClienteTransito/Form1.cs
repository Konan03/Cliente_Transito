using RestSharp;
using System.Dynamic;
using System.Net;
using System.Text.Json;

namespace ClienteTransito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            var options = new RestClientOptions("http://localhost:8080");
            var client = new RestClient(options);
            var request = new RestRequest($"/infracciones", Method.Get);

            var response = client.Execute(request);
            txtGet.Text = response.Content.ToString();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            String infraccion = txtPost.Text;

            var options = new RestClientOptions("http://localhost:8080");
            var client = new RestClient(options);
            var request = new RestRequest($"/infracciones", Method.Post);

            request.RequestFormat = DataFormat.Json;
            request.AddBody(new
            {
                numero = 111,
                tipo = "Mal parqueo"
            });
            RestResponse result = client.Execute(request);

            if (result.StatusCode == HttpStatusCode.Conflict)
            {
                MessageBox.Show("Error al llamar", "Error");
                dynamic jsonObj = JsonSerializer.Deserialize<ExpandoObject>(result.Content);
                txtPost.Text = Convert.ToString(jsonObj.message);
                //txtPost.Text = result.Content;
            }
            else
            {
                txtPost.Text = result.Content;
            }

        }
    }
}
