using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test_app_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ratings_page : ContentPage
    {
        public Ratings_page()
        {
            InitializeComponent();
        }

    }

    var mongoService = new MongoDB("mongodb+srv://egbogachev:Fy;bUfyytn63!@clusterapp1.pcupio0.mongodb.net/?retryWrites=true&w=majority", )
}