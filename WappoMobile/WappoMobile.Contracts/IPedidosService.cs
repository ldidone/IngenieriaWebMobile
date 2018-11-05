using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WappoMobile.Contracts
{
    public interface IPedidosService
    {
        Task<List<PedidosMapa>> ObtenerPedidos();
        Task<List<PedidosMapa>> ObtenerPedidosAsignados(string emailDelivery);
    }
}
