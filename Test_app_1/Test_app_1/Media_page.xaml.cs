using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test_app_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Media_page : ContentPage
    {
        public Media_page()
        {
            InitializeComponent();
        }

        private async void Upload(object sender, EventArgs e)
        {
            var stream = new MemoryStream();

            var storagePath = "____"; //Ввести путь в firebase storage

            
        }

    }
    
}