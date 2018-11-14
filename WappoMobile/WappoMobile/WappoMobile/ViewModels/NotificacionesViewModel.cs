using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using WappoMobile.Contracts;
using Xamarin.Forms;

namespace WappoMobile.ViewModels
{
    public class NotificacionesViewModel : BaseViewModel
    {
        private readonly INotificacionesService _notificacionesService = DependencyService.Get<INotificacionesService>();

        public ObservableCollection<Notificacion> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public NotificacionesViewModel()
        {
            Title = "Notificaciones";
            Items = new ObservableCollection<Notificacion>();
            
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());            
        }

        async void ObtenerNotificaciones()
        {
            Items = await _notificacionesService.ObtenerPedidos(App.Email, App.JWT);
            //MyListView.ItemsSource = Items;
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await _notificacionesService.ObtenerPedidos(App.Email, App.JWT);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
