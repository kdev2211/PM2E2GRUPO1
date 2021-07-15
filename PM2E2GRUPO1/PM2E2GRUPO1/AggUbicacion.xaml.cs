using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2E2GRUPO1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AggUbicacion : ContentPage
    {
        public AggUbicacion(Double lat, Double lng)
        {
            InitializeComponent();

            latitud.Text = lat.ToString();

            longitud.Text = lng.ToString();
        }


        protected async override void OnAppearing()
        {
            var tomarfoto = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "MiApp",
                Name = "Prueba.jpg",
                SaveToAlbum = true

            });







            if (tomarfoto != null)
            {
                foto.Source = ImageSource.FromStream(() =>
                {
                    return tomarfoto.GetStream();
                });
            }


        }



        private async void guardarUbicacion_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(descripcion.Text))
            {
                await this.DisplayToastAsync("Asegurate de llenar los campos vacios", 10000);

            }
        }

        private async void verListaUbicaciones_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ListaUbicaciones());
        }
    }
}