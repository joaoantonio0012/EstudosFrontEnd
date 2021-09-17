using System;
using System.Collections.Generic;
using System.Text;

namespace AppLogin.Models
{
    class ApiResponseLoginModel
    {
        public string AuthenticationToken { get; set; }
        public User Usuario { get; set; }
        public class User
        {
            public string UserId { get; set; }
        }
        
    }
}
