using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacien.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string tel { get; set; }
        public string role { get; set; }
    }
}
