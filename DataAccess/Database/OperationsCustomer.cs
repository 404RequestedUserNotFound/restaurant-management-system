using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Database
{
   public class OperationsCustomer
    {
        public int Insert(ManagerCustomer e)
        {

            SqlConnection connection = new SqlConnection("Data Source=Ahmed-Shafin;Initial Catalog=Restaurant;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Customer values('" + e.Name + " ','" + e.Email + "',' " + e.Address + " ','" + e.Phonenumber + " ','" + e.Serialnumber + " ','" + e.Transactionover + "')", connection);
            int flag = command.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
    }
}
