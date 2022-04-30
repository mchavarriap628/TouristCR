using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TouristCR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Atracciones : ContentPage
    {
        public IList<ListaAtracciones> Listas { get; private set; }
        public Atracciones()
        {
            InitializeComponent();
            Listas = new List<ListaAtracciones>();

            Listas.Add(new ListaAtracciones
            {
                Name = "Montezuma Beach",
                Ubicacion = "Puntarenas",
                Url = "https://rovology.com/wp-content/uploads/2020/03/beach-2.jpg"
            });

            Listas.Add(new ListaAtracciones
            {
                Name = "Chicos Bar",
                Ubicacion = "Puntarenas",
                Url = "https://rovology.com/wp-content/uploads/2020/03/chicos-bar.jpg"
            });

            Listas.Add(new ListaAtracciones
            {
                Name = "Cabo Blanco Absolute Natural Reserve",
                Ubicacion = "Puntarenas",
                Url = "https://rovology.com/wp-content/uploads/2020/03/Isle_Cabo_Blanco.jpg"
            });

            Listas.Add(new ListaAtracciones
            {
                Name = "Montezuma Waterfall",
                Ubicacion = "Puntarenas",
                Url = "https://rovology.com/wp-content/uploads/2020/03/waterfall.jpg"
            });

            Listas.Add(new ListaAtracciones
            {
                Name = "The Canopy Tour",
                Ubicacion = "Puntarenas",
                Url = "https://rovology.com/wp-content/uploads/2020/03/canopy-tour.jpg"
            });

            Listas.Add(new ListaAtracciones
            {
                Name = "Cocalito Falls",
                Ubicacion = "Puntarenas",
                Url = "https://rovology.com/wp-content/uploads/2020/03/cocalito-falls.jpg"
            });

            Listas.Add(new ListaAtracciones
            {
                Name = "Cueva Muercielagos Nature Reserve",
                Ubicacion = "Puntarenas",
                Url = "https://rovology.com/wp-content/uploads/2020/03/Cueva-Murcielagos-Nature-Reserve.jpg"
            });

            Listas.Add(new ListaAtracciones
            {
                Name = "Pura Vida Surfers",
                Ubicacion = "Puntarenas",
                Url = "https://rovology.com/wp-content/uploads/2020/03/surfer.jpg"
            });

            BindingContext = this;


        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListaAtracciones selectedItem = e.SelectedItem as ListaAtracciones;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListaAtracciones tappedItem = e.Item as ListaAtracciones;
        }

    }
}
