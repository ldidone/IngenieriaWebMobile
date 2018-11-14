using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using WappoMobile.Contracts;
using Xamarin.Forms;

namespace WappoMobile.ViewModels
{
    public class MapPageViewModel : INotifyPropertyChanged
    {
        private readonly IPedidosService _pedidosService = DependencyService.Get<IPedidosService>();

        private List<PedidosMapa> _items;

        public List<PedidosMapa> Items
        {
            get => _items;
            set
            {
                _items = value;
                OnPropertyChanged(nameof(Items));
            }
        }

        public MapPageViewModel()
        {
            Init();
        }

        private async void Init()
        {
            Items = await _pedidosService.ObtenerPedidosAsignados(App.Email, App.JWT);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
