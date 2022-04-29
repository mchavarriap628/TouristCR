using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristCR.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace TouristCR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Take_aTour : TabbedPage
    {
        String hora = "";
        int precio = 0;
        public Take_aTour()
        {
            InitializeComponent();
            btSiguienteFecha.Clicked += BtSiguienteFecha_Clicked;
            btSiguenteTiempos.Clicked += BtSiguenteTiempos_Clicked;

            
            btnSalir.Clicked += BtnSalir_Clicked;

            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            btn4.Clicked += Btn4_Clicked;

            btnSolo.Clicked += BtnSolo_Clicked;
            btnParejas.Clicked += BtnParejas_Clicked;
            btnfamilia.Clicked += Btnfamilia_Clicked;
            btngrupo.Clicked += Btngrupo_Clicked;
        }

        public void correo() {
            User us = new User();
            String Body = "Date: " + dtFecha.Date.ToShortDateString()
                        + "\n Time: " + hora
                        + "\n Total Price: " + precio ;
            List<string> Mailers = new List<string>();
            Mailers.Add("bpowan@gmail.com");
            
            SendEmail("Confirmacion de Tour", Body, Mailers);

            //String mail = us.Email;
        }
        public async Task SendEmail(String subject, string body, List<string> recipientes) {
              
            try
            {
                var mensaje = new EmailMessage
                {
                    Subject = subject,
                    Body = body,
                    To = recipientes
                };
                
                await Email.ComposeAsync(mensaje);
                
            }
            catch (FeatureNotSupportedException ex)
            {

                 throw;
            }
            catch (Exception e) { throw; }   
        } 

        private void Btngrupo_Clicked(object sender, EventArgs e)
        {
            precio = 40000; 
            lbl_modalida.Text = "Selected: Groups Price 40.000";
        }

        private void Btnfamilia_Clicked(object sender, EventArgs e)
        {
            precio = 25000;
            lbl_modalida.Text = "Selected: Family 25.000 Colones ";
        }

        private void BtnParejas_Clicked(object sender, EventArgs e)
        {
            precio = 15000;
            lbl_modalida.Text = "Selected: Couples 15.000 Colones ";
        }

        private void BtnSolo_Clicked(object sender, EventArgs e)
        {
            precio = 10000;
            lbl_modalida.Text = "Selected: Alone: 10.000 Colones ";
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            hora = "5:00 pm";
            lbl_Hora.Text = "Selected time: " + hora ;
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            hora = "3:00 pm";
            lbl_Hora.Text = "Selected time: " +hora;
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            hora = "1:00 am";
            lbl_Hora.Text = "Selected time: " +hora;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            hora = " 9:00 am";
            lbl_Hora.Text = "Selected time: " +hora;
        }

        private async void BtnSalir_Clicked(object sender, EventArgs e)
        {
            // meter base de datos
            Tour tour = new Tour {
                fecha = dtFecha.Date.ToShortDateString(),
                hora = hora,
                Precio = precio,    
            };     
            await App.SQLiteDB.SaveTourAsync(tour);
            await DisplayAlert("New tour", "The time, date and package for the tour have been safe", "ok");
            correo();
            this.Navigation.PushModalAsync(new Menu());
        }

        private void BtSiguenteTiempos_Clicked(object sender, EventArgs e)
        {
            var pages = Children.GetEnumerator();
            pages.MoveNext();
            pages.MoveNext();
            pages.MoveNext();
            CurrentPage = pages.Current;
        }

        private void BtSiguienteFecha_Clicked(object sender, EventArgs e)
        {
            var pages = Children.GetEnumerator();
            pages.MoveNext(); //First page
            pages.MoveNext(); //second page
            //pages.MoveNext();
            CurrentPage = pages.Current;

              
        }
    }
}