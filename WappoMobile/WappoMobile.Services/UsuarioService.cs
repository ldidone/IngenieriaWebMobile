using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WappoMobile.Contracts;
using WappoMobile.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(UsuarioService))]
namespace WappoMobile.Services
{
    public class UsuarioService : IUsuarioService
    {
        public async Task<bool> Login(string email, string password)
        {
            string url = "http://wappo.apphb.com/api/LoginApi/LoginValido?email=" + email + "&password=" + password;
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);
                return JsonConvert.DeserializeObject<bool>(response);
            }
        }

        //Prueba
        //public bool Login(string email, string password)
        //{
        //    return true;
        //}

        public static async Task<bool> ValidarLogin(string email, string password)
        {
            string url = "http://wappo.apphb.com/api/LoginApi/LoginValido?email=" + email + "&password=" + password;
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);
                return JsonConvert.DeserializeObject<bool>(response);
            }
        }

        //public static bool ValidarLogin(string email, string password)
        //{
        //    return true;
        //}
    }
}
