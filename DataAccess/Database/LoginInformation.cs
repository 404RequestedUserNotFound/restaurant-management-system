using DataAccess.Entities;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess.Database
{
    public class LoginInformation
    {
        public DataBaseConnection connection; 
        public bool insertlogin(Login login)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from LoginInformation where username='" + login.Username + "' and password='" + login.Password + "' and usertype='" + login.Usertype + "'";
                SqlDataReader reader=connection.Readdata(query);
               
                return reader.Read();
                
            }
            
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
               
      
            }
            

        }
        
    }
}
