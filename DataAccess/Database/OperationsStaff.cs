using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Database
{
    public class OperationsStaff
    {
        SqlConnection connection = new SqlConnection("Data Source=Ahmed-Shafin;Initial Catalog=Restaurant;Integrated Security=True");
        public int Insert(ManagerStaff e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("insert into staffsalaryinfo values('" + e.Name + " ','" + e.Id + " ',' " + e.Salary + "')", connection);
            int flag = command.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
        public SqlDataAdapter Show()
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from staffsalaryinfo ", connection);
            connection.Close();
            return sqlDataAdapter;
        }
        public int Update(ManagerStaff e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("update staffsalaryinfo set Name ='" + e.Name + "' where Id ='" + e.Id + "' ", connection);
            int flag = command.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
        public int Delete(ManagerStaff e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("delete from staffsalaryinfo where Id ='" + e.Id + "' ", connection);
            int flag = command.ExecuteNonQuery();
            connection.Close();
            return flag;
        }
    }
}
