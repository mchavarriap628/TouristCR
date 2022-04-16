using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TouristCR
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnLogin.Clicked += BtnLogin_Clicked;
            btnCreateAccount.Clicked += BtnCreateAccount_Clicked;
        }

        private void BtnCreateAccount_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Registro());
        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            if (EntEmail.Text == "manuel@ya.com" & EntPass.Text == "123")
            {
                this.Navigation.PushModalAsync(new Menu());

                EntEmail.Text = "";
                EntPass.Text = "";
            }
            else
            {
                mensajeEmergenteAsync("Authentication Error", "Please verify the password or email are valid.");
            }
        }

        public async Task mensajeEmergenteAsync(String titulo, String mensaje)
        {
            await DisplayAlert(titulo, mensaje, "OK");
        }



    }
}
