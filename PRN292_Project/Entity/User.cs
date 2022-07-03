using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRN292_Project
{
    public class User
    {
        public User()
        {
        }

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public string Name { get; set; }

        public string email { get; set; }
        public DateTime dob { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string password { get; set; }
    }
}