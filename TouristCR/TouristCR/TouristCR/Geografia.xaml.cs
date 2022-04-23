using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace TouristCR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Geografia : ContentPage
    {
        public Geografia()
        {
            InitializeComponent();
            boton1.Clicked += Boton1_Clicked;
            Label1.IsVisible = false;
            Label2.IsVisible = false;
            boton2.Clicked += Boton2_Clicked;
            boton3.Clicked += Boton3_Clicked;

        }

        private void Boton3_Clicked(object sender, EventArgs e)
        {
            Label2.IsVisible = true;
            Label1.IsVisible = false;
            imagen1.IsVisible = false;
            imagen2.IsVisible = false;

        }

        private void Boton2_Clicked(object sender, EventArgs e)
        {
            imagen1.IsVisible = true;
            imagen2.IsVisible = true;
            Label2.IsVisible = false;
            Label1.IsVisible = false;
        }

        private void Boton1_Clicked(object sender, EventArgs e)
        {
            Label1.IsVisible = true;
            Label2.IsVisible = false;
            imagen1.IsVisible = false;
            imagen2.IsVisible = false;


        }

    }
}
