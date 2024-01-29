using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;

namespace Test_app_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            WebView webView = new WebView
            {
                Source = "Map_API.html",
                VerticalOptions = LayoutOptions.StartAndExpand
            };

        }

        private async void ButtonClick(object sender, EventArgs e)
        {
            redirText.Text = "Redirecting other page";
            await DisplayAlert("Redirect", "Redirecting", "cancel");
        }

        
    }
}
