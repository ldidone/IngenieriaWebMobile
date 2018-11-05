using System;
using System.Collections.Generic;
using System.Text;

namespace WappoMobile.ViewModels
{
    public class PostulacionViewModel
    {
        public string EmailUsuario { get; set; }
        public int IdPedido { get; set; }
        public decimal PrecioMinimo { get; set; }
        public decimal PrecioMaximo { get; set; }
        public PostulacionViewModel(string email, int idPedido, decimal precioMinimo, decimal precioMaximo)
        {
            EmailUsuario = email;
            IdPedido = idPedido;
            PrecioMinimo = precioMinimo;
            PrecioMaximo = precioMaximo;
        }
    }
}
