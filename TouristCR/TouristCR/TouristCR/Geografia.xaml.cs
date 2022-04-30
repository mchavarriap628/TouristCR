using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using Map = Xamarin.Essentials.Map;

namespace TouristCR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Geografia : ContentPage
    {
        public Geografia()
        {
            InitializeComponent();
            boton1.Clicked += Boton1_Clicked;
            boton2.Clicked += Boton2_Clicked;
            boton3.Clicked += Boton3_Clicked;
            btnMaps.Clicked += BtnMaps_Clicked;

        }

        private void BtnMaps_Clicked(object sender, EventArgs e)
        {
            double lat = 9.667335398634547;
            double lng = -85.07645139822948;

            Map.OpenAsync(lat, lng, new MapLaunchOptions
            {
                Name = "Montezuma",
                NavigationMode = NavigationMode.Driving
                //navegationmode.Driving, transit, walking etc...
            });
        }

        //How to get there
        private void Boton3_Clicked(object sender, EventArgs e)
        {
            Label2.IsVisible = true;
            btnMaps.IsVisible = true;
            about1.IsVisible = false;
            about2.IsVisible = false;
            about3.IsVisible = false;
            imagen1.IsVisible = false;
            imagen2.IsVisible = false;

        }

        //Image
        private void Boton2_Clicked(object sender, EventArgs e)
        {
            imagen1.IsVisible = true;
            imagen2.IsVisible = true;
            Label2.IsVisible = false;
            btnMaps.IsVisible = false;
            about1.IsVisible = false;
            about2.IsVisible = false;
            about3.IsVisible = false;
        }

        //About
        private void Boton1_Clicked(object sender, EventArgs e)
        {
            about1.IsVisible = true;
            about2.IsVisible = true;
            about3.IsVisible = true;
            Label2.IsVisible = false;
            btnMaps.IsVisible = false;
            imagen1.IsVisible = false;
            imagen2.IsVisible = false;


        }

    }
}
