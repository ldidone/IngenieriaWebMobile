using System;
using System.Collections.Generic;
using System.Text;

namespace WappoMobile.Contracts
{
    public class Notificacion
    {
        public string Descripcion { get; set; }
        /*Info pedido*/
        public string DescripcionPedido { get; set; }
        public string ObservacionPedido { get; set; }
        public string NombreCliente { get; set; }
        public string DireccionOrigen { get; set; }
        public string DireccionDestino { get; set; }
        public decimal Precio { get; set; }
    }
}
