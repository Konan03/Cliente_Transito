using RestSharp;

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
            var request = new RestRequest($"/infracciones/" + infraccion, Method.Post);

            client.Execute(request);
        }
    }
}
