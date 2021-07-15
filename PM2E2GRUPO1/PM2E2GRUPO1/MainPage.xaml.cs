using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;

namespace PM2E2GRUPO1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void addUbicacion_Clicked(object sender, EventArgs e)
        {




                String conexion = CrossConnectivity.Current.IsConnected ? "Connected" : "Disconnected";

                if (conexion != "Disconnected")
                {
                    await Navigation.PushAsync(new AggUbicacion());
                }
                else {

                    await this.DisplayToastAsync("Asegurate de estar conectado a la red", 10000);

                }
            }


    

        private async void listUbicaciones_Clicked(object sender, EventArgs e)
        {

     

            String conexion = CrossConnectivity.Current.IsConnected ? "Connected" : "Disconnected";

            if (conexion == "Disconnected")
            {
                await this.DisplayToastAsync("Asegurate de estar conectado a la red", 10000);
            }
            else
            {

                await Navigation.PushAsync(new ListaUbicaciones());
            }
        }
    }
}
