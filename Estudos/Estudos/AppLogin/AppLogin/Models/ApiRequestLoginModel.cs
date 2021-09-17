using System;
using System.Collections.Generic;
using System.Text;

namespace AppLogin.Models
{
    class ApiRequestLoginModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string grant_type = "password";
    }
}
