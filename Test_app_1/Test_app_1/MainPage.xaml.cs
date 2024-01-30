﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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

        public static class PageDictionary
        {
            public static Dictionary<string, Type> PageTypes = new Dictionary<string, Type>
            {
                {"MainPage", typeof(MainPage)},
                {"QA", typeof(QA_page)},
            };
        }
        private async void ButtonClick(object sender, EventArgs e)
        {
            redirText.Text = "Redirecting other page";
            await DisplayAlert("Redirect", "Redirecting", "cancel");
        }

        private async void switchPage(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonName = button.Text;

            if(PageDictionary.PageTypes.ContainsKey(buttonName))
            {
                var pageType = PageDictionary.PageTypes[buttonName];
                var page = (ContentPage)Activator.CreateInstance(pageType);

                await Navigation.PushAsync(page);
            }
            else
            {
                await DisplayAlert("Error", "Page not found", "OK");
            }
        }
    }


}
