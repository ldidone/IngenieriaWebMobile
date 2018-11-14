using System;
using System.Collections.Generic;
using System.Text;

namespace WappoMobile.Contracts
{
    public class Postulacion
    {
        public string EmailUsuario { get; set; }
        public string JWT { get; set; }
        public int IdPedido { get; set; }
        public int Tiempo { get; set; }
        public decimal Precio { get; set; }
    }
}
