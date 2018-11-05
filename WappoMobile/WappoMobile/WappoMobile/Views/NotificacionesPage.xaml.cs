using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using WappoMobile.Contracts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WappoMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificacionesPage : ContentPage
    {
        private readonly INotificacionesService _notificacionesService = DependencyService.Get<INotificacionesService>();

        public ObservableCollection<Notificacion> Items { get; set; }
        public NotificacionesPage()
        {
            InitializeComponent();

            ObtenerNotificaciones();
            Title = "Notificaciones";           
        }

        async void ObtenerNotificaciones()
        {
            Items = await _notificacionesService.ObtenerPedidos(App.Email);
            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Notificación", "¡Postulación aceptada!", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
