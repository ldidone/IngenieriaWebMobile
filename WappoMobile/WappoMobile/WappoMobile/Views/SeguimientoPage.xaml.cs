using Plugin.Geolocator;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WappoMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SeguimientoPage : ContentPage
	{
		public SeguimientoPage ()
		{
			InitializeComponent ();
		}

        private async void activarSeguimiento_Toggled(object sender, ToggledEventArgs e)
        {
            bool activado = e.Value;
            if (activado)
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Location);
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Location))
                    {
                        await DisplayAlert("Necesita ubicación", "La aplicación necesita la ubicación.", "OK");
                    }

                    var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Location);
                    if (results.ContainsKey(Permission.Location))
                        status = results[Permission.Location];
                }

                if (status == PermissionStatus.Granted)
                {
                    var results = await CrossGeolocator.Current.GetPositionAsync(new TimeSpan(1, 0, 0));
                    await DisplayAlert("Seguimiento activado", "El seguimiento ha sido activado correctamente.", "OK");
                    if (!CrossGeolocator.Current.IsListening)
                    {
                        await CrossGeolocator.Current.StartListeningAsync(new TimeSpan(0, 0, 5), 20); //Tiempo mínimo: 5 seg - distancia: 20 metros
                    }

                    CrossGeolocator.Current.PositionChanged += (cambio, args) =>
                    {
                        var loc = args.Position;
                    };
                    
                }
                else if (status != PermissionStatus.Unknown)
                {
                    await DisplayAlert("Ubicación denegada", "No puede continuar, inténtalo de nuevo.", "OK");
                }
            }
            else
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Location);
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Location))
                    {
                        await DisplayAlert("Necesita ubicación", "La aplicación necesita la ubicación.", "OK");
                    }

                    var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Location);
                    if (results.ContainsKey(Permission.Location))
                        status = results[Permission.Location];
                }

                if (status == PermissionStatus.Granted)
                {
                    if (CrossGeolocator.Current.IsListening)
                    {
                        await CrossGeolocator.Current.StopListeningAsync();
                        await DisplayAlert("Seguimiento desactivado", "El seguimiento se ha desactivado.", "OK");
                    }
                    else
                    {
                        await DisplayAlert("Seguimiento desactivado", "El seguimiento no se encontraba activado.", "OK");
                    }
                }
                else if (status != PermissionStatus.Unknown)
                {
                    await DisplayAlert("Ubicación denegada", "No puede continuar, inténtalo de nuevo.", "OK");
                }
                
            }
        }
    }
}