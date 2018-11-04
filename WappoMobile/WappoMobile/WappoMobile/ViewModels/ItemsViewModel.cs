using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using WappoMobile.Models;
using WappoMobile.Views;
using WappoMobile.Contracts;
using System.Collections.Generic;

namespace WappoMobile.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        //public ObservableCollection<Item> Items { get; set; }
        public ObservableCollection<PedidosMapa> Items { get; set; }

        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Pedidos";
            //Items = new ObservableCollection<Item>();
            Items = new ObservableCollection<PedidosMapa>();

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            //MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var newItem = item as Item;
            //    Items.Add(newItem);
            //    await DataStore.AddItemAsync(newItem);
            //});
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                //var items = await DataStore.GetItemsAsync(true); //Obtener Pedidos de API
                //var items = new List<PedidosMapa>()
                //{
                //    new PedidosMapa()
                //    {
                //        IdPedido = 1,
                //        IdCliente = "asd",
                //        NombreCliente = "Lucas",
                //        DescripcionPedido = "Pizza",
                //        ObservacionesPedido = "Ninguna",
                //        Precio = 150
                //    },
                //    new PedidosMapa()
                //    {
                //        IdPedido = 2,
                //        IdCliente = "asd",
                //        NombreCliente = "Juan",
                //        DescripcionPedido = "Papas fritas",
                //        ObservacionesPedido = "Ninguna",
                //        Precio = 50
                //    }
                //};

                var items = await WappoMobile.Services.PedidosServicio.ObtenerPedidos();
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