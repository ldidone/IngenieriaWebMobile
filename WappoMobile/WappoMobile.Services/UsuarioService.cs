using System;
using System.Collections.Generic;
using System.Text;
using WappoMobile.Contracts;
using WappoMobile.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(UsuarioService))]
namespace WappoMobile.Services
{
    public class UsuarioService : IUsuarioService
    {
        //public async Task<Boolean> Login(string email, string password)
        //{
        //    string url = "http://localhost:8080/api/news";
        //    using (var httpClient = new HttpClient())
        //    {
        //        var response = await httpClient.GetStringAsync(url);
        //        return JsonConvert.DeserializeObject<Boolean>(response);
        //    }
        //}

        //Prueba
        public bool Login(string email, string password)
        {
            return true;
        }

        public static bool ValidarLogin(string email, string password)
        {
            return true;
        }
    }
}
