using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WappoMobile.Contracts;
using System.Net.Http;
using Newtonsoft.Json;

namespace WappoMobile.Services
{
    public class PedidosServicio
    {
        public static async Task<List<PedidosMapa>> ObtenerPedidos()
        {
            using (var httpClient = new HttpClient())
            {
                string url = "http://wappo.apphb.com/api/PedidosApi/ObtenerPendientes/";
                var response = await httpClient.GetStringAsync(url);
                return JsonConvert.DeserializeObject<List<PedidosMapa>>(response);
            }
        }
    }
}
