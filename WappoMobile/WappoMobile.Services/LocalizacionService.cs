using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WappoMobile.Contracts;
using WappoMobile.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(LocalizacionService))]
namespace WappoMobile.Services
{
    public class LocalizacionService : ILocalizacionService
    {
        public async void EnviarCoordenada(Coordenada coordenada)
        {
            string url = "http://wappo.apphb.com/api/localizacion/almacenarlocalizacion";
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(coordenada), UnicodeEncoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(url, content);
            }
        }
    }
}
