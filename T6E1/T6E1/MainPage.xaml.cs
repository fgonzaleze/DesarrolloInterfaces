using Microsoft.UI.Xaml.Media;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace T6E1
{
    public partial class MainPage : ContentPage
    {
        Boolean btnExiste = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btn2Clicker(object sender, EventArgs e)
        {
            if (btnExiste == false)
            {
                Button bt3 = new Button
                {

                    Text = "Botón 3",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    FontFamily = "Verdana",
                    FontAttributes = FontAttributes.Bold,
                    FontSize = 16,
                    HeightRequest = 70,
                    WidthRequest = 200,
                    BorderColor= Colors.Orange,
                    BackgroundColor= Colors.Blue,
                    Margin = 30,
                    BorderWidth = 4,

                };
                btnExiste = true;
                vlsBtns.Children.Add(bt3);
                bt3.Clicked += new EventHandler(btn3Clicker);
            }

        }
        private void btn3Clicker(object sender, EventArgs e)
        {
            vlsBtns.Children.Remove(btn1);
        }

    }
}