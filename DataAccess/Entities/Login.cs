using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Login
    {
        private string username, password, usertype;

        public string Username
        {
            set
            {
                username = value;
            }
            get
            {
                return username;
            }
        }
        public string Password
        {
            set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }
        public string Usertype
        {
            set
            {
                usertype = value;
            }
            get
            {
                return usertype;
            }
        }
    }
}
