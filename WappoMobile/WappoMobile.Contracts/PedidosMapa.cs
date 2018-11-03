﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WappoMobile.Contracts
{
    public class PedidosMapa
    {
        public int IdPedido { get; set; }
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string DescripcionPedido { get; set; }
        public string ObservacionesPedido { get; set; }
        public string DireccionOrigen { get; set; }
        public string DireccionDestino { get; set; }
        public double Distancia { get; set; }
        public decimal Precio { get; set; }
        public double LatOrigen { get; set; }
        public double LngOrigen { get; set; }
        public bool Postulado { get; set; }
    }
}
