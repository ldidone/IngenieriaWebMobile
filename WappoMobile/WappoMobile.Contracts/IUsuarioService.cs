using System;
using System.Collections.Generic;
using System.Text;

namespace WappoMobile.Contracts
{
    public interface IUsuarioService
    {
        //Task<Boolean> Login(string email, string password);
        bool Login(string email, string password);
    }
}
