using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using WappoMobile.Models;
using WappoMobile.ViewModels;
using WappoMobile.Contracts;

namespace WappoMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new PedidosMapa
            {
                DescripcionPedido = "Descripción pedido",
                NombreCliente = "Lucas Didoné"
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}