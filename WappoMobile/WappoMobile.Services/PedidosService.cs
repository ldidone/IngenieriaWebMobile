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
                //httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "ew0KICAiYWxnIjogIkhTMjU2IiwNCiAgInR5cCI6ICJKV1QiDQp9.ew0KICAidW5pcXVlX25hbWUiOiAibHVjYXMuY3JhcjE0QGdtYWlsLmNvbSIsDQogICJuYmYiOiAxNTQyMDQ5NTU3LA0KICAiZXhwIjogMTMwMzkxMDY4Mzc3LA0KICAiaWF0IjogMTU0MjA0OTU1OCwNCiAgImlzcyI6ICJodHRwOi8vbG9jYWxob3N0OjEyNzc4IiwNCiAgImF1ZCI6ICJodHRwOi8vbG9jYWxob3N0OjEyNzc4Ig0KfQ.nyLz9FL-cggm5ARX2skSZqRTj2ek8Zfbpsoj1StUnoQ");
                var response = await httpClient.GetStringAsync(url);
                return JsonConvert.DeserializeObject<List<PedidosMapa>>(response);
            }
        }

        public async Task<List<PedidosMapa>> ObtenerPedidosAsignados(string emailDelivery)
        {
            using (var httpClient = new HttpClient())
            {
                string url = "http://wappo.apphb.com/api/PedidosApi/ObtenerAsignados?emailDelivery=" + emailDelivery;
                //httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "ew0KICAiYWxnIjogIkhTMjU2IiwNCiAgInR5cCI6ICJKV1QiDQp9.ew0KICAidW5pcXVlX25hbWUiOiAibHVjYXMuY3JhcjE0QGdtYWlsLmNvbSIsDQogICJuYmYiOiAxNTQyMDQ5NTU3LA0KICAiZXhwIjogMTMwMzkxMDY4Mzc3LA0KICAiaWF0IjogMTU0MjA0OTU1OCwNCiAgImlzcyI6ICJodHRwOi8vbG9jYWxob3N0OjEyNzc4IiwNCiAgImF1ZCI6ICJodHRwOi8vbG9jYWxob3N0OjEyNzc4Ig0KfQ.nyLz9FL-cggm5ARX2skSZqRTj2ek8Zfbpsoj1StUnoQ");
                var response = await httpClient.GetStringAsync(url);
                return JsonConvert.DeserializeObject<List<PedidosMapa>>(response);
            }
        }
    }
}
