using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Database
{
    public class DataBaseConnection
    {
        private string connectionstring;
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataAdapter sqlDataAdapter;
        public DataTable dataTable;
        public DataBaseConnection()
        {
            connectionstring = @"Data Source=Ahmed-Shafin;Initial Catalog=Restaurant;Integrated Security=True";
            connection = new SqlConnection(connectionstring);
            connection.Open();
        }
        public int ExecuteQuery(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteNonQuery();
        }
        public SqlDataReader Readdata(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteReader();
        }
        public DataTable GetDataTable(string sql)
        {
            sqlDataAdapter = new SqlDataAdapter(sql, connection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void closeconnection()
        {
            connection.Close();
        }


    }
}
