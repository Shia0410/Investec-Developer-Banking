namespace InvDevBank_Frontend
{
    public partial class MainPage : ContentPage
    {
        string count = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            HttpClient client = new();

           try
           {
               var temp = client.GetAsync("https://localhost:32774/GetWeatherForecast").Result;
               CounterBtn.Text = temp.ToString();
            }
           catch (Exception ex)
           {
                CounterBtn.Text = ex.Message;
           }
        }
    }

}
