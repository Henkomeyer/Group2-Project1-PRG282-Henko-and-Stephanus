using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_Project_MainProgram
{
    class UserDetail
    {
        public UserDetail(string username, string password)
        {
            Username = username;
            Password = password;
        }

        internal string Username { get; set; }

        internal string Password { get; set; }

        public string Storeinfo()
        {
            return $"{this.Username},{this.Password}";
        }

    }
}
