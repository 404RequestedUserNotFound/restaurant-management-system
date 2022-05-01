using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class ResetUserNamePassword
    {
        public string Validemail
        {
            get;
            set;
        }
        public string Validphonenumber
        {
            get;
            set;
        }
        public string Validpassword
        {
            get;
            set;
        }
        public string Newname
        {
            get;
            set;
        }
        public string Newpassword
        {
            get;
            set;
        }
        public string Confirmpassword
        {
            get;
            set;
        }
    }
}
