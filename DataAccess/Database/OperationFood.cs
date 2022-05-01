using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DataAccess.Database
{
    public class OperationFood
    {
        SqlConnection connection = new SqlConnection("Data Source=Ahmed-Shafin;Initial Catalog=Restaurant;Integrated Security=True");
        public int Insert(ManagerFood e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("insert into Fooditems values('" + e.Fooditems + " ','" + e.Price + " ')", connection);
            int flag = command.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
        public SqlDataAdapter Show()
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Fooditems  ", connection);
            connection.Close();
            return sqlDataAdapter;
        }
        public int Update(ManagerFood e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("update Fooditems set Fooditems ='" + e.Fooditems + "' where Price ='" + e.Price + "' ", connection);
            int flag = command.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
        public int Delete(ManagerFood e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("delete from Fooditems where Price ='" + e.Price + "' ", connection);
            int flag = command.ExecuteNonQuery();
            connection.Close();
            return flag;
        }



    }
}
