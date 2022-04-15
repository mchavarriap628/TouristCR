using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Base22
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Take_aTour : TabbedPage
    {
        public Take_aTour()
        {
            InitializeComponent();
            btSiguienteFecha.Clicked += BtSiguienteFecha_Clicked;
            btSiguenteTiempos.Clicked += BtSiguenteTiempos_Clicked;
            btnSiguienteTarifas.Clicked += BtnSiguienteTarifas_Clicked;
            btnSalir.Clicked += BtnSalir_Clicked;
        }

        private void BtSiguenteTiempos_Clicked(object sender, EventArgs e)
        {
            var pages = Children.GetEnumerator();
            pages.MoveNext();
            pages.MoveNext();
            pages.MoveNext();
            CurrentPage = pages.Current;
        }

        private void BtnSalir_Clicked(object sender, EventArgs e)
        {
            
           // ((NavigationPage)this.Parent).PushAsync(new MainPage());
        }

        private void BtnSiguienteTarifas_Clicked(object sender, EventArgs e)
        {
            var pages = Children.GetEnumerator();
            pages.MoveNext();
           // pages.MoveNext();
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