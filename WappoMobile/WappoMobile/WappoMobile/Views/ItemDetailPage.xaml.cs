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

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            string Email = App.Email;
            int IdPedido = Convert.ToInt32(idPedido.Text);
            decimal PrecioMinimo = viewModel.Item.PrecioMinimo;
            decimal PrecioMaximo = viewModel.Item.PrecioMaximo;
            PostulacionViewModel postulacionViewModel = new PostulacionViewModel(Email, IdPedido, PrecioMinimo, PrecioMaximo);
            await Navigation.PushAsync(new Views.PostularsePage(postulacionViewModel));                         
        }
    }
}