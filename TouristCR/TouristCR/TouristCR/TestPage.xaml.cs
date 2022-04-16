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