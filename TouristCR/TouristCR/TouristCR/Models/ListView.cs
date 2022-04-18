using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace TouristCR.Models
{
    internal class ListView : Atracciones
    {
        public ObservableCollection<Atraccion> Infolist { get; set; }

        public ListView()
        {
            Infolist = new ObservableCollection<Atraccion>
            {
                new Atraccion(){ ID = 1,archivo="drawable/iconsAtracciones.png", Name ="Montezuma Falls" , Description ="playa", City="Puntarenas" },
                new Atraccion(){ ID = 2,archivo="drawable/iconsAtracciones.png", Name ="Rio" , Description ="playa", City="Puntarenas" },
            };
        }
    }

            public class Atraccion
            {
                public int ID { get; set; }

                public string archivo { get; set; }
                public string Name { get; set; }
                public string Description { get; set; }
                public string City { get; set; }
            }
}
