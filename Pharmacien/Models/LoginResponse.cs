using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacien.Models
{
    public class LoginResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public User user { get; set; }
        public string token { get; set; }
    }
}
