using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WappoMobile.Contracts;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using WappoMobile.Services;

[assembly: Dependency(typeof(PedidosService))]
namespace WappoMobile.Services
{
    public class PedidosService : IPedidosService
    {
        public async Task<List<PedidosMapa>> ObtenerPedidos()
        {
            using (var httpClient = new HttpClient())
            {
                string url = "http://wappo.apphb.com/api/PedidosApi/ObtenerPendientes/";
                var response = await httpClient.GetStringAsync(url);
                return JsonConvert.DeserializeObject<List<PedidosMapa>>(response);
            }
        }

        public async Task<List<PedidosMapa>> ObtenerPedidosAsignados(string emailDelivery)
        {
            using (var httpClient = new HttpClient())
            {
                string url = "http://wappo.apphb.com/api/PedidosApi/ObtenerAsignados?emailDelivery=" + emailDelivery;
                var response = await httpClient.GetStringAsync(url);
                return JsonConvert.DeserializeObject<List<PedidosMapa>>(response);
            }
        }
    }
}
