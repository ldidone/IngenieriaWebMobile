using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WappoMobile.Contracts
{
    public interface IPedidosService
    {
        Task<List<PedidosMapa>> ObtenerPedidos(string emailDelivery, string JWT);
        Task<List<PedidosMapa>> ObtenerPedidosAsignados(string emailDelivery, string JWT);
    }
}
