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

            btnPruebas.Clicked += BtnPruebas_Clicked;
        }

        private void BtnPruebas_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new TestPage());
        }

        private void BtnCreateAccount_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Registro());
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {

            //Authentication
            string email = EntEmail.Text;
            string password = EntPass.Text;

            if ((EntEmail.Text == null) || (EntPass.Text == null))
            {
                await DisplayAlert("Authentication error", "Email address and password are required", "OK");
                EntEmail.Focus();
            }
            else
            {
                //Query to internal DB
                var queryPass = await App.SQLiteDB.GetUserByEmailAsync(email);

                if (queryPass == null)
                {
                    await DisplayAlert("Authentication error", "User not found", "OK");
                }
                else
                {

                    if (EntEmail.Text == queryPass.Email & EntPass.Text == queryPass.Password)
                    {
                        this.Navigation.PushModalAsync(new Menu());

                        EntEmail.Text = "";
                        EntPass.Text = "";
                    }

                }

            }
            
        }//End of BtnLogin


    }
}
