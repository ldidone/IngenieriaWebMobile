using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WappoMobile.Contracts
{
    public interface IUsuarioService
    {
        Task<string> Login(string email, string password);
        //bool Login(string email, string password);
    }
}
