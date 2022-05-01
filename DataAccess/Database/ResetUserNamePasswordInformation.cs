using DataAccess.Entities;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess.Database
{
    public class ResetUserNamePasswordInformation
    {
        public DataBaseConnection connection;
        int flag;
        public int resetpassword(ResetUserNamePassword resetNamePassword)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from LoginInformation where email='" + resetNamePassword.Validemail + "' and phonenumber='" + resetNamePassword.Validphonenumber + "'";
                SqlDataReader reader = connection.Readdata(query);
                if (reader.Read() == true)
                {
                    string sql = "Update LoginInformation set username='" + resetNamePassword.Newname + "', password='" + resetNamePassword.Newpassword + "'where email='" + resetNamePassword.Validemail + "'and phonenumber='" + resetNamePassword.Validphonenumber + "'";
                    reader.Close();
                    flag = connection.ExecuteQuery(sql);
                }
                else
                {
                    MessageBox.Show("Invalid Email Address and Phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.closeconnection();
                return flag;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
    }
}
