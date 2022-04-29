using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using TouristCR.Models;

namespace TouristCR.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<User>().Wait();
            db.CreateTableAsync<Tour>().Wait();
        }

        //Metodo para guardar usuarios en la tabla
        public Task <int> SaveUserAsync(User usuario)
        {
            if (usuario.IdUser==0)
            {
                return db.InsertAsync(usuario);
            }
            else
            {
                return null;
            }
        }

         

        /// <summary>
        /// Nos retorna todos los usuarios y la información de cada uno en la tabla User 
        /// </summary>
        /// <returns>Toda la tabla User</returns>
        public Task<List<User>> GetUsersAsync()
        {
            return db.Table<User>().ToListAsync();
        }


        //Metodo para buscar por ID
        public  Task<User> GetUserByIdAsync(int idUser)
        {
            return db.Table<User>().Where(a => a.IdUser == idUser).FirstOrDefaultAsync();
        }

        //Metodo para buscar por Correo
        public Task<User> GetUserByEmailAsync(string email)
        {
            return db.Table<User>().Where(a => a.Email == email).FirstOrDefaultAsync();
        }

        // TOUR

        //Guardar tour en tabla
        public Task<int> SaveTourAsync(Tour nuevotour)
        {
            if (nuevotour.IdTour == 0)
            {
                return db.InsertAsync(nuevotour);
            }
            else
            {
                return null;
            }
        }

        //public Task<List<Tour>> GetToursAsync() { 
        //    return db.Table<Tour>().ToListAsync(); 
        //} 
        
    }
}
