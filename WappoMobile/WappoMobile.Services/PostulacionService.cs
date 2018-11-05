using System;
using System.Collections.Generic;
using System.Text;
using WappoMobile.Contracts;
using Xamarin.Forms;
using WappoMobile.Services;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using RestSharp;

[assembly: Dependency(typeof(PostulacionService))]
namespace WappoMobile.Services
{
    public class PostulacionService : IPostulacionService
    {
        public async Task<bool> Postularse(Postulacion postulacion)
        {
            string url = "http://wappo.apphb.com/api/PostulacionApi/Postularse";       
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(postulacion), UnicodeEncoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(url, content); 
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
