using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TouristCR.Models
{
    public  class Tour
    {
        [PrimaryKey, AutoIncrement]
        public int IdTour { get; set; }

        [MaxLength(100)]
        public string fecha { get; set; }

        [MaxLength(100)]
        public string hora { get; set; }
        
        [MaxLength(100)]
        public int Precio { get; set; }
    }
}
