using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using WappoMobile.Contracts;

namespace WappoMobile.ViewModels
{
    public class MapPageViewModel : INotifyPropertyChanged
    {
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

        private void Init()
        {
            Items = new List<PedidosMapa>
            {
                new PedidosMapa
                {
                    IdPedido = 1,
                    DescripcionPedido = "Empanadas",
                    NombreCliente = "Lucas Didoné",
                    LatOrigen = 13.6946923,
                    LngOrigen = -89.2414103,
                    DireccionDestino = "Dirección"
                },

                new PedidosMapa
                {
                    IdPedido = 2,
                    DescripcionPedido = "Pizza",
                    NombreCliente = "Lucas Didoné",
                    LatOrigen = 13.703869,
                    LngOrigen = -89.248569,
                    DireccionDestino = "Dirección"
                },

                new PedidosMapa
                {
                    IdPedido = 3,
                    DescripcionPedido = "Milanesa",
                    NombreCliente = "Lucas Didoné",
                    LatOrigen = 13.67534,
                    LngOrigen = -89.2868771,
                    DireccionDestino = "Dirección"
                }              
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
