using System;
using System.Collections.Generic;
using System.Text;

namespace WappoMobile.Contracts
{
    public class LoginRequest
    {
        public LoginRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}
