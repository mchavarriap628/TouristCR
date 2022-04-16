using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TouristCR.Models
{
    public class User
    {
        [PrimaryKey,AutoIncrement]
        public int IdUser { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string Password { get; set; }


    }
}
