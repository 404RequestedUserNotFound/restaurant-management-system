using DataAccess.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess.Database
{
    public class RegistrationInformation
    {
       public DataBaseConnection connection;
        public DataTable dataTable;
        public int flag1, flag2;
        public int insertregistration(UserRegistration user)
        {
            try
            {
                connection = new DataBaseConnection();
               
                if (user.Malegender == "Male")
                {            
                    string query = @"Insert into LoginInformation(username,email,address,password,usertype,gender,date,phonenumber) values('" + user.Username + "','" + user.Email + "','" + user.Address + "','" + user.Password + "','" + user.Usertype + "','" + user.Malegender + "','" + user.Date + "','" + user.Phonenumber + "')";
                    flag1=connection.ExecuteQuery(query);
                }
                connection.closeconnection();
                return flag1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }

        }
        public int insert(UserRegistration user)
        {
            try
            {
                connection = new DataBaseConnection();
                if (user.Femalegender == "Female")
                {
                    string query = @"Insert into LoginInformation(username,email,address,password,usertype,gender,date,phonenumber) values('" + user.Username + "','" + user.Email + "','" + user.Address + "','" + user.Password + "','" + user.Usertype + "','" + user.Femalegender + "','" + user.Date + "','" + user.Phonenumber + "')";
                    flag2=connection.ExecuteQuery(query);                   
                }
                connection.closeconnection();
                return flag2;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public DataTable dataview()
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from LoginInformation";
               dataTable= connection.GetDataTable(query);
                connection.closeconnection();
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
           
            
        }
    }
}
