using System;
using System.Collections.Generic;
using System.Text;
using WappoMobile.Contracts;
using Xamarin.Forms;
using WappoMobile.Services;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

[assembly: Dependency(typeof(NotificacionesService))]
namespace WappoMobile.Services
{
    public class NotificacionesService : INotificacionesService
    {
        public async Task<ObservableCollection<Notificacion>> ObtenerPedidos(string emailUsuario)
        {
            using (var httpClient = new HttpClient())
            {
                string url = "http://wappo.apphb.com/api/NotificacionesApi/ObtenerPostulacionesAceptadas?emailUsuario=" + emailUsuario;
                var response = await httpClient.GetStringAsync(url);
                return JsonConvert.DeserializeObject<ObservableCollection<Notificacion>>(response);
            }
        }
    }
}
