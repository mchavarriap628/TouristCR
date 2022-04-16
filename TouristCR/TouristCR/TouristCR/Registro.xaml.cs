using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristCR.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TouristCR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
            btnCreateAccount.Clicked += BtnCreateAccount_Clicked;
        }

        private async void BtnCreateAccount_Clicked(object sender, EventArgs e)
        {
            if (validateData())
            {
                User usuario = new User
                {
                    Name = EntName.Text,
                    Email = EntEmail.Text,
                    Password = EntPass.Text,
                };

                await App.SQLiteDB.SaveUserAsync(usuario);

                EntName.Text = "";
                EntEmail.Text = "";
                EntPass.Text = "";

                await DisplayAlert("New Account", "The account have been registered successfully", "OK");


            }
            else
            {
                await DisplayAlert("Information is not valid", "Please complete the empty fields","OK");
            }

        }

        public bool validateData()
        {
            bool result;
            if (string.IsNullOrEmpty(EntName.Text))
            {
                result = false;
            }
            else if (string.IsNullOrEmpty(EntEmail.Text))
            {
                result = false;
            }
            else if (string.IsNullOrEmpty(EntPass.Text))
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }


    }
}