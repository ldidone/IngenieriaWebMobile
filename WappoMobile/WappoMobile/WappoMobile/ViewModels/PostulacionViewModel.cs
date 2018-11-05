using System;
using System.Collections.Generic;
using System.Text;

namespace WappoMobile.ViewModels
{
    public class PostulacionViewModel
    {
        public string EmailUsuario { get; set; }
        public int IdPedido { get; set; }
        public PostulacionViewModel(string email, int idPedido)
        {
            EmailUsuario = email;
            IdPedido = idPedido;
        }
    }
}
