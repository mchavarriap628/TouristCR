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
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
            btnVerTabla.Clicked += BtnVerTabla_Clicked;
            btnBuscarPorCorreo.Clicked += BtnBuscarPorCorreo_Clicked;
        }

        private async void BtnBuscarPorCorreo_Clicked(object sender, EventArgs e)
        {

            string correo = entCorreo.Text;
            var resultado = await App.SQLiteDB.GetUserByEmailAsync(correo);
            if (correo==null)
            {
                await DisplayAlert("Error","Se requiere de un dato para la busqueda","OK"); 
                entCorreo.Focus();
            }
            else
            {
                if (resultado == null)
                {
                    txtResultado.Text = "No se encontro el usuario";
                }
                else
                {
                    txtResultado.Text = resultado.IdUser + " " + resultado.Name + " " + resultado.Email + " " + resultado.Password;
                }
            }

        }

        private async void BtnVerTabla_Clicked(object sender, EventArgs e)
        {
            var usersList = await App.SQLiteDB.GetUsersAsync();
            if (usersList != null)
            {
                lstUsers.ItemsSource = usersList;
            }
        }
    }
}