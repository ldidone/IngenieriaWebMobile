using System;
using WappoMobile.Contracts;
using WappoMobile.Models;

namespace WappoMobile.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public PedidosMapa Item { get; set; }
        public ItemDetailViewModel(PedidosMapa item = null)
        {
            Title = item?.DescripcionPedido;
            Item = item;
        }
    }
}
