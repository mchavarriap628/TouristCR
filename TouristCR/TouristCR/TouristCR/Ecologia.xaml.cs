using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TouristCR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ecologia : ContentPage
    {
        public Ecologia()
        {
            InitializeComponent();
            boton3.Clicked += Boton3_Clicked;
            boton4.Clicked += Boton4_Clicked;

        }

        private void Boton4_Clicked(object sender, EventArgs e)
        {
            imagen5.IsVisible = true;
            imagen6.IsVisible = true;

        }

        private void Boton3_Clicked(object sender, EventArgs e)
        {
            imagen3.IsVisible = true;
            imagen4.IsVisible = true;
        }
    }
}