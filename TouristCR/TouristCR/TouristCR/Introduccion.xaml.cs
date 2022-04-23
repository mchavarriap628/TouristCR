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
    public partial class Introduccion : ContentPage
    {
        public Introduccion()
        {
            InitializeComponent();

            btnTakeTour.Clicked += BtnTakeTour_Clicked;

        }

        private void BtnTakeTour_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Take_aTour());
        }
    }
}