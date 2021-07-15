using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2E2GRUPO1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaUbicaciones : ContentPage
    {
        public ListaUbicaciones()
        {
            InitializeComponent();
        }

        private void listaUbicaciones_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}